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
        enum Editable { ContTitle, H1, H2 };

        #region Attributes
        private IResumeRepository _resumeRepo;
        private EditorView _view;
        private Resume _currentResume;
        public bool save = true;
        private object _currentElementSelected;
        #endregion

        #region Properties
        private object CurrentSelection
        {
            get { return _currentElementSelected; }
            set {
                if (_currentElementSelected != null)
                {
                    if(_currentElementSelected is ContainerDrop)
                    {
                        ContainerDrop item = (ContainerDrop)_currentElementSelected;
                        item.IsSelected = false;
                        item.Refresh();
                    }
                    if(_currentElementSelected is TextDrop)
                    {
                        TextDrop item = (TextDrop)_currentElementSelected;
                        item.IsSelected = false;
                        item.Refresh();
                    }
                }
                if (value is ContainerDrop) ((ContainerDrop)value).IsSelected = true;
                else if (value is ContainerDrop) ((ContainerDrop)value).IsSelected = true;
                _currentElementSelected = value;
                ((Control)_currentElementSelected).Refresh();
            }
        }
        #endregion

        #region Construct and Init
        public EditorPresenter(IResumeRepository resumeRepo, EditorView editForm)
        {
            _resumeRepo = resumeRepo;
            _view = editForm;
            _view.Presenter = this;
            _currentResume = _view.CurrentResume;
        }

        // Fonciton à segmenter
        public void SetUpView()
        {
            _view.ResumeTitleLabel.Text = _currentResume.Title;

            List<Container> basicContainers = DefaultContainers();
            List<IElement> basicElements = DefaultElements();
            

            List<string> elemNames = new List<string>() { "Paragraph", "Title 1", "Title 2", "Date" };
            List<string> elemDesc = new List<string>() { " Content a text paragraph ", " Big size title ", " Smaller title ", "renseigne une date" };

            List<string> containerDesc = new List<string>() { "An empty section to customize", "A template to carrer element", "A template to deal with your identity" };

            // Adding the defaults containers
            foreach (Container c in basicContainers)
            {
                ContainerDragItem DraggablePic = new ContainerDragItem(c);
                DraggablePic.Description.Text = containerDesc[basicContainers.IndexOf(c)];
                _view.DefaultSectionPanel.Controls.Add(DraggablePic);
                DraggablePic.Width = _view.DefaultSectionPanel.Width - 20;
                DraggablePic.Left = _view.DefaultSectionPanel.Left + 10;
            }
            // Adding the defaults elements
            for (int i = 0; i < basicElements.Count; i++)
            {
                ElementDragItem DraggableElem = new ElementDragItem(basicElements[i], elemNames[i], elemDesc[i]);
                _view.DefaultElementPanel.Controls.Add(DraggableElem);
                DraggableElem.Width = _view.DefaultElementPanel.Width - 20;
                DraggableElem.Left = _view.DefaultSectionPanel.Left + 10;
            }
            // Adding the favorites containers


        }

        public List<Container> DefaultContainers()
        {
            List<Container> defaultContainers = new List<Container>();

            Container empty = new Container() { Name = "Empty" };
            Container carreer = new Container() { Name = "Carreer" };
            Container identity = new Container() { Name = "Identity" };

            // Element de carrière
            IElement carreerDesc = new H2("My school", carreer);
            IElement carrerrDate = new Date(DateTime.Now, carreer);
            IElement carrerrParagraph = new Paragraph("What where you doing ?", carreer);
            carreer.Elements.Add(carreerDesc);
            carreer.Elements.Add(carrerrDate);
            carreer.Elements.Add(carrerrParagraph);

            //Element d'indentité
            IElement identityFirst = new H1("Name Firstname", identity);
            IElement idetityPhone = new Paragraph("06-29-39-63-47", identity);
            IElement identityMail = new Paragraph("NameFirstName@inbox.com", identity);
            identity.Elements.Add(identityFirst);
            identity.Elements.Add(idetityPhone);
            identity.Elements.Add(identityMail);

            defaultContainers.Add(empty);
            defaultContainers.Add(carreer);
            defaultContainers.Add(identity);
            
            return defaultContainers;
        }

        public List<IElement> DefaultElements()
        {
            List<IElement> defaultElement = new List<IElement>();

            IElement paragraph = new Paragraph();
            IElement title1 = new H1();
            IElement title2 = new H2();
            IElement date = new Date();

            defaultElement.Add(paragraph);
            defaultElement.Add(title1);
            defaultElement.Add(title2);
            defaultElement.Add(date);

            return defaultElement;
        }
        #endregion

        // A segmenter en rendu des containers et des elements
        #region MainRenderers
        public void RenderResume()
        {
            _view.ResumeEditor.Controls.Clear();
            if (_currentResume != null)
                if (_currentResume.Containers != null)
                    foreach (Container c in _currentResume.Containers)
                    {
                        //=====================================================================================================
                        ContainerDrop cd = new ContainerDrop(c);
                        // Si la section est selectionnée on la laisse seléctionnée
                        if (CurrentSelection != null && CurrentSelection is ContainerDrop)
                            if(((ContainerDrop)CurrentSelection).Content == c)
                            {
                                cd.IsSelected = true;
                                CurrentSelection = cd;
                            }
                        // Gestion pour la première section
                        if (_currentResume.Containers.IndexOf(c) == 0) cd.UpButton.Hide();
                        // Gestion pour la dernière section
                        if (_currentResume.Containers.IndexOf(c) == _currentResume.Containers.Count - 1) cd.DownButton.Hide();
                        _view.ResumeEditor.Controls.Add(cd);
                        // A DEPORTER DANS RENDER CONTAINER
                        //=====================================================================================================

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
            cd.Click += (s,e) => { /*cd.IsSelected = !cd.IsSelected;*/ CurrentSelection = cd; };
            cd.ElementPanel.Click += (s,e) => { /*cd.IsSelected = !cd.IsSelected;*/ CurrentSelection = cd; };
            cd.ContainerTitleLabel.DoubleClick += EditShortText;

            // Gestion des boutons
            cd.FavButton.Click += SetContainerFav;
            cd.UpButton.Click += MoveContainerUp;
            cd.DownButton.Click += MoveContainerDown;
            cd.DeleteButton.Click += DeleteContainer;
            cd.CopyButton.Click += CopyContainer;
            cd.SwitchButton.Click += SwitchContainerStatus;

            cd.ElementPanel.DragDrop += DealDragDrop;
        }

        public int RenderElement(IElement e, Container c, ContainerDrop cd)
        {
            TextDrop td = null;
            int height = 0;
            if (e is Paragraph)
            {
                Paragraph p = (Paragraph)e;
                td = new TextDrop(p);
                td.EditableText.DoubleClick += EditLongText;
                height = RenderParagraph(td, cd);
            }
            else if (e is H1)
            {
                H1 h1 = (H1)e;
                td = new TextDrop(h1);
                td.EditableText.DoubleClick += EditShortText;
                height = RenderTitle(td, cd);
            }
            else if (e is H2)
            {
                H2 h2 = (H2)e;
                td = new TextDrop(h2);
                td.EditableText.DoubleClick += EditShortText;
                height = RenderTitle(td, cd);
            }
            else if(e is Date)
            {
                Date d = (Date)e;
                td = new TextDrop(d);
                td.EditableText.DoubleClick += EditDate;
                height = RenderDate(td, cd);
            }
            // Cpt
            // Cpt spécifique pour chaque type d'element possible du CV
            if (td != null)
            {
                td.Click += (s, evt) =>
                {
                    td.IsSelected = !td.IsSelected;
                    //td.Refresh();
                    CurrentSelection = td;
                };
                td.EditableText.Click += (s, evt) =>
                {
                    td.IsSelected = !td.IsSelected;
                    //td.Refresh();
                    CurrentSelection = td;
                };
                // Gestion des boutons
                td.UpButton.Click += MoveElementUp;
                td.DownButton.Click += MoveElementDown;
                td.DeleteButton.Click += DeleteElement;
                td.SwitchButton.Click += SwitchElementStatus;
            }
            return height;
        }
        #endregion

        #region ElementsRenderers
        int RenderParagraph(TextDrop td, ContainerDrop cd)
        {
            cd.ElementPanel.Controls.Add(td);
            td.Left = cd.ElementPanel.Left;
            // Centrer le composant
            td.Width = cd.ElementPanel.Width - (td.Margin.Left + td.Margin.Right);
            td.EditableText.Width = td.Width - td.ControlPanel.Width - (td.EditableText.Margin.Left + td.EditableText.Margin.Right);
            td.EditableText.Top = 0;

            td.ParentContainer = cd;
            
            return td.Height;
        }

        int RenderTitle(TextDrop td, ContainerDrop cd)
        {
            cd.ElementPanel.Controls.Add(td);
            td.Left = cd.ElementPanel.Left + 10;
            td.Width = cd.ElementPanel.Width - (td.Margin.Left + td.Margin.Right);
            td.EditableText.Width = td.Width - td.ControlPanel.Width - (td.EditableText.Margin.Left + td.EditableText.Margin.Right);
            td.Height = 100;
            td.EditableText.Top = 0;
            td.ParentContainer = cd;
            
            return td.Height;
        }

        int RenderDate(TextDrop td, ContainerDrop cd)
        {
            cd.ElementPanel.Controls.Add(td);
            td.Left = cd.ElementPanel.Left + 10;
            td.Width = cd.ElementPanel.Width - (td.Margin.Left + td.Margin.Right);
            td.EditableText.Width = td.Width - td.ControlPanel.Width - (td.EditableText.Margin.Left + td.EditableText.Margin.Right);
            td.Height = 100;
            td.EditableText.Top = 0;
            td.ParentContainer = cd;

            return td.Height;
        }
        #endregion

        #region Element Managers
        public void SwitchElementStatus(object sender, EventArgs e)
        {
            TextDrop td = (TextDrop)((Button)sender).Parent.Parent;
            td.Content.VisibilityParser = !td.Content.VisibilityParser;
            td.Refresh();
        }

        public void MoveElementUp(object sender, EventArgs e)
        {
            bool moved = false;
            TextDrop textDrop = (TextDrop)((Button)sender).Parent.Parent;
            IElement element = textDrop.Content;
            Container container = element.Container;
            // a simplifier
            int pos = _currentResume.Containers[_currentResume.Containers.IndexOf(container)].Elements.IndexOf(element);
            if (pos != 0)
            {
                _currentResume.Containers[_currentResume.Containers.IndexOf(container)].Elements.RemoveAt(pos);
                _currentResume.Containers[_currentResume.Containers.IndexOf(container)].Elements.Insert(pos - 1, element);
                moved = true;
            }
            if (moved) RenderResume();
        }

        public void MoveElementDown(object sender, EventArgs e)
        {
            bool moved = false;
            TextDrop textDrop = (TextDrop)((Button)sender).Parent.Parent;
            IElement element = textDrop.Content;
            Container container = element.Container;
            // a simplifier
            int pos = _currentResume.Containers[_currentResume.Containers.IndexOf(container)].Elements.IndexOf(element);
            if (pos != _currentResume.Containers[_currentResume.Containers.IndexOf(container)].Elements.Count-1)
            {
                _currentResume.Containers[_currentResume.Containers.IndexOf(container)].Elements.RemoveAt(pos);
                _currentResume.Containers[_currentResume.Containers.IndexOf(container)].Elements.Insert(pos + 1, element);
                moved = true;
            }
            if (moved) RenderResume();
        }

        public void DeleteElement(object sender, EventArgs e)
        {
            IElement textDrop = ((TextDrop)((Button)sender).Parent.Parent).Content;
            Container c = textDrop.Container;
            string name = "";
            if (textDrop is Paragraph) name = ((Paragraph)textDrop).Content;
            else if (textDrop is H1) name = ((H1)textDrop).Content;
            else if (textDrop is H2) name = ((H2)textDrop).Content;
            else if (textDrop is Date) name = ((Date)textDrop).ToString();
            if (_view.ConfirmDeleteElement(name) == DialogResult.Yes)
            {
                c.Elements.Remove(textDrop);
                RenderResume();
            }
        }
        #endregion

        #region Container Managers
       public void SwitchContainerStatus(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            ContainerDrop containerDrop = (ContainerDrop)button.Parent.Parent;
            Container container = containerDrop.Content;

            container.VisibilityParser = !container.VisibilityParser;
            containerDrop.Refresh();
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
        
        #region DragDrop
        // Fonction à ré-écrire
        public void DealDragDrop(object sender, DragEventArgs e)
        {
            try
            {
                Container _container = (Container)e.Data.GetData(e.Data.GetFormats()[0]);
                ContainerDrop c = new ContainerDrop(_container.Copy());
                _currentResume.Containers.Add(_container.Copy());
                _container.Resume = _currentResume;
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
            CurrentSelection = targetContainer;
            element.VisibilityParser = true;
            // Gestion de l'ajout d'un nouveau paragraph à un CV
            if(element is Paragraph)
            {
                Paragraph active = (Paragraph)element;
                active.Content = "Lorem ipsum dolor sit amet, cons ectetur adipiscing elit.Sed non risus." +
                                  "Suspendisse lectus tortor, dignissim sit amet, adipiscing nec, ultricies" +
                                  "sed, dolor.Cras elementum ultrices diam. Maecenas ligula massa, varius a," +
                                  "semper congue, euismod non, mi. Proin porttitor, orci nec nonummy molestie," +
                                  "enim est eleifend mi, non fermentum diam nisl sit amet erat. Duis semper.";
                targetContainer.Content.Elements.Add(element);
                active.Container = targetContainer.Content;
                RenderResume();
            }

            if (element is H1)
            {
                H1 active = (H1)element;
                active.Content = "- Titre 1 -";
                targetContainer.Content.Elements.Add(element);
                active.Container = targetContainer.Content;
                RenderResume();
            }

            if (element is H2)
            {
                H2 active = (H2)element;
                active.Content = "- Titre 2 -";
                targetContainer.Content.Elements.Add(element);
                active.Container = targetContainer.Content;
                RenderResume();
            }

            if (element is Date)
            {
                Date active = (Date)element;
                active.Content = DateTime.Today;
                targetContainer.Content.Elements.Add(element);
                active.Container = targetContainer.Content;
                RenderResume();
            }
        }
        #endregion

        #region TextEdition
        void EditShortText(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            CurrentSelection = label.Parent;
            
            SmallTextEditor editor = new SmallTextEditor();

            editor.Disposed += (s, evt) =>
            {
                if(CurrentSelection is ContainerDrop)
                {
                    ((ContainerDrop)CurrentSelection).ContainerTitleLabel.Text = editor.TextValue;
                    ((ContainerDrop)CurrentSelection).Content.Name = editor.TextValue;
                }
                else if (CurrentSelection is TextDrop)
                {
                    TextDrop td = (TextDrop)CurrentSelection;
                    if (td.Content is H1)
                    {
                        ((TextDrop)CurrentSelection).EditableText.Text = editor.TextValue;
                        ((H1)((TextDrop)CurrentSelection).Content).Content = editor.TextValue;
                    }
                    else if (td.Content is H2)
                    {
                        ((TextDrop)CurrentSelection).EditableText.Text = editor.TextValue;
                        ((H2)((TextDrop)CurrentSelection).Content).Content = editor.TextValue;
                    }
                }
                RenderResume();
            };
            editor.Show(label.Text, "Edit your title here");
        }

        void EditLongText(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            CurrentSelection = label.Parent;

            LargeTextEditor editor = new LargeTextEditor();

            editor.Disposed += (s, evt) =>
            {
                ((TextDrop)CurrentSelection).EditableText.Text = editor.TextValue;
                ((Paragraph)((TextDrop)CurrentSelection).Content).Content = editor.TextValue;
                RenderResume();
            };
            editor.Show(label.Text, "Edit your title here");
        }

        void EditDate(object sender, EventArgs e)
        {

        }
        #endregion

        #region MainButtons
        public void SaveResume()
        {
            // Rajouter une confirmation modale
            _resumeRepo.Save(_currentResume);
            save = true;
        }

        public void PortToPDF()
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "pdf (*.pdf)|*.pdf";
                dialog.FilterIndex = 2;
                dialog.RestoreDirectory = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    IParser parser = new PdfParser(_currentResume, dialog.FileName.ToString());
                    parser.Parse();
                }
            }
        }

        public void PortToHTML()
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "html (*.html)|*.html";
                dialog.FilterIndex = 2;
                dialog.RestoreDirectory = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    IParser parser = new HtmlParser(_currentResume, dialog.FileName.ToString());
                    parser.Parse();
                }
            }
        }
        #endregion
    }
}
