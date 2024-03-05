using Microsoft.VisualBasic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace DigiScan_Track
{
    public partial class ManualInput : Form
    {

        SqlConnection conn = new SqlConnection();
        int originalArrowWidth;
        int originalArrowHeight;
        int originalexpandWidth;

        public ManualInput()
        {
            InitializeComponent();
            /*getSQLHomepage();*/

            LoadButtonImages();
        }





        /*private void getSQLHomepage()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source = Jenko\\MSSQLSERVER01; Initial Catalog=DigiTrackAndScan; Integrated Security = True;";
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM WIPTracking";
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            conn.Close();
            dataGridView1.DataSource = dt;
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {
            expandpicbox.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
        }
        private void collapsepicbox_MouseEnter_1(object sender, EventArgs e)
        {
            originalArrowWidth = collapsepicbox.Width;
            originalArrowHeight = collapsepicbox.Height;
            int newWidth = (int)(collapsepicbox.Width * 1.1);
            int newHeight = (int)(collapsepicbox.Height * 1.1);

            // Set new size
            collapsepicbox.Size = new Size(newWidth, newHeight);
        }

        private void collapsepicbox_MouseLeave(object sender, EventArgs e)
        {
            collapsepicbox.Size = new Size(originalArrowWidth, originalArrowHeight);
        }

        private void collapsepicbox_Click(object sender, EventArgs e)
        {
            originalexpandWidth = (int)manualTablepnl.ColumnStyles[0].Width;
            manualTablepnl.ColumnStyles[0].Width = 0;

            expandpicbox.Visible = true;
        }

        private void expandpicbox_Click(object sender, EventArgs e)
        {
            manualTablepnl.ColumnStyles[0].Width = originalexpandWidth;
            expandpicbox.Visible = false;
        }




        /*------------------------------------------------Repeated code in all Forms------------------------------------------------------------------*/
        //This function finds out which form page to close and which to open, and what size screen the user is working on so it can replicate this
        public static void HeaderButton(Form newForm, Form originalForm, FormWindowState windowState)
        {
            newForm.Show(); //in this case the newform would be the linked form of whichever button is clicked
            originalForm.Hide(); //Closes the previous tab so does not clog up users computer
            if (windowState == FormWindowState.Maximized) //If the user is working on a minimised screen then it stays minimised
            {
                newForm.WindowState = FormWindowState.Maximized;
            }
        }

        private void HomeAreabtn_Click(object sender, EventArgs e)
        {
            HomePage homepage = new HomePage(); //Create a new instance of the homepage to be called upon
            HeaderButton(homepage, this, this.WindowState); //open homepage, close this form, make the homepage windowstate match the current forms
        }

        private void WIPTrackerbtn_Click(object sender, EventArgs e)
        {
            WIPTracker wiptracker = new WIPTracker();
            HeaderButton(wiptracker, this, this.WindowState);
        }

        private void AgedWIPbtn_Click(object sender, EventArgs e)
        {
            AgedWIP agedwip = new AgedWIP();
            HeaderButton(agedwip, this, this.WindowState);
        }

        private void EditPartsbtn_Click(object sender, EventArgs e)
        {
            EditParts editparts = new EditParts();
            HeaderButton(editparts, this, this.WindowState);
        }

        private void ManualInputbtn_Click(object sender, EventArgs e)
        {
            ManualInput manualinput = new ManualInput();
            HeaderButton(manualinput, this, this.WindowState);
        }

        private void DisplayBoardbtn_Click(object sender, EventArgs e)
        {
            DisplayBoard displayboard = new DisplayBoard();
            HeaderButton(displayboard, this, this.WindowState);
        }

        private void LoadButtonImages()
        {
            HomeAreabtn.Image = new Bitmap(Properties.Resources.redHouse, new Size(18, 18));
            WIPTrackerbtn.Image = new Bitmap(Properties.Resources.clipboard, new Size(18, 18));
            AgedWIPbtn.Image = new Bitmap(Properties.Resources.exclamation, new Size(18, 18));
            EditPartsbtn.Image = new Bitmap(Properties.Resources.spanner, new Size(18, 18));
            ManualInputbtn.Image = new Bitmap(Properties.Resources.keyboard, new Size(18, 18));
            DisplayBoardbtn.Image = new Bitmap(Properties.Resources.Monitor, new Size(18, 18));

            HomeAreabtn.ImageAlign = ContentAlignment.MiddleRight;
            WIPTrackerbtn.ImageAlign = ContentAlignment.MiddleRight;
            AgedWIPbtn.ImageAlign = ContentAlignment.MiddleRight;
            EditPartsbtn.ImageAlign = ContentAlignment.MiddleRight;
            ManualInputbtn.ImageAlign = ContentAlignment.MiddleRight;
            DisplayBoardbtn.ImageAlign = ContentAlignment.MiddleRight;
        }

        private void hoverButton(object sender, EventArgs e)
        {
            Button hoverbtn = sender as Button;
            selectionpnl.BringToFront();
            selectionpnl.Height = hoverbtn.Height;
            selectionpnl.Top = hoverbtn.Top;
            selectionpnl.Left = hoverbtn.Left;
            hoverbtn.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void unHoverButton(object sender, EventArgs e)
        {
            Button hoverbtn = sender as Button;
            selectionpnl.SendToBack();
            hoverbtn.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}