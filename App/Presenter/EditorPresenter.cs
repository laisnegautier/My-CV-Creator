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
        #region Attributes
        private IResumeRepository _resumeRepo;
        private EditorView _view;
        private ContainerDrop _currentSelection;
        private Resume _currentResume;
        #endregion

        private ContainerDrop CurrentSelection
        {
            get { return _currentSelection; }
            set {
                if(_currentSelection != null) _currentSelection.IsSelected = false;
                _currentSelection = value;
                _currentSelection.IsSelected = true;
            }
        }
        

        public EditorPresenter(IResumeRepository resumeRepo, EditorView editForm)
        {
            _resumeRepo = resumeRepo;
            _view = editForm;
            _view.Presenter = this;
            _currentResume = _view.CurrentResume;
        }

        // A segmenter en rendu des containers et des elements
        public void RenderResume()
        {
            _view.ResumeEditor.Controls.Clear();
            if (_currentResume != null)
                if (_currentResume.Containers != null)
                    foreach (Container c in _currentResume.Containers)
                    {
                        ContainerDrop cd = new ContainerDrop(c);
                        if (_currentSelection != null && c == _currentSelection.Content)
                        {
                            cd.IsSelected = true;
                            _currentSelection = cd;
                        }
                        if (_currentResume.Containers.IndexOf(c) == 0) cd.UpButton.Hide();
                        else if (_currentResume.Containers.IndexOf(c) == _currentResume.Containers.Count - 1) cd.DownButton.Hide();
                        _view.ResumeEditor.Controls.Add(cd);
                        cd.Width = _view.ResumeEditor.Width - 10;
                        // Action de selection autorisée
                        cd.Click += SetCurrentSelectedContainer;
                        cd.ElementPanel.Click += SetCurrentSelectedContainer;
                        cd.ContainerTitleLabel.DoubleClick += EditContainerTitle;
                        
                        // Gestion des boutons
                        cd.FavButton.Click += SetContainerFav;
                        cd.UpButton.Click += MoveContainerUp;
                        cd.DownButton.Click += MoveContainerDown;
                        cd.DeleteButton.Click += DeleteContainer;
                        cd.CopyButton.Click += CopyContainer;
                        //cd.UpButton.C

                        if (c.Elements != null)
                            foreach(IElement e in c.Elements)
                            {

                            }
                        _view.ResumeEditor.Refresh();
                    }
        }

        #region Container Managers
        public void EditContainerTitle(object sender, EventArgs e)
        {
            Label title = (Label)sender;
            if (title.Parent is ContainerDrop)
            {
                _currentSelection = (ContainerDrop)title.Parent;
                RenderResume();
            }
            SmallTextEditor editor = new SmallTextEditor();
            editor.Disposed += (s, evt) =>
            {
                _currentSelection.ContainerTitleLabel.Text = editor.TextValue;
                _currentSelection.Content.Name = editor.TextValue;
                //_currentSelection.ContainerTitleLabel.Refresh();
            };
            editor.Show("Editer le text de votre Titre", title.Text);
        }

        public void SetContainerFav(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            ContainerDrop containerDrop = (ContainerDrop)button.Parent.Parent;
            Container container = containerDrop.Content;

            container.Favorite = !container.Favorite;
            containerDrop.Refresh();
        }

        public void MoveContainerUp(object sender, EventArgs e)
        {
            bool moved = false;
            ContainerDrop containerDrop = (ContainerDrop)((Button)sender).Parent.Parent;
            Container container = containerDrop.Content;

            int pos = _currentResume.Containers.IndexOf(container);
            if(pos != 0)
            {
                _currentResume.Containers.RemoveAt(pos);
                _currentResume.Containers.Insert(pos-1, container);
                moved = true;
            }
            if(moved) RenderResume();
        }

        public void MoveContainerDown(object sender, EventArgs e)
        {
            bool moved = false;
            ContainerDrop containerDrop = (ContainerDrop)((Button)sender).Parent.Parent;
            Container container = containerDrop.Content;

            int pos = _currentResume.Containers.IndexOf(container);
            if (pos != _currentResume.Containers.Count - 1)
            {
                _currentResume.Containers.RemoveAt(pos);
                _currentResume.Containers.Insert(pos + 1, container);
                moved = true;
            }
            if(moved) RenderResume();
        }

        public void SetCurrentSelectedContainer(object sender, EventArgs e)
        {
            try{
                ContainerDrop active = (ContainerDrop) sender;
                ContainerDrop lastSelection = CurrentSelection;
                CurrentSelection = active;
                //CurrentSelection.ElementPanel.Refresh();
                if(lastSelection != null) lastSelection.Refresh();
                CurrentSelection.Refresh();
            }
            catch ( InvalidCastException ){
                try
                {
                    FlowLayoutPanel active = (FlowLayoutPanel)sender;
                    ContainerDrop lastSelection = CurrentSelection;
                    CurrentSelection = (ContainerDrop)active.Parent;

                    if (lastSelection != null) lastSelection.Refresh();
                    CurrentSelection.Refresh();
                }
                catch { }
            }
            // RenderResume();
        }

        public void DeleteContainer(object sender, EventArgs e)
        {
            Container c = ((ContainerDrop)((Button)sender).Parent.Parent).Content;
            if(_view.ConfirmDeleteContainer(c.Name) == DialogResult.Yes)
            {
                _currentResume.Containers.Remove(c);
                RenderResume();
            }
        }

        public void CopyContainer(object sender, EventArgs e)
        {
            Container c = ((ContainerDrop)((Button)sender).Parent.Parent).Content;
            if (_view.ConfirmCopyContainer(c.Name) == DialogResult.Yes)
            {
                _currentResume.Containers.Add(c.Copy());
                RenderResume();
            }
        }
        #endregion


        public void SetUpView()
        {
            List<Container> basicContainers = new List<Container>();
            Container empty = new Container() { Name = "Empty" };
            basicContainers.Add(empty);

            // Adding the defaults containers
            foreach(Container c in basicContainers)
            {
                ContainerDragItem DraggablePic = new ContainerDragItem(c);
                _view.DefaultSectionPanel.Controls.Add(DraggablePic);
                DraggablePic.Width = _view.DefaultSectionPanel.Width - 20;
                DraggablePic.Left = _view.DefaultSectionPanel.Left + 10;
            }
            // Adding the favorites containers

            // Adding the defaults elements
        }

        public void DealDragDrop(object sender, DragEventArgs e)
        {
            try
            {
                Container _container = (Container)e.Data.GetData(e.Data.GetFormats()[0]);
                ContainerDrop c = new ContainerDrop(_container.Copy());
                _currentResume.Containers.Add(_container.Copy());
                RenderResume();
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
    }
}
