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
            elementPanel.Paint += ElemPanel_OnPaint;
            IsSelected = false;
            Content = content;
            containerNameLabel.Text = Content.Name != null ? Content.Name : "Unknown";
        }

        public void ElemPanel_OnPaint(object sender, PaintEventArgs e)
        {
            // Displaying the container control panel
            if (IsSelected) controlPanel.Show();
            else controlPanel.Hide();
            // Design
            FlowLayoutPanel panel = (FlowLayoutPanel)sender;
            if(IsSelected) ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle, 
                                                    Color.FromArgb(200,200,200), 3 , ButtonBorderStyle.Dashed,
                                                    Color.FromArgb(200, 200, 200), 3, ButtonBorderStyle.Dashed,
                                                    Color.FromArgb(200, 200, 200), 3, ButtonBorderStyle.Dashed,
                                                    Color.FromArgb(200, 200, 200), 3, ButtonBorderStyle.Dashed);
            else ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle, Color.FromArgb(220, 220, 220), ButtonBorderStyle.None);
        }

        private void favButton_Click(object sender, EventArgs e)
        {
            if (Content != null) Content.Favorite = !Content.Favorite;
            // Modification de style
        }
    }
}
