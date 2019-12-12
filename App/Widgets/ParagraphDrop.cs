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
    public partial class ParagraphDrop : UserControl
    {
        private Paragraph _paragraph;

        public Panel ControlPanel { get { return controlPanel; } }
        public Label ParagraphText { get { return paragraphText; } }
        public bool IsSelected { get; set; }

        public string TextValue
        {
            get { return paragraphText.Text; }
            set
            {
                paragraphText.AutoSize = true;
                paragraphText.Text = value;
                paragraphText.AutoSize = false;
                Height = paragraphText.Height + 20;
                Content.Content = value;
            }
        }

        public Paragraph Content
        {
            get { return _paragraph; }
            set
            {
                _paragraph = value;
                TextValue = _paragraph.Content;
            }
        }

        public ParagraphDrop(Paragraph p)
        {
            InitializeComponent();
            Content = p;
            //IsSelected = false;
            paragraphText.TextAlign = ContentAlignment.MiddleCenter;
        }

        public void ParagraphDrop_OnPaint(object sender, PaintEventArgs e)
        {
            // Displaying the container control panel
            if (IsSelected) controlPanel.Show();
            else controlPanel.Hide();
            // Painting the border
            ParagraphDrop pd = (ParagraphDrop)sender;
            if (IsSelected) ControlPaint.DrawBorder(e.Graphics, pd.ClientRectangle,
                                                     Color.FromArgb(200, 200, 200), 3, ButtonBorderStyle.Dashed,
                                                     Color.FromArgb(200, 200, 200), 3, ButtonBorderStyle.Dashed,
                                                     Color.FromArgb(200, 200, 200), 3, ButtonBorderStyle.Dashed,
                                                     Color.FromArgb(200, 200, 200), 3, ButtonBorderStyle.Dashed);
            else ControlPaint.DrawBorder(e.Graphics, pd.ClientRectangle, Color.FromArgb(220, 220, 220), ButtonBorderStyle.None);
        }
    }
}
