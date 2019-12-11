using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Widgets
{
    class FlatVScroll : VScrollBar
    {
        FlatVScroll()
        {
            Width = 10;
            Height = Parent.Height;
            Dock = DockStyle.Right;
            Minimum = 0;
            Maximum = 100;
            Value = 1;
            Scroll += new ScrollEventHandler(FlatVScroll_OnScroll);
        }

        private void FlatVScroll_OnScroll(object sender, ScrollEventArgs e)
        {
            if(Parent.GetType() == typeof(FlowLayoutPanel))
            {
                FlowLayoutPanel flowPanel = (FlowLayoutPanel)Parent;
                flowPanel.AutoScrollPosition = new Point(flowPanel.AutoScrollPosition.X, e.NewValue);
            }
        }
    }
}
