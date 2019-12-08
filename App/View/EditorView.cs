using App.Presenter;
using App.View;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class EditorView : Form,  IEditorView
    {

        public Resume CurrentResume { get; set; }
        public EditorPresenter Presenter { private get; set; }
        public FlowLayoutPanel ResumeEditor { get{ return resumeEditorPanel; } }
        public FlowLayoutPanel DefaultSectionPanel { get { return defaultSectionPanel; } }
       
        public EditorView()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void EditorView_Load(object sender, EventArgs e)
        {
            Presenter.SetUpView();
        }

        #region DragDrop


        public void OnDragDrop(object sender, DragEventArgs e)
        {
            Presenter.DealDragDrop(sender, e);
        }

        public void OnDragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            Cursor.Current = Cursors.Hand;
        }

        public void OnDragLeave(object sender, EventArgs e)
        {
        }

        public void OnDragOver(object sender, DragEventArgs e)
        {
            //BackColor = Color.Khaki;
        }

        #endregion
    }
}
