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
    public partial class Start5 : Form
    {
        Timer Mytimer = new Timer();
        string p;
        public Start5()
        {
            InitializeComponent();
        }

        private void Start5_Load(object sender, EventArgs e)
        {
            Start5player.uiMode = "none";
            Start5player.windowlessVideo = true;
            Start5player.stretchToFit = true;
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            Start5player.URL = "Scripting.mp4";
            
        }
    
        public void Escapebutton(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {

                this.TopMost = false;
                this.FormBorderStyle = FormBorderStyle.Fixed3D;
                this.WindowState = FormWindowState.Maximized;

            }
            else if (e.KeyCode == Keys.F1)
            {
                this.TopMost = true;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;

            }
        }

        private void btnF_KeyDown(object sender, KeyEventArgs e)
        {
            Escapebutton(sender, e);
        }

        private void btnNE_KeyDown(object sender, KeyEventArgs e)
        {
            Escapebutton(sender, e);
        }

        private void btnF_MouseHover(object sender, EventArgs e)
        {
            btnF.Text = "Huurrray!!!";
            btnF.BackColor = Color.Crimson;
        }

        private void btnF_MouseLeave(object sender, EventArgs e)
        {
            btnF.Text = "Yes,Finally!";
            btnF.BackColor = Color.FromArgb(255, 224, 192);
        }

        private void btnNE_MouseHover(object sender, EventArgs e)
        {
            btnNE.Text = "Suit yourself then :-)";
            btnNE.BackColor = Color.Crimson;
        }

        private void btnNE_MouseLeave(object sender, EventArgs e)
        {
            btnNE.Text = "Not Exactly";
            btnNE.BackColor = Color.FromArgb(255, 224, 192);

        }

        private void btnF_Click(object sender, EventArgs e)
        {
            Script1 s = new Script1();
            s.Show();
            Hide();
            Start5player.close();
        }

        private void btnNE_Click(object sender, EventArgs e)
        {
            p = "Not logged in";
            Main m = new Main(p);
            m.Show();
            Hide();
            Start5player.close();
        }
    }
}
