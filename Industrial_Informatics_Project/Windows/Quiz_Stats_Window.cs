using Industrial_Informatics_Project.DataModel;
using Industrial_Informatics_Project.Scripts.Games;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Industrial_Informatics_Project.Windows
{
    public partial class Quiz_Stats_Window : Form
    {
        Application_Controller application_controller;

        public Quiz_Stats_Window(Application_Controller application_controller)
        {
            InitializeComponent();
            this.application_controller = application_controller;

            int user_id = application_controller.get_user().id;

            cartesianChartStats.Series = createSeriesScores("Corect Answers History", user_id);

            labelTitle.Text += application_controller.get_user().username;

            String scoreline = ("\n\n\n Best Correct Answers : " + getBestCorrectAns(user_id) +
                "\n Worst Incorrect Answers : " + getWorstIncorrectAns(user_id) +
                "\n Best Time remaining : " + getBestTimeRemained(user_id));

            labelBestStats.Text = scoreline;

        }

        private static int[] getCorrectAnswers(int user_id)
        {
            List<int> mem_times = new List<int>();
            List<Quiz_Stats> stats = DataHandler.getQuizStats(user_id);
            foreach(Quiz_Stats stat in stats)
            {
                mem_times.Add((int)stat.corect_answers);
            }
            return mem_times.ToArray();
        }

        private static int getBestCorrectAns(int user_id)
        {
            List<Quiz_Stats> stats = DataHandler.getQuizStats(user_id);
            return (int)stats.Max(obj => obj.corect_answers);
        }

        private static int getWorstIncorrectAns(int user_id)
        {
            List<Quiz_Stats> stats = DataHandler.getQuizStats(user_id);
            return (int)stats.Max(obj => obj.incorect_answers);
        }

        private static double getBestTimeRemained(int user_id)
        {
            List<Quiz_Stats> stats = DataHandler.getQuizStats(user_id);
            string time = stats.Max(obj => obj.time_remaining);
            double timeDouble = double.Parse(time.Split(':')[0]) + double.Parse(time.Split(':')[1]);
            return timeDouble;
        }


        private SeriesCollection createSeriesScores(string title,int user_id)
        {
            return new SeriesCollection
            {
                new LineSeries
            {
            Title = title,
            Values = new ChartValues<int>(new ChartValues<int>(getCorrectAnswers(user_id))),
             }
            };
        }

        private void StatsWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            application_controller.open_window("Main");
        }

    }
}
