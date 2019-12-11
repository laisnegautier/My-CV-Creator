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
        public Label ParagraphText { get { return paragraphText; } }

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
            paragraphText.TextAlign = ContentAlignment.MiddleCenter;
        }
    }
}
