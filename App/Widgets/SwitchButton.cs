using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Widgets
{
    public partial class SwitchButton : CheckBox
    {
        public SwitchButton()
        {
            InitializeComponent();
            Paint += Switch_OnPaint;
        }

        public void Switch_OnPaint(object sender, PaintEventArgs e)
        {
            if (Checked) BackgroundImage = Image.FromFile(@"..\..\..\Ressources\switch-on.png");
            else BackgroundImage = Image.FromFile(@"..\..\..\Ressources\switchOff.png");
        }
    }
}
