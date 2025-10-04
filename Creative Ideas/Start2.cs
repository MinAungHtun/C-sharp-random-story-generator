using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
namespace Creative_Ideas
{
    public partial class Start2 : Form
    {
        Timer Mytimer = new Timer();
        string p;
        public Start2()
        {
            InitializeComponent();
            
        }

        private void Start2_KeyDown(object sender, KeyEventArgs e)
        {
            Escapebutton(sender, e);
        }

        private void Start2_Load(object sender, EventArgs e)
        {
            Start2player.uiMode = "none";
            Start2player.windowlessVideo = true;
            Start2player.stretchToFit = true;
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            Start2player.URL = "Welcome.mp4";
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

        private void btnsn_KeyDown(object sender, KeyEventArgs e)
        {
            Escapebutton(sender,e);
        }

        private void btntat_KeyDown(object sender, KeyEventArgs e)
        {
            Escapebutton(sender,e);

        }

        private void btnsn_Click(object sender, EventArgs e)
        {
            p = "Not logged in";
            Main m = new Main(p);
            m.Show();
            Hide();   
            Start2player.close();
        }

        private void Start2player_Enter(object sender, EventArgs e)
        {

        }

        private void btntat_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void btntat_MouseLeave(object sender, EventArgs e)
        {
            btntat.Text = "Take a tour!"; 
            btntat.BackColor=Color.FromArgb(255,224,192);
        }

        private void btntat_MouseHover(object sender, EventArgs e)
        {
            btntat.Text = "Let's do it!";
            btntat.BackColor = Color.OrangeRed;
        }

        private void btnsn_MouseHover(object sender, EventArgs e)
        {
            btnsn.Text = "OK,THen";
            btnsn.BackColor = Color.OrangeRed;
        }

        private void btnsn_MouseLeave(object sender, EventArgs e)
        {
            btnsn.Text = "Start Now!";
            btnsn.BackColor = Color.FromArgb(255, 224, 192);
        }

        private void btntat_Click(object sender, EventArgs e)
        {
            Start3 s3 = new Start3();
            s3.Show();
            Hide();
            Start2player.close();
        }

    }
}
