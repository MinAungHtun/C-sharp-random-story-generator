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
    public partial class Start3 : Form
    {
        Timer Mytimer = new Timer();
        public Start3()
        {
            InitializeComponent();
        }

        private void Start3_Load(object sender, EventArgs e)
        {
            Start3videoplayer.uiMode = "none";
            Start3videoplayer.windowlessVideo = true;
            Start3videoplayer.stretchToFit = true;
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            Start3videoplayer.URL = "Scripting.mp4";
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
        

        private void btnLS_KeyDown(object sender, KeyEventArgs e)
        {
            Escapebutton(sender, e);
        }

        private void btnNope_KeyDown(object sender, KeyEventArgs e)
        {
            Escapebutton(sender, e);
        }

        private void btnNope_Click(object sender, EventArgs e)
        {
            Start4 s4 = new Start4();
            s4.Show();
            Hide();
            Start3videoplayer.close();
        }

        private void btnLS_MouseHover(object sender, EventArgs e)
        {
            btnLS.Text = "Right AWAY!";
            btnLS.BackColor = Color.Lime;
        }

        private void btnLS_MouseLeave(object sender, EventArgs e)
        {
            btnLS.Text = "Let's see!";
            btnLS.BackColor = Color.FromArgb(255, 224, 192);
        }

        private void btnNope_MouseHover(object sender, EventArgs e)
        {
            btnNope.Text = "OK, Next";

            btnNope.BackColor = Color.Lime;
        }

        private void btnNope_MouseLeave(object sender, EventArgs e)
        {
            btnNope.Text = "Nope!";
            btnNope.BackColor = Color.FromArgb(255, 224, 192);
        }

        private void Start3_KeyDown(object sender, KeyEventArgs e)
        {
            Escapebutton(sender, e);
        }

        private void lbls3_Click(object sender, EventArgs e)
        {

        }

        private void btnLS_Click(object sender, EventArgs e)
        {
            Generator1 g = new Generator1();
            g.Show();
            Hide();
            Start3videoplayer.close();
        }
    }
}
