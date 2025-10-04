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
using System.IO;
namespace Creative_Ideas
{
    public partial class Login : Form
    {
        string  password;
       
        int bb;
        public Login(string tt)
        {
            InitializeComponent();
            textBox1.Text = tt;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.WindowState = FormWindowState.Normal;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCeConnection con = new SqlCeConnection();
                con.ConnectionString = "Data Source=CreativeIdeas.sdf;Persist Security Info=False;";
                String Query = "Select passw from Account where AccountName='" + textBox1.Text + "';";
                SqlCeCommand cmd = new SqlCeCommand(Query, con);
                SqlCeDataReader Dreader;
                try
                {
                    con.Open();
                    Dreader = cmd.ExecuteReader();
                    while (Dreader.Read())
                    {
                        password = Dreader["passw"].ToString();
                    }
                    con.Close();
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message + "The username is incorrect");
                }
                if (password == textBox2.Text)
                {
                    MessageBox.Show("Log in was successful");
                    Setting s = new Setting(textBox1.Text);
                    s.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Password or username is incorrect.Plz,Try again");
                }
            }
            catch (NullReferenceException n)
            {
                MessageBox.Show(n.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
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
                
                SqlCeConnection co = new SqlCeConnection();
                co.ConnectionString = "Data Source=CreativeIdeas.sdf;Persist Security Info=False;";
                String Qury = "Select passw from Account where AccountName='" + textBox1.Text + "';";
                SqlCeCommand cm = new SqlCeCommand(Qury, co);
                SqlCeDataReader Dreade;
                try
                {
                    co.Open();
                    Dreade = cm.ExecuteReader();
                    while (Dreade.Read())
                    {
                        password = Dreade["passw"].ToString();
                    }
                    co.Close();
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message + "The username is incorrect");
                }

                if (bb == 1 && password == textBox2.Text)
                
                {
                    Accounts ac = new Accounts();
                    ac.Show();
                }
                else 
                {
                    MessageBox.Show("Access Denied! Please check if your username and /or password is blank and make sure that it has administrative authority");
                }
            }
            catch (NullReferenceException ne)
            {
                MessageBox.Show(ne.Message+"Please enter username  to manage accounts");
            }
        }
    }
}
