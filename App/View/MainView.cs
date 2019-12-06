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
        public Resume CurrentResume{ get; set; }

        public MainPresenter Presenter { private get; set; }
        List<ResumeMiniaturePic> IMainView.Resumes
        {
            set { foreach (ResumeMiniaturePic rmp in value)
                    {
                        rmp.Click += Presenter.SetCurrentResume;
                        resumeLayoutPanel.Controls.Add(rmp);
                    }
            }
        }
        
        #endregion

        #region Initialisation
        public MainView()
        {
            InitializeComponent();
            SetUpDesing();
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
    }
}
