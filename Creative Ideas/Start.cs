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
    public partial class Start : Form
    {
        Timer Mytimer = new Timer();
        public Start()
        {
            InitializeComponent();
            btndummy.Select();
        }

        private void StartVideoPlayer_Enter(object sender, EventArgs e)
        {
            
        }

        private void Start_Load(object sender, EventArgs e)
        {
            Mytimer.Interval =(5*60*1000);
            Mytimer.Tick += new EventHandler(Mytimer_Tick);
            Mytimer.Start();
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            StartVideoPlayer.URL = "CreativeIdeasCutscenes.mp4";
            btndummy.Select();
            
        }
        private void Mytimer_Tick(object sender, EventArgs e)
        {
            Loading l = new Loading();
            l.Show();
            Hide();
            Mytimer.Stop();
            StartVideoPlayer.close();
        }

        private void Start_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void btndummy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Mytimer.Stop();
                Loading l = new Loading();
                l.Show();
                Hide();
                StartVideoPlayer.close();
            }
              
        }

    }
}
