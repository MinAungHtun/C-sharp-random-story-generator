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
    public partial class Place : Form
    {
        
        public Place()
        {
            InitializeComponent();

        }

        private void Place_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'creativeIdeasDataSet2.Theme' table. You can move, or remove it, as needed.
            this.themeTableAdapter.Fill(this.creativeIdeasDataSet2.Theme);
            // TODO: This line of code loads data into the 'creativeIdeasDataSet2.Theme' table. You can move, or remove it, as needed.
            this.themeTableAdapter.Fill(this.creativeIdeasDataSet2.Theme);
            
            // TODO: This line of code loads data into the 'creativeIdeasDataSet2.Place' table. You can move, or remove it, as needed.
            this.placeTableAdapter.Fill(this.creativeIdeasDataSet2.Place);
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.WindowState = FormWindowState.Normal;
            MessageBox.Show("If you have a problem, go see help. If your cursor is unmovable, fill a textbox or change the text you are entering in the form of a number (textbox only accepts number)");
       
        }

        private void btncancel_Leave(object sender, EventArgs e)
        {

        }

        private void Place_Leave(object sender, EventArgs e)
        {
          
        }

       
        private void placeBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.placeBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.creativeIdeasDataSet2);
                
            }
            catch (Exception ie)
            {
                MessageBox.Show("There's an error in the data that you've just entered" + ie.Message + "\t" + "\t" + "\t" + "\t" + "Too big of the image or text size or wrong ThemeID. The error is marked with red warning signal in the data list");
            }

        }
        public void open()
        {
            try
            {
                OpenFileDialog f = new OpenFileDialog();
                f.InitialDirectory = "C:/Pictures/";
                f.Filter = "All files|*.*|JPEGs|*.jpg|Bitmaps|*.bmp|GIFs|*.gif|PNGS|*.png";
                f.FilterIndex = 2;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    iMPictureBox.Image = Image.FromFile(f.FileName);
                    iMPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    iMPictureBox.BorderStyle = BorderStyle.FixedSingle;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnap_Click(object sender, EventArgs e)
        {
            open();
        }

        private void btnsavenow_Click(object sender, EventArgs e)
        {

            this.placeBindingSource.AddNew();
            
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.placeBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.creativeIdeasDataSet2);
               
            }
            catch (Exception ie)
            {
                MessageBox.Show("There's an error in the data that you've just entered" + ie.Message + "\t" + "\t" + "\t" + "\t" + "Too big of the image or text size or wrong ThemeID. The error is marked with red warning signal in the data list");
            }
        
        }

        private void btncancel_Click(object sender, EventArgs e)
        {

            this.placeBindingSource.RemoveCurrent();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

            MessageBox.Show("IDs only allow numbers, both for other values and be careful about the image size. Watch the error message for more details. 1.To add new items,click on the last row in the data list > click add neww > enter new data> save. 2.To modify existing items, click on the row in the data list you want to modify > modify as desire> click modify. 3.To delete an existing data, click on the row of data you wish to delete > click delete. The buttons work similarly with plus button>add new, cross button> delete, floppy disk button>save. Arrows to navigate through the datalist should the database gets enormously large");
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            iMPictureBox.Image = null;
        }
    }
}
