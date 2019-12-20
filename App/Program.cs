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
            IResumeRepository resumeRepo = new ResumeRepository();
            MainView mainForm = new MainView();
            Presenter.MainPresenter mainPresenter = new Presenter.MainPresenter(resumeRepo, mainForm);
            mainForm.Show();
            //EditorView editView = new EditorView();
            //Application.Run(mainForm);
            Application.Run();
        }
    }
}
