using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace Creative_Ideas
{
    public partial class Setting : Form
    {
        int bb;
        public Setting(string tt)
        {
            InitializeComponent();
            textBox1.Text =tt;
            vali();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.WindowState = FormWindowState.Normal;
        }
        public void vali()
        {

            
            SqlCeConnection con = new SqlCeConnection();
            con.ConnectionString = "Data Source=CreativeIdeas.sdf;Persist Security Info=False;";
            String Query = "Select AccountTypeID from Account where AccountName='" + textBox1.Text + "';";
            SqlCeCommand cmd = new SqlCeCommand(Query, con);
            SqlCeDataReader Dreader;
            try
            {
                con.Open();
                Dreader = cmd.ExecuteReader();
                while (Dreader.Read())
                {
                    bb = Dreader.GetInt32(0);
                }
                con.Close();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message + "Wrong Username");
            }
            if (bb == 1)
            {
                pictureBox1.Image = Creative_Ideas.Properties.Resources.Kobe;
            }
            else
            {
                pictureBox1.Image = Creative_Ideas.Properties.Resources.Neymar;
            }


        }
        internal static void Open()
        {
            throw new NotImplementedException();
        }

        private void Setting_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login l = new Login(textBox1.Text);
            l.Show();
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry for your inconvenience. It is an error due to the limited deployment time. User Customization will be available on next update");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main m = new Main(textBox1.Text);
            Hide();
            m.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Main m = new Main(textBox1.Text);
            m.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.facebook.com/Min Aung Htun");  
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
