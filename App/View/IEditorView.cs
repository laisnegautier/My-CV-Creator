using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace App.View
{
    interface IEditorView
    {
        Resume CurrentResume { get; set; }
        Presenter.EditorPresenter Presenter { set; }
        FlowLayoutPanel ResumeEditor { get; }
        FlowLayoutPanel DefaultSectionPanel { get; }
        FlowLayoutPanel ElementPanel { get; }
    }
}
