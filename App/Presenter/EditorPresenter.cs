using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Widgets;
using DAL;
using Domain;

namespace App.Presenter
{
    public class EditorPresenter
    {
        private IResumeRepository _resumeRepo;
        private EditorView _view;
        private ContainerDrop _currentSelection { get; set; }
        private Resume _currentResume;

        public EditorPresenter(IResumeRepository resumeRepo, EditorView editForm)
        {
            _resumeRepo = resumeRepo;
            _view = editForm;
            _view.Presenter = this;
            _currentResume = _view.CurrentResume;
        }

        public void RenderResume()
        {
            _view.ResumeEditor.Controls.Clear();
            if(_currentResume != null)
                if(_currentResume.Containers != null)
                    foreach (Container c in _currentResume.Containers)
                    {
                        ContainerDrop cd = new ContainerDrop(c);
                        _view.ResumeEditor.Controls.Add(cd);
                        cd.Width = _view.ResumeEditor.Width - 10;
                        cd.Click += SetCurrentSelectedContainer;
                        cd.ElementPanel.Click += SetCurrentSelectedContainer;
                        if(c.Elements != null)
                            foreach(IElement e in c.Elements)
                            {

                            }
                        _view.ResumeEditor.Refresh();
                    }
        }

        public void SetCurrentSelectedContainer(object sender, EventArgs e)
        {
            try{

            }
            catch{

            }
            // RenderResume();
        }
        
        public void SetUpView()
        {
            List<Container> basicContainers = new List<Container>();
            Container empty = new Container() { Name = "Empty" };
            basicContainers.Add(empty);

            foreach(Container c in basicContainers)
            {
                ContainerDragItem DraggablePic = new ContainerDragItem(c);
                _view.DefaultSectionPanel.Controls.Add(DraggablePic);
                DraggablePic.Width = _view.DefaultSectionPanel.Width - 20;
                DraggablePic.Left = _view.DefaultSectionPanel.Left + 10;
            }
        }

        public void DealDragDrop(object sender, DragEventArgs e)
        {
            try
            {
                Container _container = (Container)e.Data.GetData(e.Data.GetFormats()[0]);
                ContainerDrop c = new ContainerDrop(_container);
                _currentResume.Containers.Add(_container);
                RenderResume();
            }
            catch (Exception exp) { }
        }
    }
}
