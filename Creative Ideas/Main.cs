using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Objects;
using Cudafy.Compilers;
using Cudafy.Translator;
using Cudafy.Host;
using System.Runtime.InteropServices;
using WMPLib;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.IO;


namespace Creative_Ideas
{
    public partial class Main : Form
    {
        public int YYU;
        public int Ck,count,tc,pc,ac,mc,cc,num,nee,ncc,nmm,nuu,z,x;
        public int ho = 1;
        public int sh = 1;
        public string Theme, Character, Place, Motive, Action;
        TriedCUDAButInconsistent tCUDA = new TriedCUDAButInconsistent();
        Timer Mytimer = new Timer();
        int a, b,c;
        public String path;
        int bb;
        public Main(string Str_Value)
        {
            InitializeComponent();
            textBox1.Text = Str_Value;
            MessageBox.Show("Please log in with the default administrator account Username=Cryuff Password=99 (careful abou the caps) if this is the first time of use to enable full features (editing of contents). Log in by clicking the setting icon in the interface and the switching the account. For new users in which this app is not run for the first time, the authoritive administrator might have changed the default account's password (it is needed to be done so as this message will appear everytime the programme is run) so use your own account or contact him/her");
           
            vali();
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
                    pictureBox2.Image = Creative_Ideas.Properties.Resources.Kobe;
                }
                else 
                {
                    pictureBox2.Image = Creative_Ideas.Properties.Resources.Neymar;
                }
            
           
        }
        private void Main_Load(object sender, EventArgs e)
        {
           this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            VideoPlayer.URL = "Main.mp4";
           
        }
        public void GetID1()
        {

            SqlCeConnection con = new SqlCeConnection();
            con.ConnectionString = "Data Source=CreativeIdeas.sdf;Persist Security Info=False;";
            String Query = "Select ThemeID from Charact where Charname='"+cbx5.Text+"';";
            SqlCeCommand cmd = new SqlCeCommand(Query, con);
            SqlCeDataReader Dreader;
            try
            {
                con.Open();
                Dreader = cmd.ExecuteReader();
                while (Dreader.Read())
                {
                    a = Dreader.GetInt32(0);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void GetID3()
        {

            SqlCeConnection con = new SqlCeConnection();
            con.ConnectionString = "Data Source=CreativeIdeas.sdf;Persist Security Info=False;";
            String Query = "Select ThemeID from Theme where ThemeName='" + cbx1.Text + "';";
            SqlCeCommand cmd = new SqlCeCommand(Query, con);
            SqlCeDataReader Dreader;
            try
            {
                con.Open();
                Dreader = cmd.ExecuteReader();
                while (Dreader.Read())
                {
                    c= Dreader.GetInt32(0);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void GetID2()
        {

            SqlCeConnection con = new SqlCeConnection();
            con.ConnectionString = "Data Source=CreativeIdeas.sdf;Persist Security Info=False;";
            String Query = "Select ThemeID from Place where PlaceName='" + cbx4.Text + "';";
            SqlCeCommand cmd = new SqlCeCommand(Query, con);
            SqlCeDataReader Dreader;
            try
            {
                con.Open();
                Dreader = cmd.ExecuteReader();
                while (Dreader.Read())
                {
                     b= Dreader.GetInt32(0);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
        public void pbx3fill()
        {
            
            try
            {
                SqlCeConnection con = new SqlCeConnection();
                con.ConnectionString = "Data Source=CreativeIdeas.sdf;Persist Security Info=False;";
                con.Open();
                String Query = "Select Img from Charact where Charname='" + cbx5.Text + "';";
                SqlCeCommand sqlCmd = new SqlCeCommand (Query, con);
                SqlCeDataAdapter sqlDA = new SqlCeDataAdapter(sqlCmd);
                DataSet ds = new DataSet();
                sqlDA.Fill(ds, "Charact");
                int c = ds.Tables["Charact"].Rows.Count;

                if (c > 0)
                {   
                    Byte[] byteImg = new Byte[0];
                    byteImg = (Byte[])(ds.Tables["Charact"].Rows[c - 1]["Img"]);
                    MemoryStream stmImg = new MemoryStream(byteImg);
                    pbx3.Image = Image.FromStream(stmImg);
                }
                con.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        public void pbx4fill()
        {

            try
            {
                SqlCeConnection con = new SqlCeConnection();
                con.ConnectionString = "Data Source=CreativeIdeas.sdf;Persist Security Info=False;";
                con.Open();
                String Query = "Select IM from Place where Placename='" + cbx4.Text + "';";
                SqlCeCommand sqlCmd = new SqlCeCommand(Query, con);
                SqlCeDataAdapter sqlDA = new SqlCeDataAdapter(sqlCmd);
                DataSet ds = new DataSet();
                sqlDA.Fill(ds, "Place");
                int c = ds.Tables["Place"].Rows.Count;

                if (c > 0)
                {
                    Byte[] byteImg = new Byte[0];
                    byteImg = (Byte[])(ds.Tables["Place"].Rows[c - 1]["IM"]);
                    MemoryStream stmImg = new MemoryStream(byteImg);
                    pbx4.Image = Image.FromStream(stmImg);
                }
                con.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        public void cbx1fill()
        {
            SqlCeConnection con = new SqlCeConnection();
            con.ConnectionString = "Data Source=CreativeIdeas.sdf;Persist Security Info=False;";
            String Query = "Select * from Theme;";
            SqlCeCommand cmd = new SqlCeCommand(Query, con);
            SqlCeDataReader Dreader;
            try
            {
                con.Open();
                Dreader = cmd.ExecuteReader();
                while (Dreader.Read())
                {
                    String tname = Dreader["ThemeName"].ToString();
                    cbx1.Items.Add(tname);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void cbx5fill()
        {
            SqlCeConnection con = new SqlCeConnection();
            con.ConnectionString = "Data Source=CreativeIdeas.sdf;Persist Security Info=False;";
            String Query = "Select * from Charact;";
            SqlCeCommand cmd = new SqlCeCommand(Query,con);
            SqlCeDataReader Dreader;
            try
            {
                con.Open();
                Dreader = cmd.ExecuteReader();
                while(Dreader.Read())
                {
                    String tname= Dreader["Charname"].ToString();
                    cbx5.Items.Add(tname);
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void cbx4fill()
        {
            SqlCeConnection con = new SqlCeConnection();
            con.ConnectionString = "Data Source=CreativeIdeas.sdf;Persist Security Info=False;";
            String Query = "Select * from Place;";
            SqlCeCommand cmd = new SqlCeCommand(Query, con);
            SqlCeDataReader Dreader;
            try
            {
                con.Open();
                Dreader = cmd.ExecuteReader();
                while (Dreader.Read())
                {
                    String tname = Dreader["PlaceName"].ToString();
                    cbx4.Items.Add(tname);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void cbx3fill()
        {
            SqlCeConnection con = new SqlCeConnection();
            con.ConnectionString = "Data Source=CreativeIdeas.sdf;Persist Security Info=False;";
            String Query = "Select * from Motive;";
            SqlCeCommand cmd = new SqlCeCommand(Query, con);
            SqlCeDataReader Dreader;
            try
            {
                con.Open();
                Dreader = cmd.ExecuteReader();
                while (Dreader.Read())
                {
                    String tname = Dreader["MotiveName"].ToString();
                    cbx3.Items.Add(tname);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void comboBox1fill()
        {
            SqlCeConnection con = new SqlCeConnection();
            con.ConnectionString = "Data Source=CreativeIdeas.sdf;Persist Security Info=False;";
            String Query = "Select * from Act;";
            SqlCeCommand cmd = new SqlCeCommand(Query, con);
            SqlCeDataReader Dreader;
            try
            {
                con.Open();
                Dreader = cmd.ExecuteReader();
                while (Dreader.Read())
                {
                    String tname = Dreader["Actionn"].ToString();
                    comboBox1.Items.Add(tname);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Setting set=new Setting(textBox1.Text);
            set.Show();
        }
       
        private void btn4_KeyDown_1(object sender, KeyEventArgs e)
        {
            Escapebutton(sender, e);
        }

        private void btn1_KeyDown(object sender, KeyEventArgs e)
        {
            Escapebutton(sender, e);
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            Escapebutton(sender, e);
        }

        private void btn3_KeyDown(object sender, KeyEventArgs e)
        {
            Escapebutton(sender, e);
        }

        private void btn2_KeyDown(object sender, KeyEventArgs e)
        {
            Escapebutton(sender, e);
        }

        private void btnaddpic_KeyDown(object sender, KeyEventArgs e)
        {
            Escapebutton(sender, e);
        }

        private void btntweak_KeyDown(object sender, KeyEventArgs e)
        {
            Escapebutton(sender, e);
        }

        private void btncombine_KeyDown(object sender, KeyEventArgs e)
        {
            Escapebutton(sender, e);
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            Escapebutton(sender, e);
        }

        private void tbxsetting_KeyDown(object sender, KeyEventArgs e)
        {
            Escapebutton(sender, e);
        }

        private void btnClearAll_KeyDown(object sender, KeyEventArgs e)
        {
            Escapebutton(sender, e);
        }

        private void tbx5_KeyDown(object sender, KeyEventArgs e)
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

        private void btnanimate_KeyDown(object sender, KeyEventArgs e)
        {
            Escapebutton(sender, e);
        }

        private void VideoPlayer_KeyDownEvent(object sender, AxWMPLib._WMPOCXEvents_KeyDownEvent e)
        {
            
        }

        private void Main_DoubleClick(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            HelpNSupport h = new HelpNSupport();
            h.Show();
        }

        private void cbx3_KeyDown(object sender, KeyEventArgs e)
        {
            Escapebutton(sender, e);
        }

        private void cbx4_KeyDown(object sender, KeyEventArgs e)
        {
            Escapebutton(sender, e);
        }

        private void cbx5_KeyDown(object sender, KeyEventArgs e)
        {
            Escapebutton(sender, e);
        }

        private void cbx1_KeyDown(object sender, KeyEventArgs e)
        {
            Escapebutton(sender, e);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {button2
           .BackColor = Color.Yellow;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {button2
            .BackColor = Color.FromArgb(255, 224, 192);
        }

        private void btn1_MouseHover(object sender, EventArgs e)
        {btn1
            .BackColor = Color.Yellow;
        }

        private void btn1_MouseLeave(object sender, EventArgs e)
        {btn1
            .BackColor = Color.FromArgb(255, 224, 192);
        }

        private void btn4_MouseHover(object sender, EventArgs e)
        {btn4
            .BackColor = Color.Yellow;
        }

        private void btn4_MouseLeave(object sender, EventArgs e)
        {btn4
            .BackColor = Color.FromArgb(255, 224, 192);
        }

        private void btn3_MouseHover(object sender, EventArgs e)
        {btn3
            .BackColor = Color.Yellow;
        }

        private void btn3_MouseLeave(object sender, EventArgs e)
        {btn3
            .BackColor = Color.FromArgb(255, 224, 192);
        }

        private void btn2_MouseHover(object sender, EventArgs e)
        {btn2
            .BackColor = Color.Yellow;
        }

        private void btn2_MouseLeave(object sender, EventArgs e)
        {btn2
            .BackColor = Color.FromArgb(255, 224, 192);
        }

        private void btnaddpic_MouseHover(object sender, EventArgs e)
        {btnaddpic
            .BackColor = Color.Yellow;
        }

        private void btnaddpic_MouseLeave(object sender, EventArgs e)
        {btnaddpic
            .BackColor = Color.FromArgb(255, 224, 192);
        }

        private void btntweak_MouseHover(object sender, EventArgs e)
        {btntweak
            .BackColor = Color.Yellow;
        }

        private void btntweak_MouseLeave(object sender, EventArgs e)
        {btntweak
            .BackColor = Color.FromArgb(255, 224, 192);
        }

        private void btnClearAll_MouseHover(object sender, EventArgs e)
        {btnClearAll
            .BackColor = Color.Yellow;
        }

        private void btnClearAll_MouseLeave(object sender, EventArgs e)
        {btnClearAll
            .BackColor = Color.FromArgb(255, 224, 192);
        }

        private void btnanimate_MouseHover(object sender, EventArgs e)
        {btnanimate.
           BackColor = Color.Yellow;
        }

        private void btnanimate_MouseLeave(object sender, EventArgs e)
        {
            btnanimate.BackColor=
         Color.FromArgb(255, 224, 192);
        }

        private void btncancel_MouseHover(object sender, EventArgs e)
        {
            btncancel.BackColor = Color.Yellow;
        }

        private void btncancel_MouseLeave(object sender, EventArgs e)
        {
            btncancel.BackColor = Color.FromArgb(255, 224, 192);
        }

        private void btnsave_MouseHover(object sender, EventArgs e)
        {
            btnsave.BackColor = Color.Yellow;
        }

        private void btnsave_MouseLeave(object sender, EventArgs e)
        {
            btnsave.BackColor = Color.FromArgb(255, 224, 192);
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            Ck = Ck + 1;
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
                if (Ck == 1)
                {
                    if (MessageBox.Show("Pls first check whether other content editors are closed/finished or not.Make sure to complete that before clicking Yes to continue", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        Place p = new Place();
                        p.Show();

                    }
                }
                else
                {
                    Place p = new Place();
                    p.Show();
                }
            }
            else
            {
                MessageBox.Show("Access Denied! Log in first(re-run the software if you don't know how). There's a message box showing default administrator account information at the beginning of this main interface");
            }
          
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Ck = Ck + 1;
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
                if (Ck == 1)
                {
                    if (MessageBox.Show("Pls first check whether other content editors are closed/finished or not.Make sure to complete that before clicking Yes to continue", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        Theme t = new Theme();
                        t.Show();
                    }
                }
                else
                {
                    Theme t = new Theme();
                    t.Show();
                }
            }
            else 
            {
                MessageBox.Show("Access Denied! Log in first(re-run the software if you don't know how). There's a message box showing default administrator account information at the beginning of this main interface");
            }
            
        }

        private void btn4_Click(object sender, EventArgs e)
        {

            Ck = Ck + 1;
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
                if (Ck == 1)
                {
                    if (MessageBox.Show("Pls first check whether other content editors are closed/finished or not.Make sure to complete that before clicking Yes to continue", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        Character c = new Character();
                        c.Show();
                    }
                }
                else
                {
                    Character c = new Character();
                    c.Show();
                }
            }
            else
            {
                MessageBox.Show("Access Denied! Log in first(re-run the software if you don't know how). There's a message box showing default administrator account information at the beginning of this main interface");
            }
            
            
          
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Ck = Ck + 1;
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
                if (Ck == 1)
                {
                    if (MessageBox.Show("Pls first check whether other contents editors are closed/finished or not.Make sure to complete that before clicking Yes to continue", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        Motive m = new Motive();
                        m.Show();
                    }
                }
                else
                {
                    Motive m = new Motive();
                    m.Show();
                }
            }
            else
            {
                MessageBox.Show("Access Denied! Log in first(re-run the software if you don't know how). There's a message box showing default administrator account information at the beginning of this main interface");
            }
            
            
           
        }

        private void btnPaint_Click(object sender, EventArgs e)
        {
            Sketch s = new Sketch();
            s.Show();
            Hide();
            VideoPlayer.close();
        }

        private void cbx1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VideoPlayer_Enter(object sender, EventArgs e)
        {

        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            Escapebutton(sender, e);
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            Escapebutton(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ck = Ck + 1;
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
            if (bb == 1 )
            {

                if (Ck == 1)
                {
                    if (MessageBox.Show("Pls first check whether other content editor are closed/finished or not.Make sure to complete that before clicking Yes to continue", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        Action m = new Action();
                        m.Show();
                    }
                }
                else
                {
                    Action m = new Action();
                    m.Show();
                }
            }
            else
            {
                MessageBox.Show("Access Denied! Log in first(re-run the software if you don't know how). There's a message box showing default administrator account information at the beginning of this main interface");
            }
            
            
          
        }

        private void btnPaint_MouseLeave(object sender, EventArgs e)
        {
            btnPaint.BackColor = Color.FromArgb(255, 224, 192);
        }

        private void btnPaint_MouseHover(object sender, EventArgs e)
        {
            btnPaint.BackColor = Color.Yellow;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Yellow;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(255, 224, 192);
        }

        private void btnaddpic_Click(object sender, EventArgs e)
        {
            GetID1();
            GetID2();
            GetID3();
            if (a == b && b==c)
            {
                tbx5.Text = cbx1.Text +"---"+ cbx3.Text +"---"+ cbx4.Text +"---"+ cbx5.Text +"---"+ comboBox1.Text;
            }
            else 
            {
                MessageBox.Show("The selected items (character & setting) are not under the same theme");
            }
        }

        private void cbx5_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void cbx5_TextChanged(object sender, EventArgs e)
        {
            pbx3fill();
        }

        private void cbx4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbx4_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void cbx4_TextChanged(object sender, EventArgs e)
        {
            pbx4fill();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            tbx5.Text = "";
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            YYU = YYU + 1;
            if (YYU == 1)
            {
                MessageBox.Show("I'll write 10 commercial apps free for you if a western movie(the real one) wins an oscar with a leading actor named something like &%62yixz. It might be possible someday there's a chance/");
            }
            try 
            {
                SaveFileDialog s = new SaveFileDialog();
                s.Filter = "All files|*.*|Text files|*.txt";
                s.FilterIndex = 2;
                if (s.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(s.FileName, tbx5.Text);
                    MessageBox.Show("Saved");
                }
            }
            catch (Exception ie)
            {
                MessageBox.Show(ie.Message);
            }
        }

        private void btnanimate_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog s = new OpenFileDialog();
                s.Filter = "All files|*.*|Mp4s|*.mp4|WAVS|*.wavs";
                s.InitialDirectory = "C:/Videos/";
                if (s.ShowDialog() == DialogResult.OK)
                {
                    path = s.FileName;
                    Animation j = new Animation(path);
                    j.Show();
                }
            }
            catch (Exception ie)
            {
                MessageBox.Show(ie.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Setting s = new Setting(textBox1.Text);
            s.Show();
            Hide();
            VideoPlayer.close();
        }

        private void btntweak_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
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
                    tbx5.Text = Theme + "---" + Character + "---" + Place + "---" + Motive + "---" + Action;
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
                        tbx5.Text = Theme + "---" + Character + "---" + Place + "---" + Motive + "---" + Action;
                    }
                }
            }
            catch (Exception ie)
            {
                MessageBox.Show(ie.Message+"The app is closing");
                this.Close();
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry for your inconvenience. It is an error due to the limited deployment time. User Customization will be available on next update");
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            pbx3.Image = null;
            pbx4.Image = null;
            tbx5.Text = "";
            cbx1.Text = "";
            cbx3.Text = "";
            cbx4.Text = "";
            cbx5.Text = "";
            comboBox1.Text = "";
        }

        private void cbx5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbx1_MouseClick(object sender, MouseEventArgs e)
        {
            cbx1.Items.Clear();
            cbx1fill();
        }

        private void cbx5_MouseClick(object sender, MouseEventArgs e)
        {
            cbx5.Items.Clear();
            cbx5fill();
        }

        private void cbx4_MouseClick(object sender, MouseEventArgs e)
        {
            cbx4.Items.Clear();
            cbx4fill();
        }

        private void cbx3_MouseClick(object sender, MouseEventArgs e)
        {
            cbx3.Items.Clear();
            cbx3fill();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1fill();
        }
        
    }
}

    
