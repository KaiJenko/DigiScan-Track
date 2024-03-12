using System.Data.SqlClient;


namespace DigiScan_Track
{
    public partial class HomePage : Form
    {

        SqlConnection conn = new SqlConnection();
        int originalArrowWidth;
        int originalArrowHeight;
        int originalexpandWidth;

        public HomePage()
        {
            InitializeComponent();
            /*getSQLHomepage();*/
            LoadButtonImages();

        }


        /*private void getSQLHomepage()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source = Jenko\\MSSQLSERVER01; Initial Catalog=DigiTrackAndScan; Integrated Security = True;"
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
            currentPageHighlight();
            this.InnerBodypnl.Controls.Clear();
            HomePageShortcuts homepageshortcut = new HomePageShortcuts { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            homepageshortcut.FormBorderStyle = FormBorderStyle.None;
            this.InnerBodypnl.Controls.Add(homepageshortcut);
            homepageshortcut.Show();

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
            this.InnerBodypnl.Controls.Clear();
            HomePageShortcuts homepageshortcut = new HomePageShortcuts { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            homepageshortcut.FormBorderStyle = FormBorderStyle.None;
            this.InnerBodypnl.Controls.Add(homepageshortcut);
            homepageshortcut.Show();
        }

        private void WIPTrackerbtn_Click(object sender, EventArgs e)
        {
            this.InnerBodypnl.Controls.Clear();
            WIPTracker wiptracker = new WIPTracker() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            wiptracker.FormBorderStyle = FormBorderStyle.None;
            this.InnerBodypnl.Controls.Add(wiptracker);
            wiptracker.Show();
        }

        private void AgedWIPbtn_Click(object sender, EventArgs e)
        {
            this.InnerBodypnl.Controls.Clear();
            AgedWIP agedwip = new AgedWIP() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            agedwip.FormBorderStyle = FormBorderStyle.None;
            this.InnerBodypnl.Controls.Add(agedwip);
            agedwip.Show();
        }

        private void EditPartsbtn_Click(object sender, EventArgs e)
        {
            this.InnerBodypnl.Controls.Clear();
            EditParts editparts = new EditParts() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            editparts.FormBorderStyle = FormBorderStyle.None;
            this.InnerBodypnl.Controls.Add(editparts);
            editparts.Show();
        }

        private void ManualInputbtn_Click(object sender, EventArgs e)
        {
            this.InnerBodypnl.Controls.Clear();
            HomePage manualinput = new HomePage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            manualinput.FormBorderStyle = FormBorderStyle.None;
            this.InnerBodypnl.Controls.Add(manualinput);
            manualinput.Show();
        }

        private void DisplayBoardbtn_Click(object sender, EventArgs e)
        {
            this.InnerBodypnl.Controls.Clear();
            DisplayBoard displayboard = new DisplayBoard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            displayboard.FormBorderStyle = FormBorderStyle.None;
            this.InnerBodypnl.Controls.Add(displayboard);
            displayboard.Show();
        }

        private void LoadButtonImages()
        {
            string[] PageButtons = { "HomeAreabtn", "WIPTrackerbtn", "AgedWIPbtn", "EditPartsbtn", "ManualInputbtn", "DisplayBoardbtn", "Settingsbtn" };
            string[] images = { "redHouse", "clipboard", "exclamation", "spanner", "keyboard", "Monitor", "cog" };

            for (int x = 0; x < PageButtons.Length; x++)
            {
                string imageName = images[x];

                Control buttonControl = Controls.Find(PageButtons[x], true).FirstOrDefault();
                if (buttonControl is Button button)
                {
                    button.Image = new Bitmap((Image)Properties.Resources.ResourceManager.GetObject(imageName), new Size(18, 18));
                    button.ImageAlign = ContentAlignment.MiddleRight;
                    button.Padding = new Padding(0, 0, 10, 0);
                }
            }
        }

        private void currentPageHighlight()
        {
            string pageName = this.Name + "btn";
            Button button = Controls.Find(pageName, true).FirstOrDefault() as Button;
            selectionpnl.BringToFront();
            selectionpnl.Height = button.Height;
            selectionpnl.Top = button.Top;
            selectionpnl.Left = button.Left;
            button.BackColor = Color.FromArgb(46, 51, 73);
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
            currentPageHighlight();
        }

        private void enlargeImage(object sender, EventArgs e)
        {
            PictureBox picturebox = sender as PictureBox;
            originalArrowWidth = picturebox.Width;
            originalArrowHeight = picturebox.Height;
            int newWidth = (int)(picturebox.Width * 1.1);
            int newHeight = (int)(picturebox.Height * 1.1);
            picturebox.Size = new Size(newWidth, newHeight);
        }

        private void shrinkImage(object sender, EventArgs e)
        {
            PictureBox picturebox = sender as PictureBox;
            picturebox.Size = new Size(originalArrowWidth, originalArrowHeight);
        }

        private void collapsepicbox_Click(object sender, EventArgs e)
        {
            originalexpandWidth = (int)manualTablepnl.ColumnStyles[0].Width;
            manualTablepnl.ColumnStyles[0].Width = 0;

            expandpicbox.Visible = true;
            expandpicbox.BringToFront();
        }

        private void expandpicbox_Click(object sender, EventArgs e)
        {
            manualTablepnl.ColumnStyles[0].Width = originalexpandWidth;
            expandpicbox.Visible = false;
        }


    }
}