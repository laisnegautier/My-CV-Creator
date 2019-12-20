﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Presenter;
using App.View;
using App.Widgets;
using Domain;

namespace App
{
    public partial class MainView : Form , IMainView
    {
        private bool mouseDown;
        private Point lastLocation;

        #region IMainView
        public MainPresenter Presenter { private get; set; }
        public Label EmptyLabel { get { return emptyLabel; } }
        List<ResumeMiniaturePic> IMainView.Resumes
        {
            set
            {
                resumeLayoutPanel.Controls.Clear();
                foreach (ResumeMiniaturePic rmp in value)
                {
                    rmp.Click += Presenter.SetCurrentResume;
                    resumeLayoutPanel.Controls.Add(rmp);
                }
            }
        }
        // 255; 112; 102
        #endregion

        #region Initialisation
        public MainView()
        {
            InitializeComponent();
            emptyLabel.Hide();
            SetUpDesing();
            addPicture.Parent = addButton;
            editPicture.Parent = editButton;
            int offset = addPicture.Top - addButton.Top;
            editPicture.Location = new Point(addPicture.Left, offset);
            copyPicture.Parent = copyButton;
            copyPicture.Location = new Point(addPicture.Left, offset);
            deletePicture.Parent = deleteButton;
            deletePicture.Location = new Point(addPicture.Left, offset);
            //SetRoundAdd();
        }
        #endregion
        
        void SetUpDesing()
        {
            dragPanel.Paint += DropShadow;
            buttonPanel.Paint += DropShadow;
        }

        void SetRoundAdd()
        {
            RoundButton addNewButton = new RoundButton();
            addNewButton.BackColor = Color.FromArgb(64, 94, 107);
            addNewButton.Location = new Point(10, 10);
            addNewButton.Click += AddButton_Click;
            Controls.Add(addNewButton);
            addNewButton.BringToFront();
        }

        #region FonctionnalitiesButton
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
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
            button.BackColor = Color.FromArgb(100,100,100);
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

        private void DragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void DragPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void DragPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion

        #region RoundCornerView
        private void MainView_Paint(object sender, PaintEventArgs e)
        {
            System.IntPtr ptr = CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20); // _BoarderRaduis can be adjusted to your needs, try 15 to start.
            this.Region = Region.FromHrgn(ptr);
            DeleteObject(ptr);
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        private static extern bool DeleteObject(System.IntPtr hObject);

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern System.IntPtr CreateRoundRectRgn
          (
           int nLeftRect, // x-coordinate of upper-left corner
           int nTopRect, // y-coordinate of upper-left corner
           int nRightRect, // x-coordinate of lower-right corner
           int nBottomRect, // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
          );
        #endregion

        #region Shadows
        private void DropShadow(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            Color[] shadow = new Color[3];
            shadow[0] = Color.FromArgb(181, 181, 181);
            shadow[1] = Color.FromArgb(195, 195, 195);
            shadow[2] = Color.FromArgb(211, 211, 211);
            Pen pen = new Pen(shadow[2]);
            using (pen)
            {
                foreach (Panel p in panel.Controls.OfType<Panel>())
                {
                    Point pt = p.Location;
                    pt.Y += p.Height;
                    for (var sp = 0; sp < 3; sp++)
                    {
                        pen.Color = shadow[sp];
                        e.Graphics.DrawLine(pen, pt.X, pt.Y, pt.X + p.Width - 1, pt.Y);
                        pt.Y++;
                    }
                }
            }
        }

        private void RightShadow(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            Color[] shadow = new Color[3];
            shadow[0] = Color.FromArgb(181, 181, 181);
            shadow[1] = Color.FromArgb(195, 195, 195);
            shadow[2] = Color.FromArgb(211, 211, 211);
            Pen pen = new Pen(shadow[0]);
            using (pen)
            {
                foreach (Panel p in panel.Controls.OfType<Panel>())
                {
                    Point pt = p.Location;
                    pt.X += p.Width;
                    for (var sp = 0; sp < 3; sp++)
                    {
                        pen.Color = shadow[sp];
                        e.Graphics.DrawLine(pen, pt.X, pt.Y, pt.X, pt.Y + p.Height + 1);
                        pt.Y++;
                    }
                }
            }
        }
        #endregion

        public DialogResult ConfirmDelete(string title)
        {
            DialogResult dialogResult = DialogResult.None;
            CustomMessageBox confirmDeleterMsgBox = new CustomMessageBox();
            confirmDeleterMsgBox.Disposed += (s, e) => { dialogResult = confirmDeleterMsgBox.choice; };
            confirmDeleterMsgBox.Show("Are you sure you want to delete this container ?",title);
            //DialogResult dialogResult = MessageBox.Show("Voulez vous supprimer ce CV ?", title, MessageBoxButtons.YesNo);
            return dialogResult;
        }

        public DialogResult ConfirmCopy(string title)
        {
            DialogResult dialogResult = DialogResult.None;
            CustomMessageBox confirmCopyMsgBox = new CustomMessageBox();
            confirmCopyMsgBox.Disposed += (s, e) => { dialogResult = confirmCopyMsgBox.choice; };
            confirmCopyMsgBox.Show("Are you sure you want to delete this resume ?", title);

            return dialogResult;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Presenter.AddNew();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Presenter.Edit();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Presenter.Delete();
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            Presenter.Copy();
        }

        private void SetFocus(Button button)
        {
            button.BackColor = Color.FromArgb(64,94,107);
            button.ForeColor = Color.Black;
            if (button == addButton) addPicture.BackgroundImage = Image.FromFile(@"..\..\..\Ressources\addBlack.png");
            else if (button == editButton) editPicture.BackgroundImage = Image.FromFile(@"..\..\..\Ressources\editBlack.png");
            else if (button == deleteButton) deletePicture.BackgroundImage = Image.FromFile(@"..\..\..\Ressources\deleteBlack.png");
            else if (button == copyButton) copyPicture.BackgroundImage = Image.FromFile(@"..\..\..\Ressources\copyBlack.png");
        }

        private void UnsetFocus(Button button)
        {
            button.BackColor = Color.FromArgb(18,18,18);
            button.ForeColor = Color.White;
            if (button == addButton) addPicture.BackgroundImage = Image.FromFile(@"..\..\..\Ressources\addWhite.png");
            else if (button == editButton) editPicture.BackgroundImage = Image.FromFile(@"..\..\..\Ressources\editWhite.png");
            else if (button == deleteButton) deletePicture.BackgroundImage = Image.FromFile(@"..\..\..\Ressources\deleteWhite.png");
            else if (button == copyButton) copyPicture.BackgroundImage = Image.FromFile(@"..\..\..\Ressources\copyWhite.png");
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
