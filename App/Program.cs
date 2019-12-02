using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Setting up the Presenter and its dependencies
            IResumeRepository resumeRepo = (IResumeRepository)new StubRepository.ResumeRepository();

            Application.Run(new MainView());
        }
    }
}
