﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace App
{
    public partial class ResumeMiniaturePic : UserControl
    {
        public Resume Resume { get; set; }
        public bool isSelected { get; set; }
        public Button FavButton { get { return favButton; } }

        public ResumeMiniaturePic( Resume resume )
        {
            InitializeComponent();

            isSelected = false;
            Resume = resume;
            resumeTitle.Text = resume.Title;
            containerLabel.Text += resume.Containers.Count;
            int count = 0;
            foreach(Domain.Container container in resume.Containers)
            {
                if(container.Elements != null) count += container.Elements.Count;
            }
            elementLabel.Text += count;
            Paint += DropShadow;
            Paint += RightShadow;
            Paint += Pic_OnPaint;

            MouseEnter += Pic_OnMouseEnter;
            MouseLeave += Pic_OnMouseLeave;

            ToolTip tip = new ToolTip();
            favButton.MouseEnter += (s, e) => { favButton.BackgroundImage = Image.FromFile(@"..\..\..\Ressources\favHover.png"); };
            favButton.MouseLeave += (s, e) => { Refresh(); };
            favButton.MouseHover += (s, e) => { tip.Show("Add to Favorites", favButton); };
        }

        #region Shadows
        private void DropShadow(object sender, PaintEventArgs e)
        {
            //Panel panel = (Panel)sender;
            Color[] shadow = new Color[3];
            shadow[0] = Color.FromArgb(0, 0, 0);
            shadow[1] = Color.FromArgb(0, 0, 0);
            shadow[2] = Color.FromArgb(0, 0, 0);
            Pen pen = new Pen(shadow[2]);
            using (pen)
            {
                //foreach (Panel p in panel.Controls.OfType<Panel>())
                //{
                    Point pt = Location;
                    pt.Y += Height;
                    for (var sp = 0; sp < 3; sp++)
                    {
                        pen.Color = shadow[sp];
                        e.Graphics.DrawLine(pen, pt.X, pt.Y, pt.X + Width - 1, pt.Y);
                        pt.Y++;
                    }
                //}
            }
        }

        private void RightShadow(object sender, PaintEventArgs e)
        {
            //Panel panel = (Panel)sender;
            Color[] shadow = new Color[3];
            shadow[0] = Color.FromArgb(181, 181, 181);
            shadow[1] = Color.FromArgb(195, 195, 195);
            shadow[2] = Color.FromArgb(211, 211, 211);
            Pen pen = new Pen(shadow[0]);
            using (pen)
            {
                //foreach (Panel p in panel.Controls.OfType<Panel>())
                //{
                    Point pt = Location;
                    pt.X += Width;
                    for (var sp = 0; sp < 3; sp++)
                    {
                        pen.Color = shadow[sp];
                        e.Graphics.DrawLine(pen, pt.X, pt.Y, pt.X, pt.Y + Height + 1);
                        pt.Y++;
                    }
                //}
            }
        }
        #endregion

        #region RoundCornerView
        private void Pic_OnPaint(object sender, PaintEventArgs e)
        {
            // Gestion fav
            if (Resume.Favorite) favButton.BackgroundImage = Image.FromFile(@"..\..\..\Ressources\favTrue.png");
            else favButton.BackgroundImage = Image.FromFile(@"..\..\..\Ressources\favFalse.png");
            
            System.IntPtr ptr = CreateRoundRectRgn(0, 0, this.Width, this.Height, 5, 5); // _BoarderRaduis can be adjusted to your needs, try 15 to start.
            Region = Region.FromHrgn(ptr);
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

        #region Hover
        public void Pic_OnMouseEnter(object sender, EventArgs e)
        {
            if (isSelected) BackColor = Color.FromArgb(50,50,50);
            else BackColor = Color.FromArgb(48, 48, 48);
        }

        public void Pic_OnMouseLeave(object sender, EventArgs e)
        {
            if (isSelected) BackColor = Color.FromArgb(58, 58, 58);
            else BackColor = Color.FromArgb(38, 38, 38);
        }
        #endregion

        private void FavButton_Click(object sender, EventArgs e)
        {
            Resume.Favorite = !Resume.Favorite;
            Refresh();
        }
    }
}
