using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.View
{
    public partial class DateEditor : Form
    {
        private DateTime initValue;
        private Point lastLocation;
        private bool mouseDown;
        private DateTime startValue;
        private DateTime _dateValue;
        public DateTime DateValue
        {
            get { return _dateValue; }
            set
            {
                _dateValue = value;
                dayBox.Text = value.Day.ToString();
                monthBox.Text = value.Month.ToString();
                yearBox.Text = value.Year.ToString();
            }
        }

        public DateEditor()
        {
            InitializeComponent();
            Paint += Editor_Paint;
        }

        public void Show(DateTime value, string help)
        {
            DateValue = value;
            startValue = value;
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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DateValue = initValue;
            Dispose();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (DateValue != initValue)
            {
                _dateValue = new DateTime(Convert.ToInt32(yearBox.Text), Convert.ToInt32(monthBox.Text), Convert.ToInt32(dayBox.Text));
                DialogResult = DialogResult.OK;
                Dispose();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Box_OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}


