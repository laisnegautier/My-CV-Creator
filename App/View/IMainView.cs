using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using App;
using System.Windows.Forms;

namespace App.View
{
    public interface IMainView
    {
        List<ResumeMiniaturePic> Resumes { set; }
        Presenter.MainPresenter Presenter { set; }
        DialogResult ConfirmDelete(string title);
        void Close();
    }
}
