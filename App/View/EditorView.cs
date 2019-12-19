using App.Presenter;
using App.View;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public EditorView()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void EditorView_Load(object sender, EventArgs e)
        {
            Presenter.SetUpView();
        }

        #region ConfirmationSection
        public DialogResult ConfirmDeleteContainer(string title)
        {
            DialogResult dialogResult = MessageBox.Show("Voulez vous supprimer cette section ?", title, MessageBoxButtons.YesNo);
            return dialogResult;
        }

        public DialogResult ConfirmDeleteElement(string title)
        {
            DialogResult dialogResult = MessageBox.Show("Voulez vous supprimer cet element ?", title, MessageBoxButtons.YesNo);
            return dialogResult;
        }

        public DialogResult ConfirmCopyContainer(string title)
        {
            DialogResult dialogResult = MessageBox.Show("Voulez vous copier cette section ?", title, MessageBoxButtons.YesNo);
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

        public void OnDragLeave(object sender, EventArgs e)
        {

        }

        public void OnDragOver(object sender, DragEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        #endregion

        private void SetFocus(Button button)
        {
            button.BackColor = Color.FromArgb(64, 94, 107);
            button.ForeColor = Color.Black;
            /*if (button == addButton) addPicture.BackgroundImage = Image.FromFile(@"..\..\..\Ressources\addBlack.png");
            else if (button == editButton) editPicture.BackgroundImage = Image.FromFile(@"..\..\..\Ressources\editBlack.png");
            else if (button == deleteButton) deletePicture.BackgroundImage = Image.FromFile(@"..\..\..\Ressources\deleteBlack.png");
            else if (button == copyButton) copyPicture.BackgroundImage = Image.FromFile(@"..\..\..\Ressources\copyBlack.png");*/
        }

        private void UnsetFocus(Button button)
        {
            button.BackColor = Color.FromArgb(18, 18, 18);
            button.ForeColor = Color.White;
            /*if (button == addButton) addPicture.BackgroundImage = Image.FromFile(@"..\..\..\Ressources\addWhite.png");
            else if (button == editButton) editPicture.BackgroundImage = Image.FromFile(@"..\..\..\Ressources\editWhite.png");
            else if (button == deleteButton) deletePicture.BackgroundImage = Image.FromFile(@"..\..\..\Ressources\deleteWhite.png");
            else if (button == copyButton) copyPicture.BackgroundImage = Image.FromFile(@"..\..\..\Ressources\copyWhite.png");*/
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
    }
}