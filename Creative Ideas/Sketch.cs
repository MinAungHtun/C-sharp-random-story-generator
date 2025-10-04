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
using System.Drawing.Imaging;
namespace Creative_Ideas
{
    public partial class Sketch : Form
    {
        Graphics g;
        string q;
        int size = 10;
        int erase;
       
        Pen p = new Pen(Color.Black, 10);
        Point sp = new Point(0, 0);
        Point ep = new Point(0, 0);
        Color c;

        int k = 0;
        int cX, cY, x, y, dX, dY;
        public Sketch()
        {
            InitializeComponent();
            c = Color.Black;
            pnlacc.Visible = false;
           
        }

        private void Sketch_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            
        }

      

        private void SS_MouseClick(object sender, MouseEventArgs e)
        {
            if (k == 1)
            {
                x = e.X;
                y = e.Y;
                dX = e.X - cX;
                dY = e.Y - cY;
                if (erase == 1)
                {
                    g.DrawLine(new Pen(Color.White, size), sp, ep);
                }
                else
                {
                    g.DrawLine(new Pen(c, size), sp, ep);
                }
            }    
        }

        private void SS_MouseDown(object sender, MouseEventArgs e)
        {
            sp = e.Location;
            if (e.Button == MouseButtons.Left)
            {
                k = 1;
            }
            cX = e.X;
            cY = e.Y;
        }

        private void SS_MouseUp(object sender, MouseEventArgs e)
        {

            k = 0;
        }

        private void SS_MouseMove_1(object sender, MouseEventArgs e)
        {

            if (k == 1)
            {
                ep = e.Location;
                g = SS.CreateGraphics();
                x = e.X;
                y = e.Y;
                if (erase == 1)
                {
                    g.DrawLine(new Pen(Color.White, size), sp, ep);
                }
                else
                {
                    g.DrawLine(new Pen(c, size), sp, ep);
                }
            }
            sp = ep;
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
        

        private void Sketch_KeyDown(object sender, KeyEventArgs e)
        {
            Escapebutton(sender, e);
            
        }

        private void lblplus_Click(object sender, EventArgs e)
        {
            lblplus.Hide();
            pnlacc.Visible = true;
        }

        private void btnsave_KeyDown(object sender, KeyEventArgs e)
        {
            Escapebutton(sender, e);
        }

        private void btnclear_KeyDown(object sender, KeyEventArgs e)
        {
            Escapebutton(sender, e);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "All files|*.*|BMPfiles|*.bmp";
                save.FilterIndex = 2;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bitmap = DrawPBtoBitmap(SS);
                    bitmap.Save(save.FileName);
                    MessageBox.Show("Saved Successfully");
                }
            }
            catch (Exception ie)
            {
                MessageBox.Show(ie.Message);
            }
        }
        private static Bitmap DrawPBtoBitmap(Control c)
        {
            Bitmap bitmap = new Bitmap(c.Width, c.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            Rectangle rect = c.RectangleToScreen(c.ClientRectangle);
            graphics.CopyFromScreen(rect.Location, Point.Empty, c.Size);
            return bitmap;
        }
        private void btneraser_Click(object sender, EventArgs e)
        {
            erase = 1;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            SS.Image = null;
            SS.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            erase = 0;
        }

        private void btneraser_KeyDown(object sender, KeyEventArgs e)
        {
            Escapebutton(sender, e);
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            Escapebutton(sender, e);
        }

        private void lblplus_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void lblplus_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnGTF_KeyDown(object sender, KeyEventArgs e)
        {
            Escapebutton(sender, e);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Orange;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void btneraser_MouseHover(object sender, EventArgs e)
        {
            btneraser.FlatStyle = FlatStyle.Flat;
        }

        private void btneraser_MouseLeave(object sender, EventArgs e)
        {
            btneraser.FlatStyle = FlatStyle.Popup;
        }

        private void btnGTF_Click(object sender, EventArgs e)
            {
                q = "Not logged in";
                Main mz = new Main(q);
                mz.Show();
                Hide();
           
            }

        private void SS_Click(object sender, EventArgs e)
        {

        }
    }
}
