using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace App.Presenter
{
    class EditorPresenter
    {
        private IResumeRepository _resumeRepo;
        private EditorView _view;

        public EditorPresenter(IResumeRepository resumeRepo, EditorView editForm)
        {
            _resumeRepo = resumeRepo;
            _view = editForm;
        }
    }
}
