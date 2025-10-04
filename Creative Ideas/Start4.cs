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
    public partial class Start4 : Form
    {

        Timer Mytimer = new Timer();
        public Start4()
        {
            InitializeComponent();
        }

        private void Start4_Load(object sender, EventArgs e)
        {
            Start4player.uiMode = "none";
            Start4player.windowlessVideo = true;
            Start4player.stretchToFit = true;
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            Start4player.URL = "Sketch.mp4";
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
        private void Start4_KeyDown(object sender, KeyEventArgs e)
        {
            Escapebutton(sender, e);
        }

        private void btnNML_KeyDown(object sender, KeyEventArgs e)
        {
            Escapebutton(sender, e);
        }

        private void btnDIN_KeyDown(object sender, KeyEventArgs e)
        {
            Escapebutton(sender, e);
        }

        private void Start4player_KeyDownEvent(object sender, AxWMPLib._WMPOCXEvents_KeyDownEvent e)
        {

        }

        private void btnDIN_MouseHover(object sender, EventArgs e)
        {
            btnDIN.Text = "Go!";
            btnDIN.BackColor = Color.DarkViolet;
        }

        private void btnDIN_MouseLeave(object sender, EventArgs e)
        {
            btnDIN.Text = "Do It Now!";
            btnDIN.BackColor = Color.FromArgb(255, 224, 192);
        }

        private void btnNML_MouseHover(object sender, EventArgs e)
        {
            btnNML.Text = "More features!";
            btnNML.BackColor = Color.DarkViolet;
        }

        private void btnNML_MouseLeave(object sender, EventArgs e)
        {
            btnNML.Text = "Nah,Maybe Later!";
            btnNML.BackColor = Color.FromArgb(255, 224, 192);
        }

        private void btnNML_Click(object sender, EventArgs e)
        {
            Start5 s5 = new Start5();
            s5.Show();
            Hide();
            Start4player.close();
        }

        private void lblSI_Click(object sender, EventArgs e)
        {

        }

        private void btnDIN_Click(object sender, EventArgs e)
        {
            Sketch s = new Sketch();
            s.Show();
            Hide();
            Start4player.close();
        }
    }
}
