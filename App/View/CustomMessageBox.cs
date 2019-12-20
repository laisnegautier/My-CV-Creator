using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Widgets
{
    public partial class CustomMessageBox : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public DialogResult choice;
        /*static CustomMessageBox newMessageBox;
        static string Button_id;
        */

        public CustomMessageBox()
        {
            InitializeComponent();
            Paint += MessageBox_Paint;
        }
        
        #region RoundCornerView
        private void MessageBox_Paint(object sender, PaintEventArgs e)
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

        #region Drag
        private void DragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void DragPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);
                Update();
            }
        }

        private void DragPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion

        public new void Show()
        {
            titleLabel.Text = "Action";
            descritpionLabel.Text = "Confirm or Cancel";
            ShowDialog();
        }

        public void Show(string text)
        {
            titleLabel.Text = "Action";
            descritpionLabel.Text = text;
            ShowDialog();
        }

        public void Show(string text, string title)
        {
            titleLabel.Text = title;
            descritpionLabel.Text = text;
            ShowDialog();
        }

        private void oKButton_Click(object sender, EventArgs e)
        {
            choice = DialogResult.OK;
            Dispose();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            choice = DialogResult.Cancel;
            Dispose();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            choice = DialogResult.None;
            Dispose();
        }
    }
}
