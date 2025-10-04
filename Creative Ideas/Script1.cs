using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Creative_Ideas
{
    public partial class Script1 : Form
    {

        Timer Mytimer = new Timer();
        string p;
        public Script1()
        {
            InitializeComponent();
        }

        private void Script1_Load(object sender, EventArgs e)
        {
            ScriptPlayer.uiMode = "none";
            ScriptPlayer.windowlessVideo = true;
            ScriptPlayer.stretchToFit = true;
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            ScriptPlayer.URL = "Paint.mp4";
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

        private void tbxs_KeyDown(object sender, KeyEventArgs e)
        {
            Escapebutton(sender, e);
        }

        private void btnsave_KeyDown(object sender, KeyEventArgs e)
        {
            Escapebutton(sender, e);
        }

        private void btncancel_KeyDown(object sender, KeyEventArgs e)
        {
            Escapebutton(sender, e);
        }

        private void btnGTF_KeyDown(object sender, KeyEventArgs e)
        {
            Escapebutton(sender, e);
        }

        private void btnGTF_Click(object sender, EventArgs e)
        {
            p = "Not logged in";
            Main m = new Main(p);
            Hide();
            m.Show();
            ScriptPlayer.close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            tbxs.Text = "";
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog s = new SaveFileDialog();
                s.Filter = "All files|*.*|Text files|*.txt";
                s.FilterIndex=2;
                if (s.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(s.FileName, tbxs.Text);
                    MessageBox.Show("Saved");
                }
            }
            catch (Exception ie)
            {
                MessageBox.Show(ie.Message);
            }
        }
    }
}
