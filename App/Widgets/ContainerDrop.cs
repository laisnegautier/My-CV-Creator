using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace App.Widgets
{
    public partial class ContainerDrop : UserControl
    {
        public bool IsSelected { get; set; }
        public Domain.Container Content { get; set; }
        public Control ElementPanel { get{ return elementPanel; } }
        public Button FavButton { get { return favButton; } }
        public Button UpButton { get { return upButton; } }
        public Button DownButton { get { return downButton; } }

        public ContainerDrop()
        {
            InitializeComponent();
            elementPanel.Paint += ElemPanel_OnPaint;
            IsSelected = false;
            Content = new Domain.Container();
            controlPanel.Hide();
        }

        public ContainerDrop(Domain.Container content)
        {
            InitializeComponent();
            Content = content;
            elementPanel.Paint += ElemPanel_OnPaint;
            IsSelected = false;
            containerNameLabel.Text = Content.Name != null ? Content.Name : "Unknown";
            controlPanel.Paint += ControlPanel_Paint;

            InitializeButton();

        }

        public void InitializeButton()
        {
            #region FavButton
            favButton.FlatAppearance.MouseOverBackColor = favButton.BackColor;
            favButton.BackColorChanged += (s, e) =>
            {
                favButton.FlatAppearance.MouseOverBackColor = favButton.BackColor;
                favButton.FlatAppearance.MouseDownBackColor = favButton.BackColor;
            };
            favButton.MouseEnter += (s, e) => { favButton.BackgroundImage = Image.FromFile(@"..\..\..\Ressources\favHover.png"); };
            favButton.MouseLeave += (s, e) => { Refresh(); };
            favButton.MouseHover += (s, e) => { addTip.Show("Add to Favorites", favButton); };
            #endregion

            #region UpButton
            upButton.FlatAppearance.MouseOverBackColor = upButton.BackColor;
            upButton.BackColorChanged += (s, e) =>
            {
                upButton.FlatAppearance.MouseOverBackColor = upButton.BackColor;
                upButton.FlatAppearance.MouseDownBackColor = upButton.BackColor;
            };
            upButton.MouseEnter += (s, e) => { upButton.BackgroundImage = Image.FromFile(@"..\..\..\Ressources\upHover.png"); };
            upButton.MouseLeave += (s, e) => { upButton.BackgroundImage = Image.FromFile(@"..\..\..\Ressources\up.png"); };
            #endregion

            #region DownButton
            DownButton.FlatAppearance.MouseOverBackColor = DownButton.BackColor;
            DownButton.BackColorChanged += (s, e) =>
            {
                DownButton.FlatAppearance.MouseOverBackColor = DownButton.BackColor;
                DownButton.FlatAppearance.MouseDownBackColor = DownButton.BackColor;
            };
            DownButton.MouseEnter += (s, e) => { DownButton.BackgroundImage = Image.FromFile(@"..\..\..\Ressources\downHover.png"); };
            DownButton.MouseLeave += (s, e) => { DownButton.BackgroundImage = Image.FromFile(@"..\..\..\Ressources\down.png"); };
            #endregion
        }

        public void ElemPanel_OnPaint(object sender, PaintEventArgs e)
        {
            // Displaying the container control panel
            if (IsSelected) controlPanel.Show();
            else controlPanel.Hide();
            // Favori ou non
            if (Content.Favorite == false) favButton.BackgroundImage = Image.FromFile(@"..\..\..\Ressources\favFalse.png");
            else favButton.BackgroundImage = Image.FromFile(@"..\..\..\Ressources\favTrue.png");
            // Design
            FlowLayoutPanel panel = (FlowLayoutPanel)sender;
            if(IsSelected) ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle, 
                                                    Color.FromArgb(200,200,200), 3 , ButtonBorderStyle.Dashed,
                                                    Color.FromArgb(200, 200, 200), 3, ButtonBorderStyle.Dashed,
                                                    Color.FromArgb(200, 200, 200), 3, ButtonBorderStyle.Dashed,
                                                    Color.FromArgb(200, 200, 200), 3, ButtonBorderStyle.Dashed);
            else ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle, Color.FromArgb(220, 220, 220), ButtonBorderStyle.None);
        }


        #region RoundCornerView
        private void ControlPanel_Paint(object sender, PaintEventArgs e)
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
    }
}
