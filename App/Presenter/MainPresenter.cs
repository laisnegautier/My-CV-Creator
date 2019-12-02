using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using App.View;
using DAL;

namespace App.Presenter
{
    public class MainPresenter
    {
        private IResumeRepository _resumeRepository;
        private IMainView _view;

        public MainPresenter(IResumeRepository resumeRepository, IMainView view)
        {
            _resumeRepository = resumeRepository;
            _view = view;
            _view.Presenter = this;
            _view.Resumes = _resumeRepository.GetAll();
        }


    }
}

