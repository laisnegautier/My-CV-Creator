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
    public partial class LargeTextEditor : Form
    {
        private string initValue;
        private bool mouseDown;
        private Point lastLocation;

        public string TextValue { get; set; }

        public LargeTextEditor()
        {
            InitializeComponent();
            Paint += Editor_Paint;
        }

        public void Show(string value, string help)
        {
            editBox.Text = value;
            initValue = value;
            descritpionLabel.Text = help;
            ShowDialog();
        }

        #region RoundCornerView
        private void Editor_Paint(object sender, PaintEventArgs e)
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

        #region Dragg
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

        #region Buttons
        private void CancelButton_Click(object sender, EventArgs e)
        {
            TextValue = initValue;
            Dispose();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (editBox.Text != null && editBox.Text != "" && editBox.Text != initValue)
            {
                TextValue = editBox.Text;
                Dispose();
            }
        }
        
        private void CloseButton_Click(object sender, EventArgs e)
        {
            if (editBox.Text != null && editBox.Text != "" && editBox.Text != initValue)
            {
                TextValue = editBox.Text;
                Dispose();
            }
            else
            {
                TextValue = initValue;
                Dispose();
            }
        }
        #endregion
    }
}
