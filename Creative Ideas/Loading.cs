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
    public partial class Loading : Form
    {
        Timer Mytimer= new Timer();
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            Mytimer.Interval = (14 * 1000);
            Mytimer.Tick += new EventHandler(Mytimer_Tick);
            Mytimer.Start();
            LoadingVP.uiMode = "none";
            LoadingVP.windowlessVideo = true;
            LoadingVP.stretchToFit = true;
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            LoadingVP.URL = "CreativeIdeasLoadingScenes.mp4";
        }
        private void Mytimer_Tick(object sender, EventArgs e)
        {
            Start2 s2 = new Start2();
            s2.Show();
            Mytimer.Stop();
            Hide();
            LoadingVP.close();
        }

        private void LoadingVP_Enter(object sender, EventArgs e)
        {

        }

        private void Loading_KeyDown(object sender, KeyEventArgs e)
        {

        }

    }
}
