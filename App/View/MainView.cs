using System;
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
using Domain;

namespace App
{
    public partial class MainView : Form , IMainView
    {
        private bool mouseDown;
        private Point lastLocation;

        #region IMainView
        public List<Resume> Resumes
        {
            get { return (List<Resume>)resumeListBox.DataSource; }
            set { resumeListBox.DataSource = value; }
        }

        public Resume CurrentResume{ get; set; }

        public MainPresenter Presenter { private get; set; }
        #endregion

        #region Initialisation
        public MainView()
        {
            InitializeComponent();
        }
        #endregion


        /*private void resumeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentResume = (Resume)resumeListBox.Items[resumeListBox.Items.IndexOf((Resume)sender)];
        }*/

        #region FonctionnalitiesButton
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

    }
}
