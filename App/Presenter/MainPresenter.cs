using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using App.View;
using DAL;
using System.Drawing;

namespace App.Presenter
{
    public class MainPresenter
    {
        private IResumeRepository _resumeRepository;
        private IMainView _view;
        private List<Resume> Resumes { get; set; }
        private List<ResumeMiniaturePic> ResumesView {get;set;}
        private ResumeMiniaturePic currentResume { get; set; }

        public MainPresenter(IResumeRepository resumeRepository, IMainView view)
        {
            _resumeRepository = resumeRepository;
            _view = view;
            _view.Presenter = this;
            Resumes = _resumeRepository.GetAll();

            ResumesView = new List<ResumeMiniaturePic>();
            foreach (Resume resume in Resumes)
            {
                ResumesView.Add(new ResumeMiniaturePic(resume));
            }
            _view.Resumes = ResumesView;
        }

        public void SetCurrentResume(object sender, EventArgs eventArgs)
        {
            if(currentResume != null) currentResume.BackColor = Color.FromArgb(38,38,38);
            currentResume = (ResumeMiniaturePic)sender;
            currentResume.BackColor = Color.FromArgb(58, 58, 58);
        }

        public void Edit()
        {

        }

        public void AddNew()
        {

        }

        public void Delete()
        {

        }

        public void Copy()
        {

        }
    }
}

