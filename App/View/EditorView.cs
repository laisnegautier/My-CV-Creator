using App.Presenter;
using App.View;
using App.Widgets;
using Domain;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace App
{
    public partial class EditorView : Form, IEditorView
    {

        public Resume CurrentResume { get; set; }
        public EditorPresenter Presenter { private get; set; }
        public FlowLayoutPanel ResumeEditor { get { return resumeEditorPanel; } }
        public FlowLayoutPanel DefaultSectionPanel { get { return defaultSectionPanel; } }
        public FlowLayoutPanel DefaultElementPanel { get { return defaultElementPanel; } }
        public Label ResumeTitleLabel { get { return resumeTitleLabel; } }

        public EditorView()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            savePicture.Parent = saveButton;
            savePicture.Left = 10;
            savePicture.Top = 4;
            htmlPicture.Parent = ToHtmlButton;
            htmlPicture.Left = 10;
            htmlPicture.Top = 4;
            pdfPicture.Parent = ToPdfButton;
            pdfPicture.Left = 10;
            pdfPicture.Top = 4;

            resumeTitleLabel.DoubleClick += EditTitle;
        }

        private void EditorView_Load(object sender, EventArgs e)
        {
            Presenter.SetUpView();
        }

        private void EditTitle(object sender, EventArgs e)
        {
            SmallTextEditor editor = new SmallTextEditor();

            editor.Disposed += (s, evt) =>
            {
                resumeTitleLabel.Text = editor.TextValue;
            };

            editor.Show(resumeTitleLabel.Text, "Edit the title of your Resume");
        }

        #region ConfirmationSection
        public DialogResult ConfirmEdition(string value, string title)
        {
            DialogResult dialogResult = DialogResult.None;
            CustomMessageBox confirmDelete = new CustomMessageBox();
            confirmDelete.Disposed += (s, e) => { dialogResult = confirmDelete.choice; };
            confirmDelete.Show(value, title);

            return dialogResult;
        }
        #endregion

        #region fonctionalitiesButton
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        public void CloseButton_Enter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.FromArgb(255, 112, 102);
        }

        public void CloseButton_Leave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.FromArgb(100, 100, 100);
        }

        public void MinimizeButton_Enter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.FromArgb(64, 94, 107);
        }

        public void MinimizeButton_Leave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.FromArgb(100, 100, 100);
        }
        #endregion
        
        #region DragDrop
        public void OnDragDrop(object sender, DragEventArgs e)
        {
            Presenter.DealDragDrop(sender, e);
        }

        public void OnDragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        
        public void OnDragOver(object sender, DragEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        #endregion

        #region InteractionButton
        private void SetFocus(Button button)
        {
            button.BackColor = Color.FromArgb(64, 94, 107);
            button.ForeColor = Color.Black;
            if (button == saveButton) savePicture.BackgroundImage = Image.FromFile(@"..\..\..\Ressources\saveBlack.png");
            else if (button == ToPdfButton) pdfPicture.BackgroundImage = Image.FromFile(@"..\..\..\Ressources\pdfBlack.png");
            else if (button == ToHtmlButton) htmlPicture.BackgroundImage = Image.FromFile(@"..\..\..\Ressources\htmlBlack.png");
        }

        private void UnsetFocus(Button button)
        {
            button.BackColor = Color.FromArgb(18, 18, 18);
            button.ForeColor = Color.White;
            if (button == saveButton) savePicture.BackgroundImage = Image.FromFile(@"..\..\..\Ressources\saveWhite.png");
            else if (button == ToPdfButton) pdfPicture.BackgroundImage = Image.FromFile(@"..\..\..\Ressources\pdfWhite.png");
            else if (button == ToHtmlButton) htmlPicture.BackgroundImage = Image.FromFile(@"..\..\..\Ressources\htmlWhite.png");
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            if (sender is Button) SetFocus((Button)sender);
            else if (sender is PictureBox)
            {
                PictureBox pic = (PictureBox)sender;
                if (pic.Parent is Button) SetFocus((Button)pic.Parent);
            }
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            if (sender is Button) UnsetFocus((Button)sender);
            else if (sender is PictureBox)
            {
                PictureBox pic = (PictureBox)sender;
                if (pic.Parent is Button) UnsetFocus((Button)pic.Parent);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Presenter.SaveResume();
        }

        private void PDF_Click(object sender, EventArgs e)
        {
            Presenter.PortToPDF();
        }

        private void HTML_Click(object sender, EventArgs e)
        {
            Presenter.PortToHTML();
        }
        #endregion
    }
}