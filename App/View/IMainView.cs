using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using App;

namespace App.View
{
    public interface IMainView
    {
        List<ResumeMiniaturePic> Resumes { get; set; }
        Resume CurrentResume { get; set; }
        Presenter.MainPresenter Presenter { set; }
    }
}
