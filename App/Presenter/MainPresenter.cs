﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using App.View;
using DAL;
using System.Drawing;
using System.Windows.Forms;
using App.Widgets;

namespace App.Presenter
{
    public class MainPresenter
    {
        private IResumeRepository _resumeRepository;
        private IMainView _view;
        private List<Resume> Resumes { get; set; }
        private List<ResumeMiniaturePic> ResumesView { get; set; }
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
            if (currentResume != null)
            {
                currentResume.isSelected = false;
                currentResume.BackColor = Color.FromArgb(38, 38, 38);
            }
            currentResume = (ResumeMiniaturePic)sender;
            currentResume.isSelected = true;
            currentResume.BackColor = Color.FromArgb(58, 58, 58);
        }

        public void Edit()
        {
            if (currentResume != null)
            {
                EditorView editForm = new EditorView();
                IResumeRepository resumeRepo = new StubRepository.ResumeRepository();
                editForm.CurrentResume = currentResume.Resume;
                EditorPresenter editorPresenter = new EditorPresenter(resumeRepo, editForm);
                editForm.Show();
                editorPresenter.RenderResume();
                _view.Close();
            }
        }

        public void AddNew()
        {
            EditorView editForm = new EditorView();
            IResumeRepository resumeRepo = _resumeRepository;
            editForm.CurrentResume = new Resume();

            SmallTextEditor titleEditor = new SmallTextEditor();
            titleEditor.Disposed += (s, e) =>
            {
                editForm.CurrentResume = new Resume(titleEditor.TextValue);
            };

            titleEditor.Show("Title", "Give your new Resume a title !");

            EditorPresenter editorPresenter = new EditorPresenter(resumeRepo, editForm);
            editForm.Show();
            _view.Close();
        }

        public void Delete()
        {
            if(currentResume != null)
            {
                DialogResult result = _view.ConfirmDelete(currentResume.Resume.Title);
                if (result == DialogResult.OK || result == DialogResult.Yes)
                {
                    _resumeRepository.Delete(currentResume.Resume);
                    ResumesView.Remove(currentResume);
                    currentResume = null;
                    _view.Resumes = ResumesView;
                }
            }
                
        }

        public void Copy()
        {
            if(currentResume != null)
            {
                DialogResult result = _view.ConfirmCopy(currentResume.Resume.Title);
                if(result == DialogResult.OK || result == DialogResult.Yes)
                {
                    Resume resume = _resumeRepository.Copy(currentResume.Resume);
                    ResumesView.Add( new ResumeMiniaturePic(resume));
                    _view.Resumes = ResumesView;
                }
            }

        }
    }
}

