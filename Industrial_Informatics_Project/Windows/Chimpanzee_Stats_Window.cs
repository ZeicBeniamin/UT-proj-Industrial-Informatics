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
    public partial class Chimpanzee_Stats_Window : Form
    {
        Application_Controller application_controller;

        public Chimpanzee_Stats_Window(Application_Controller application_controller)
        {
            InitializeComponent();
            this.application_controller = application_controller;

            int user_id = application_controller.get_user().id;

            cartesianChartStats.Series = createSeriesScores("Avg Memory History", user_id);

            labelTitle.Text += application_controller.get_user().username;

            String scoreline = ("\n\n\n Best Game Time : " + getBestGameTime(user_id) +
                "\n Best Avg Memory Time : " + getBestAvgMemory(user_id) +
                "\n Best Avg Solve Time : " + getBestAvgSolve(user_id));

            labelBestStats.Text = scoreline;

        }

        private static double[] getMemoryTimes(int user_id)
        {
            List<double> mem_times = new List<double>();
            List<Chimpanzee_Stats> chimp_Stats = DataHandler.getChimpanzeeStats(user_id);
            foreach(Chimpanzee_Stats stat in chimp_Stats)
            {
                mem_times.Add((double)stat.avg_memory_time);
            }
            return mem_times.ToArray();
        }

        private static double getBestGameTime(int user_id)
        {
            List<Chimpanzee_Stats> stats = DataHandler.getChimpanzeeStats(user_id);
            if (stats.Count > 0)
                return (double)stats.Max(obj => obj.game_time);
            else
                return -1;
        }

        private static double getBestAvgMemory(int user_id)
        {
            List<Chimpanzee_Stats> stats = DataHandler.getChimpanzeeStats(user_id);
            if (stats.Count > 0)
                return (double)stats.Max(obj => obj.avg_memory_time);
            else
                return -1;
        }

        private static double getBestAvgSolve(int user_id)
        {
            List<Chimpanzee_Stats> stats = DataHandler.getChimpanzeeStats(user_id);
            if (stats.Count > 0)
                return (double)stats.Max(obj => obj.avg_solve_time);
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
            Values = new ChartValues<double>(new ChartValues<double>(getMemoryTimes(user_id))),
             }
            };
        }

        private void StatsWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            application_controller.open_window("Main");
        }

    }
}
