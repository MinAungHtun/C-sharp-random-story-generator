using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creative_Ideas
{
    public partial class Animation : Form
    {
        string i;
        public Animation(string dd)
        {
            i= dd;
            InitializeComponent();
        }

        private void Animation_Load(object sender, EventArgs e)
        {
            Animationplayer.uiMode = "full";
            Animationplayer.windowlessVideo = true;
            Animationplayer.stretchToFit = true;
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.WindowState = FormWindowState.Normal;
            Animationplayer.URL = i;
        }
        
        }
}
