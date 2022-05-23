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
    public partial class Stroop_Stats_Window : Form
    {
        Application_Controller application_controller;

        public Stroop_Stats_Window(Application_Controller application_controller)
        {
            InitializeComponent();
            this.application_controller = application_controller;

            int user_id = application_controller.get_user().id;

            cartesianChartStats.Series = createSeriesScores("Scores History", user_id);

            labelTitle.Text += application_controller.get_user().username;

            String scoreline = ("\n\n\n Best Score : " + getBestScore(user_id) +
                "\n Best Time : " + getBestTime(user_id) +
                "\n Best Score Consecutive Strikes : " + getBestConsecutiveStrikes(user_id) +
                "\n Best Score Clicked Under Bar : " + getBestClickedUnderBar(user_id));

            labelBestStats.Text = scoreline;

        }

        private static int[] getScores(int user_id)
        {
            List<int> scores = new List<int>();
            List<Stroop_Stats> stroop_Stats = DataHandler.getStroopStats(user_id);
            foreach(Stroop_Stats stat in stroop_Stats)
            {
                scores.Add((int)stat.score);
            }
            return scores.ToArray();
        }

        private static int getBestScore(int user_id)
        {
            List<Stroop_Stats> stroop_Stats = DataHandler.getStroopStats(user_id);
            if (stroop_Stats.Count > 0)
                return (int)stroop_Stats.Max(obj => obj.score);
            else
                return -1;
        }

        private static double getBestTime(int user_id)
        {
            List<Stroop_Stats> stroop_Stats = DataHandler.getStroopStats(user_id);
            if (stroop_Stats.Count > 0)
                return (double)stroop_Stats.Max(obj => obj.total_time);
            else
                return -1;
        }

        private static int getBestConsecutiveStrikes(int user_id)
        {
            List<Stroop_Stats> stroop_Stats = DataHandler.getStroopStats(user_id);
            if (stroop_Stats.Count > 0)
                return (int)stroop_Stats.Max(obj => obj.consecutive_strikes);
            else
                return -1;
        }

        private static int getBestClickedUnderBar(int user_id)
        {
            List<Stroop_Stats> stroop_Stats = DataHandler.getStroopStats(user_id);
            if (stroop_Stats.Count > 0)
                return (int)stroop_Stats.Max(obj => obj.clicked_under_bar);
            else
                return -1;
        }

        private SeriesCollection createSeriesScores(string title,int user_id)
        {
            return new SeriesCollection
            {
                new LineSeries
            {
            Title = title,
            Values = new ChartValues<int>(new ChartValues<int>(getScores(application_controller.get_user().id))),
             }
            };
        }

        private void StatsWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            application_controller.open_window("Main");
        }

    }
}
