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

namespace App.Widgets
{
    public partial class TextDrop : UserControl
    {
        private IElement _element;

        #region IElementView
        public ContainerDrop ParentContainer { get; set; }
        public Panel ControlPanel { get { return controlPanel; } }
        public bool IsSelected { get; set; }
        public IElement Content
        {
            get { return _element; }
            set
            {

                if (value is Paragraph)
                {
                    Paragraph p = (Paragraph)value;
                    _element = p;
                    TextValue = p.Content;
                }
                else if(value is H1)
                {
                    H1 h = (H1)value;
                    _element = h;
                    TextValue = h.Content;
                }
                else if (value is H2)
                {
                    H2 h = (H2)value;
                    _element = h;
                    TextValue = h.Content;
                }
            }
        }
        public Button UpButton { get { return upButton; } }
        public Button DownButton { get { return downButton; } }
        public Button RenderButton { get { return null; } } // Ajouter le render button
        #endregion

        public Label EditableText { get { return editableText; } }
        public string TextValue
        {
            get { return editableText.Text; }
            set
            {
                if (Content is Paragraph) ((Paragraph)Content).Content = value;
                else if (Content is H1) ((H1)Content).Content = value; 
                else if (Content is H2) ((H2)Content).Content = value;
                
                editableText.AutoSize = true;
                editableText.Text = value;
                editableText.AutoSize = false;
                Height = editableText.Height + 20;
            }
        } 
        
        public TextDrop()
        {
            InitializeComponent();
        }

        public TextDrop(Paragraph p) : this()
        {
            //InitializeComponent();
            Content = p;
            //IsSelected = false;
            editableText.TextAlign = ContentAlignment.MiddleCenter;
            Paint += ElementView_OnPaint;
        }

        public TextDrop(H1 title) : this()
        {
            Content = title;
            editableText.Font = new Font("Arial", 24);
            editableText.TextAlign = ContentAlignment.MiddleLeft;
        }

        public TextDrop(H2 title) : this()
        {
            Content = title;
            editableText.Font = new Font("Arial", 20);
            editableText.TextAlign = ContentAlignment.MiddleLeft;
        }

        public void ElementView_OnPaint(object sender, PaintEventArgs e)
        {
            // Displaying the container control panel
            if (IsSelected) controlPanel.Show();
            else controlPanel.Hide();
            // Painting the border
            TextDrop pd = (TextDrop)sender;
            if (IsSelected) ControlPaint.DrawBorder(e.Graphics, pd.ClientRectangle,
                                                     Color.FromArgb(200, 200, 200), 3, ButtonBorderStyle.Dashed,
                                                     Color.FromArgb(200, 200, 200), 3, ButtonBorderStyle.Dashed,
                                                     Color.FromArgb(200, 200, 200), 3, ButtonBorderStyle.Dashed,
                                                     Color.FromArgb(200, 200, 200), 3, ButtonBorderStyle.Dashed);
            else ControlPaint.DrawBorder(e.Graphics, pd.ClientRectangle, Color.FromArgb(220, 220, 220), ButtonBorderStyle.None);
        }
    }
}
