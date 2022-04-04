using Industrial_Informatics_Project.Scripts.Games;
using Industrial_Informatics_Project.Scripts.Games.StroopTestScript;
using Industrial_Informatics_Project.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Industrial_Informatics_Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Dummy_Window dummy_Window = new Dummy_Window();

            Application.Run();
        }
    }
}
