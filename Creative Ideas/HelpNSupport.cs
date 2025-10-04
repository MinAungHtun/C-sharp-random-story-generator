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
    public partial class HelpNSupport : Form
    {
        public HelpNSupport()
        {
            InitializeComponent();
            MessageBox.Show("To generate random names, traits and many more randoms, plz read the a little bit out of the box Use article included in the documentation. Brief hint:When working with database, database only put constraints on datatypes and lengths. So as long as a text field is text and number field is number, anything within the app's algorithm context can be done");
        }

        private void HelpNSupport_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.WindowState = FormWindowState.Normal;
        }

        private void HelpNSupport_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.gmail.com");  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Encapsulation en = new Encapsulation();
            en.Comm = textBox1.Text;
            MessageBox.Show("The comment="+en.Comm+";was submitted succcessfully to the developer. Thank you :)");
            textBox1.Text = "";
        }
    }
}
