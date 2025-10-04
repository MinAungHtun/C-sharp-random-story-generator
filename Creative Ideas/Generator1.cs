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
using System.Data.SqlServerCe;

namespace Creative_Ideas
{
    public partial class Generator1 : Form
    {
        TriedCUDAButInconsistent tCUDA = new TriedCUDAButInconsistent();
        string p;
        public int count, tc, pc, ac, mc, cc, num, nee, ncc, nmm, nuu, z, x;
        public int ho = 1;
        public int sh = 1;
        public string Theme, Character, Place, Motive, Action;
        Timer Mytimer = new Timer();
        public Generator1()
        {
            InitializeComponent();
        }

        private void Generator1_Load(object sender, EventArgs e)
        {
            Genplayer.uiMode = "none";
            Genplayer.windowlessVideo = true;
            Genplayer.stretchToFit = true;
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            Genplayer.URL = "Scripting.mp4";
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

        private void btnGRS_KeyDown(object sender, KeyEventArgs e)
        {
            Escapebutton(sender, e);
        }

        private void btnGTF_KeyDown(object sender, KeyEventArgs e)
        {
            Escapebutton(sender, e);

        }

        private void tbxS_KeyDown(object sender, KeyEventArgs e)
        {
            Escapebutton(sender, e);

        }

        private void btnGTF_MouseHover(object sender, EventArgs e)
        {
            btnGTF.Text = "For editing!";
            btnGTF.BackColor = Color.OrangeRed;
        }

        private void btnGTF_MouseLeave(object sender, EventArgs e)
        {
            btnGTF.Text = "Go to full";
            btnGTF.BackColor = Color.FromArgb(255, 224, 192);
        }

        private void btnGTF_Click(object sender, EventArgs e)
        {
            p = "Not logged in";
            Main m = new Main(p);
            Hide();
            m.Show();
            Genplayer.close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog s = new SaveFileDialog();
                s.Filter = "All files|*.*|Text files|*.txt";
                s.FilterIndex = 2;
                if (s.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(s.FileName, tbxS.Text);
                    MessageBox.Show("Saved");
                }
            }
            catch (Exception ie)
            {
                MessageBox.Show(ie.Message);
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.OrangeRed;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(255, 224, 192);
        }

        private void btnGRS_Click(object sender, EventArgs e)
        {
            try
            {
                if (count == 0)
                {
                    count = count + 1;
                }
                try
                {

                    SqlCeConnection con = new SqlCeConnection("Data Source=CreativeIdeas.sdf;Persist Security Info=False;");
                    con.Open();
                    String Query = "SELECT COUNT(*)from Theme;";
                    SqlCeCommand cmd = new SqlCeCommand(Query, con);
                    tc = (int)cmd.ExecuteScalar();
                    con.Close();
                    
                
                }
                catch (Exception)
                {

                }

                try
                {

                    SqlCeConnection con = new SqlCeConnection("Data Source=CreativeIdeas.sdf;Persist Security Info=False;");
                    con.Open();
                    String Query = "SELECT COUNT(*)from Charact ;";
                    SqlCeCommand cmd = new SqlCeCommand(Query, con);
                    cc = (int)cmd.ExecuteScalar();
                    con.Close();
                    
                
                }
                catch (Exception)
                {
                }
                try
                {

                    SqlCeConnection con = new SqlCeConnection("Data Source=CreativeIdeas.sdf;Persist Security Info=False;");
                    con.Open();
                    String Query = "SELECT COUNT(*)from Place;";
                    SqlCeCommand cmd = new SqlCeCommand(Query, con);
                    pc = (int)cmd.ExecuteScalar();
                    con.Close();
                    
                
                }
                catch (Exception)
                {
                }
                try
                {

                    SqlCeConnection con = new SqlCeConnection("Data Source=CreativeIdeas.sdf;Persist Security Info=False;");
                    con.Open();
                    String Query = "SELECT COUNT(*)from Motive;";
                    SqlCeCommand cmd = new SqlCeCommand(Query, con);
                    mc = (int)cmd.ExecuteScalar();
                    con.Close();
                    
                
                }
                catch (Exception)
                {
                }
                try
                {
                         SqlCeConnection con = new SqlCeConnection("Data Source=CreativeIdeas.sdf;Persist Security Info=False;");
                        con.Open();
                        String Query = "SELECT COUNT(*)from Act;";
                        SqlCeCommand cmd = new SqlCeCommand(Query, con);
                   
                  
                    

                        ac = (int)cmd.ExecuteScalar();
                    

                    con.Close();
                    
                }
                catch (Exception)
                {
                }
                random();


                if (count < tc)
                {
                    count = count + 1;
                }
                else if (count >= tc)
                {
                    count = 0;
                }
            }
            catch (Exception ie)
            {
                MessageBox.Show(ie.Message);
            }

        }
        public void random()
        {
            try
            {
                num = tCUDA.G1(count, tc + 1);
                nee = tCUDA.G2(1, ac + 1);

                nuu = tCUDA.G3(1, cc + 1);
                ncc = tCUDA.G4(1, mc + 1);

                nmm = tCUDA.G5(1, pc + 1);
                try
                {
                    SqlCeConnection con = new SqlCeConnection();
                    con.ConnectionString = "Data Source=CreativeIdeas.sdf;Persist Security Info=False;";
                    String Query = "Select ThemeID from Place where PlaceID=" + nmm + ";";
                    SqlCeCommand cmd = new SqlCeCommand(Query, con);
                    SqlCeDataReader Dreader;
                    try
                    {
                        con.Open();
                        Dreader = cmd.ExecuteReader();
                        while (Dreader.Read())
                        {
                            z = Dreader.GetInt32(0);
                        }

                        con.Close();
                    }
                    catch (InvalidOperationException)
                    {
                    }
                }
                catch (Exception)
                {
                }
                try
                {
                    SqlCeConnection con = new SqlCeConnection();
                    con.ConnectionString = "Data Source=CreativeIdeas.sdf;Persist Security Info=False;";
                    String Query = "Select ThemeID from Charact where CharID=" + nuu + ";";
                    SqlCeCommand cmd = new SqlCeCommand(Query, con);
                    SqlCeDataReader Dreader;
                    try
                    {
                        con.Open();
                        Dreader = cmd.ExecuteReader();
                        while (Dreader.Read())
                        {
                            x = Dreader.GetInt32(0);
                        }

                        con.Close();
                    }
                    catch (InvalidOperationException)
                    {
                    }
                }
                catch (Exception)
                {
                }
                try
                {
                    SqlCeConnection con = new SqlCeConnection();
                    con.ConnectionString = "Data Source=CreativeIdeas.sdf;Persist Security Info=False;";
                    String Query = "Select * from Charact where CharID=" + nuu + ";";
                    SqlCeCommand cmd = new SqlCeCommand(Query, con);
                    SqlCeDataReader Dreader;
                    try
                    {
                        con.Open();
                        Dreader = cmd.ExecuteReader();
                        while (Dreader.Read())
                        {
                            Character = Dreader["Charname"].ToString();
                        }

                        con.Close();
                    }
                    catch (InvalidOperationException)
                    {
                    }
                }
                catch (Exception ie)
                {
                    MessageBox.Show(ie.Message);
                }
                try
                {
                    SqlCeConnection con = new SqlCeConnection();
                    con.ConnectionString = "Data Source=CreativeIdeas.sdf;Persist Security Info=False;";
                    String Query = "Select * from Place where PlaceID=" + nmm + ";";
                    SqlCeCommand cmd = new SqlCeCommand(Query, con);
                    SqlCeDataReader Dreader;
                    try
                    {
                        con.Open();
                        Dreader = cmd.ExecuteReader();
                        while (Dreader.Read())
                        {
                            Place = Dreader["PlaceName"].ToString();
                        }

                        con.Close();
                    }
                    catch (InvalidOperationException)
                    {
                    }
                }
                catch (Exception)
                {
                }
                try
                {
                    SqlCeConnection con = new SqlCeConnection();
                    con.ConnectionString = "Data Source=CreativeIdeas.sdf;Persist Security Info=False;";
                    String Query = "Select * from Theme where ThemeID=" + num + ";";
                    SqlCeCommand cmd = new SqlCeCommand(Query, con);
                    SqlCeDataReader Dreader;
                    try
                    {
                        con.Open();
                        Dreader = cmd.ExecuteReader();
                        while (Dreader.Read())
                        {
                            Theme = Dreader["ThemeName"].ToString();
                        }

                        con.Close();
                    }
                    catch (InvalidOperationException)
                    {
                    }
                }
                catch (Exception)
                {
                }
                try
                {
                    SqlCeConnection con = new SqlCeConnection();
                    con.ConnectionString = "Data Source=CreativeIdeas.sdf;Persist Security Info=False;";
                    String Query = "Select * from Act where ActionID=" + nee + ";";
                    SqlCeCommand cmd = new SqlCeCommand(Query, con);
                    SqlCeDataReader Dreader;
                    try
                    {
                        con.Open();
                        Dreader = cmd.ExecuteReader();
                        while (Dreader.Read())
                        {
                            Action = Dreader["Actionn"].ToString();
                        }

                        con.Close();
                    }
                    catch (InvalidOperationException)
                    {
                    }
                }
                catch (Exception)
                {
                }
                try
                {
                    SqlCeConnection con = new SqlCeConnection();
                    con.ConnectionString = "Data Source=CreativeIdeas.sdf;Persist Security Info=False;";
                    String Query = "Select * from Motive where MotiveID=" + ncc + ";";
                    SqlCeCommand cmd = new SqlCeCommand(Query, con);
                    SqlCeDataReader Dreader;
                    try
                    {
                        con.Open();
                        Dreader = cmd.ExecuteReader();
                        while (Dreader.Read())
                        {
                            Motive = Dreader["MotiveName"].ToString();
                        }

                        con.Close();
                    }
                    catch (InvalidOperationException)
                    {
                    }
                }
                catch (Exception)
                {
                }
                if (x == num && z == num)
                {
                    tbxS.Text = Theme + "---" + Character + "---" + Place + "---" + Motive + "---" + Action;
                }
                else if (x != num || z != num)
                {
                    while (ho < cc + 1 && x != num)
                    {

                        try
                        {
                            SqlCeConnection con = new SqlCeConnection();
                            con.ConnectionString = "Data Source=CreativeIdeas.sdf;Persist Security Info=False;";
                            String Query = "Select * from Charact where CharID=" + ho + ";";
                            SqlCeCommand cmd = new SqlCeCommand(Query, con);
                            SqlCeDataReader Dreader;
                            try
                            {
                                con.Open();
                                Dreader = cmd.ExecuteReader();
                                while (Dreader.Read())
                                {
                                    Character = Dreader["Charname"].ToString();
                                }

                                con.Close();
                            }
                            catch (InvalidOperationException)
                            {
                            }
                        }
                        catch (Exception)
                        {
                        }
                        try
                        {
                            SqlCeConnection con = new SqlCeConnection();
                            con.ConnectionString = "Data Source=CreativeIdeas.sdf;Persist Security Info=False;";
                            String Query = "Select ThemeID from Charact where Charname='" + Character + "';";
                            SqlCeCommand cmd = new SqlCeCommand(Query, con);
                            SqlCeDataReader Dreader;
                            try
                            {
                                con.Open();
                                Dreader = cmd.ExecuteReader();
                                while (Dreader.Read())
                                {
                                    x = Dreader.GetInt32(0);
                                }

                                con.Close();
                            }
                            catch (InvalidOperationException)
                            {
                            }
                        }
                        catch (Exception)
                        {
                        }
                        ho = ho + 1;
                        if (ho > cc)
                        {
                            ho = 1;
                        }
                    }

                    while (sh < pc + 1 && z != num)
                    {

                        try
                        {
                            SqlCeConnection con = new SqlCeConnection();
                            con.ConnectionString = "Data Source=CreativeIdeas.sdf;Persist Security Info=False;";
                            String Query = "Select * from Place where PlaceID=" + sh + ";";
                            SqlCeCommand cmd = new SqlCeCommand(Query, con);
                            SqlCeDataReader Dreader;
                            try
                            {
                                con.Open();
                                Dreader = cmd.ExecuteReader();
                                while (Dreader.Read())
                                {
                                    Place = Dreader["PlaceName"].ToString();
                                }

                                con.Close();
                            }
                            catch (InvalidOperationException)
                            {
                            }
                        }
                        catch (Exception)
                        {
                        }
                        try
                        {
                            SqlCeConnection con = new SqlCeConnection();
                            con.ConnectionString = "Data Source=CreativeIdeas.sdf;Persist Security Info=False;";
                            String Query = "Select ThemeID from Place where PlaceName='" + Place + "';";
                            SqlCeCommand cmd = new SqlCeCommand(Query, con);
                            SqlCeDataReader Dreader;
                            try
                            {
                                con.Open();
                                Dreader = cmd.ExecuteReader();
                                while (Dreader.Read())
                                {
                                    z = Dreader.GetInt32(0);
                                }
                                con.Close();
                            }
                            catch (InvalidOperationException)
                            {
                            }
                        }
                        catch (Exception)
                        {
                        }
                        sh = sh + 1;
                        if (sh > pc)
                        {
                            sh = 1;
                        }
                    }
                    if (x == num && z == num)
                    {
                        tbxS.Text = Theme + "---" + Character + "---" + Place + "---" + Motive + "---" + Action;
                    }
                }
            }
            catch (Exception ie)
            {
                MessageBox.Show(ie.Message+"The app is closing");
                this.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbxS.Text = "";
        }

        private void btnGRS_MouseHover(object sender, EventArgs e)
        {
            btnGRS.BackColor = Color.OrangeRed;
        
        }

        private void btnGRS_MouseLeave(object sender, EventArgs e)
        {

            btnGRS.BackColor = Color.FromArgb(255, 224, 192);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.OrangeRed;
        
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {

            button2.BackColor = Color.FromArgb(255, 224, 192);
        }
    }
}
