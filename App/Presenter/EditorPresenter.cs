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
        private object _currentElementSelected;
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
        #region MainRenderers
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
                        if (_currentResume.Containers.IndexOf(c) == _currentResume.Containers.Count - 1) cd.DownButton.Hide();
                        _view.ResumeEditor.Controls.Add(cd);

                        RenderContainer(cd);

                        int _containerHeight = 0;
                        if (c.Elements != null)
                            foreach(IElement e in c.Elements)
                            {
                                int size = RenderElement(e, c, cd);
                                _containerHeight += size;
                            }
                        cd.Height += _containerHeight;
                        _view.ResumeEditor.Refresh();
                    }
        }

        public void RenderContainer(ContainerDrop cd)
        {
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

            cd.ElementPanel.DragDrop += DealDragDrop;
        }

        public int RenderElement(IElement e, Container c, ContainerDrop cd)
        {
            if(e is Paragraph)
            {
                Paragraph p = (Paragraph)e;
                TextDrop td = new TextDrop(p);
                return RenderParagraph(td, cd);
            }
            else if(e is H1)
            {
                H1 h1 = (H1)e;
                TextDrop td = new TextDrop(h1);
                return RenderTitle(td, cd);
            }
            else if (e is H2)
            {
                H2 h2 = (H2)e;
                TextDrop td = new TextDrop(h2);
                return RenderTitle(td, cd);
            }
            // Cpt
            // Cpt spécifique pour chaque type d'element possible du CV

            return 0;
        }
        #endregion

        #region ElementsRenderers
        public int RenderParagraph(TextDrop td, ContainerDrop cd)
        {
            cd.ElementPanel.Controls.Add(td);
            td.Left = cd.ElementPanel.Left;
            // Centrer le composant
            td.Width = cd.ElementPanel.Width - (td.Margin.Left + td.Margin.Right);
            td.EditableText.Width = td.Width - td.ControlPanel.Width - (td.EditableText.Margin.Left + td.EditableText.Margin.Right);
            td.EditableText.Top = 0;

            td.ParentContainer = cd;

            td.Click += SetCurrentSelectedElement;
            td.EditableText.Click += SetCurrentSelectedElement;
            return td.Height;
        }

        public int RenderTitle(TextDrop td, ContainerDrop cd)
        {
            cd.ElementPanel.Controls.Add(td);
            td.Left = cd.ElementPanel.Left + 10;
            td.Width = cd.ElementPanel.Width - (td.Margin.Left + td.Margin.Right);
            td.EditableText.Width = td.Width - td.ControlPanel.Width - (td.EditableText.Margin.Left + td.EditableText.Margin.Right);
            td.Height = 100;
            td.EditableText.Top = 0;
            td.ParentContainer = cd;

            td.Click += SetCurrentSelectedElement;
            td.EditableText.Click += SetCurrentSelectedElement;
            return td.Height;
        }
        #endregion

        #region Element Managers
        public void SetCurrentSelectedElement(object sender, EventArgs e)
        {
            UnsetLastSelectedElement();
            if(sender is TextDrop)
            {
                TextDrop pd = (TextDrop)sender;
                pd.IsSelected = true;
                pd.Refresh();
                SetCurrentSelectedContainer(pd.ParentContainer, e);
            }

            _currentElementSelected = sender;
        }

        public void UnsetLastSelectedElement()
        {
            if(_currentElementSelected != null)
            {
                if (_currentElementSelected is TextDrop) ((TextDrop)_currentElementSelected).IsSelected = false;
            }
        }
        #endregion

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

        // Fonction à ré-écrire
        public void SetCurrentSelectedContainer(object sender, EventArgs e)
        {
            // Si on click su la déjà selctionée on fait rien
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
                    // Ajouter le rafrais=chissement de l'ancienne section dans le setter
                    ContainerDrop lastSelection = CurrentSelection;
                    CurrentSelection = (ContainerDrop)active.Parent;

                    if (lastSelection != null) lastSelection.Refresh();
                    CurrentSelection.Refresh();
                }
                catch (InvalidCastException ){
                    if(sender is Label)
                    {
                        sender = ((Label)sender).Parent;
                        if (sender is TextDrop)
                        {
                            TextDrop pd = (TextDrop)sender;
                            ContainerDrop lastSelection = CurrentSelection;
                            CurrentSelection = (ContainerDrop)pd.Parent.Parent;

                            if (lastSelection != null) lastSelection.Refresh();
                            CurrentSelection.Refresh();
                        }
                    }
                }
            }
            // Si le selceted ne contiens pas l'element on desactive l'element
            //if () UnsetLastSelectedElement();
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
        
        // Fonciton à segmenter
        public void SetUpView()
        {
            List<Container> basicContainers = new List<Container>();
            List<IElement> basicElements = new List<IElement>();
            Container empty = new Container() { Name = "Empty" };
            IElement paragraph = new Paragraph();
            IElement title1 = new H1();
            IElement title2 = new H2();

            basicContainers.Add(empty);
            basicElements.Add(paragraph);
            basicElements.Add(title1);
            basicElements.Add(title2);

            List<string> elemNames = new List<string>() { "Paragraph", "Title 1", "Title 2" };
            List<string> elemDesc = new List<string>() { " Content a text paragraph ", " Big size title ", " Smaller title " };

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
            for (int i = 0; i < basicElements.Count; i++)
            {
                ElementDragItem DraggableElem = new ElementDragItem(basicElements[i], elemNames[i], elemDesc[i]);
                _view.DefaultElementPanel.Controls.Add(DraggableElem);
                DraggableElem.Width = _view.DefaultElementPanel.Width - 20;
                DraggableElem.Left = _view.DefaultSectionPanel.Left + 10;
            }
        }

        // Fonction à ré-écrire
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
                try
                {
                    IElement _element = (IElement)e.Data.GetData(e.Data.GetFormats()[0]);
                    _element = _element.Copy();
                    DealDragDropElement(_element, (ContainerDrop)((FlowLayoutPanel)sender).Parent );
                }
                catch( Exception exception) { }
            }
        }

        // Fonction à segmenter
        public void DealDragDropElement(IElement element ,ContainerDrop targetContainer)
        {
            _currentSelection = targetContainer;
            // Gestion de l'ajout d'un nouveau paragraph à un CV
            if(element is Paragraph)
            {
                Paragraph active = (Paragraph)element;
                active.Content = "Lorem ipsum dolor sit amet, cons ectetur adipiscing elit.Sed non risus." +
                                  "Suspendisse lectus tortor, dignissim sit amet, adipiscing nec, ultricies" +
                                  "sed, dolor.Cras elementum ultrices diam. Maecenas ligula massa, varius a," +
                                  "semper congue, euismod non, mi. Proin porttitor, orci nec nonummy molestie," +
                                  "enim est eleifend mi, non fermentum diam nisl sit amet erat. Duis semper.";
                //ParagraphDrop pd = new ParagraphDrop((Paragraph)element);
                //if (pd.Content.Content == "" || pd.Content.Content == null) pd.TextValue = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed non risus. Suspendisse lectus tortor, dignissim sit amet, adipiscing nec, ultricies sed, dolor. Cras elementum ultrices diam. Maecenas ligula massa, varius a, semper congue, euismod non, mi. Proin porttitor, orci nec nonummy molestie, enim est eleifend mi, non fermentum diam nisl sit amet erat. Duis semper. Duis arcu massa, scelerisque vitae, consequat in, pretium a, enim. Pellentesque congue. Ut in risus volutpat libero pharetra tempor. Cras vestibulum bibendum augue. Praesent egestas leo in pede. Praesent blandit odio eu enim. Pellentesque sed dui ut augue blandit sodales. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aliquam nibh. Mauris ac mauris sed pede pellentesque fermentum. Maecenas adipiscing ante non diam sodales hendrerit.";
                // Ajout graphique
                //targetContainer.ElementPanel.Controls.Add(pd);
                //pd.Width = ((ContainerDrop)pd.Parent).ElementPanel.Width;
                // Ajout dans le CV
                targetContainer.Content.Elements.Add(element);
                RenderResume();
            }
            if(element is H1)
            {
                H1 active = (H1)element;
                active.Content = "- Titre 1 -";
                targetContainer.Content.Elements.Add(element);
                RenderResume();
            }
            if(element is H2)
            {
                H2 active = (H2)element;
                active.Content = "- Titre 2 -";
                targetContainer.Content.Elements.Add(element);
                RenderResume();
            }
        }
    }
}
