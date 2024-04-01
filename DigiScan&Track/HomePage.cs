using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Serialization;
using Timer = System.Windows.Forms.Timer;

namespace DigiScan_Track
{
    public partial class HomePage : Form
    {

        SqlConnection conn = new SqlConnection();
        int originalArrowWidth;
        int originalArrowHeight;
        int originalexpandWidth;
        Timer timer;
        DateTime startTime;

        public HomePage()
        {
            InitializeComponent();
            LoadButtonImages();
            createTimer();
            startTime = DateTime.Now;
            timer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            expandpicbox.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);

            currentFormpnl.BringToFront();
            currentFormpnl.Height = HomePageShortcutsbtn.Height;
            currentFormpnl.Top = HomePageShortcutsbtn.Top;
            currentFormpnl.Left = HomePageShortcutsbtn.Left;
            HomePageShortcutsbtn.BackColor = Color.FromArgb(46, 51, 73);
            this.InnerBodypnl.Controls.Clear();
            HomePageShortcuts homepageshortcut = new HomePageShortcuts { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            homepageshortcut.FormBorderStyle = FormBorderStyle.None;
            this.InnerBodypnl.Controls.Add(homepageshortcut);
            homepageshortcut.Show();



        }

        private void createTimer()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += TimerCalculation;
        }

        private void TimerCalculation(object sender, EventArgs e)
        {

            TimeSpan elapsedTimer = DateTime.Now - startTime;
            periodOnlinelbl.Text = elapsedTimer.ToString(@"hh\:mm\:ss");
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

        public void HomeAreabtn_Click(object sender, EventArgs e)
        {
            buttonColour();
            this.InnerBodypnl.Controls.Clear();

            currentFormpnl.BringToFront();
            currentFormpnl.Height = HomePageShortcutsbtn.Height;
            currentFormpnl.Top = HomePageShortcutsbtn.Top;
            currentFormpnl.Left = HomePageShortcutsbtn.Left;
            HomePageShortcutsbtn.BackColor = Color.FromArgb(46, 51, 73);


            HomePageShortcuts homepageshortcut = new HomePageShortcuts { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            homepageshortcut.FormBorderStyle = FormBorderStyle.None;
            this.InnerBodypnl.Controls.Add(homepageshortcut);
            homepageshortcut.Show();
        }

        private void WIPTrackerbtn_Click(object sender, EventArgs e)
        {
            buttonColour();
            currentFormpnl.BringToFront();
            currentFormpnl.Height = WIPTrackerbtn.Height;
            currentFormpnl.Top = WIPTrackerbtn.Top;
            currentFormpnl.Left = WIPTrackerbtn.Left;
            WIPTrackerbtn.BackColor = Color.FromArgb(46, 51, 73);

            this.InnerBodypnl.Controls.Clear();
            WIPTracker wiptracker = new WIPTracker(null, null) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            wiptracker.FormBorderStyle = FormBorderStyle.None;
            this.InnerBodypnl.Controls.Add(wiptracker);
            wiptracker.Show();
        }

        private void AgedWIPbtn_Click(object sender, EventArgs e)
        {
            buttonColour();
            currentFormpnl.BringToFront();
            currentFormpnl.Height = AgedWIPbtn.Height;
            currentFormpnl.Top = AgedWIPbtn.Top;
            currentFormpnl.Left = AgedWIPbtn.Left;
            AgedWIPbtn.BackColor = Color.FromArgb(46, 51, 73);

            this.InnerBodypnl.Controls.Clear();
            AgedWIP agedwip = new AgedWIP() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            agedwip.FormBorderStyle = FormBorderStyle.None;
            this.InnerBodypnl.Controls.Add(agedwip);
            agedwip.Show();
        }

        private void EditPartsbtn_Click(object sender, EventArgs e)
        {
            buttonColour();
            currentFormpnl.BringToFront();
            currentFormpnl.Height = EditPartsbtn.Height;
            currentFormpnl.Top = EditPartsbtn.Top;
            currentFormpnl.Left = EditPartsbtn.Left;
            EditPartsbtn.BackColor = Color.FromArgb(46, 51, 73);

            this.InnerBodypnl.Controls.Clear();
            EditParts editparts = new EditParts() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            editparts.FormBorderStyle = FormBorderStyle.None;
            this.InnerBodypnl.Controls.Add(editparts);
            editparts.Show();
        }

        public void ManualInputbtn_Click(object sender, EventArgs e)
        {
            buttonColour();
            currentFormpnl.BringToFront();
            currentFormpnl.Height = ManualInputbtn.Height;
            currentFormpnl.Top = ManualInputbtn.Top;
            currentFormpnl.Left = ManualInputbtn.Left;
            ManualInputbtn.BackColor = Color.FromArgb(46, 51, 73);

            this.InnerBodypnl.Controls.Clear();
            ManualInput manualinput = new ManualInput(null, null) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            manualinput.FormBorderStyle = FormBorderStyle.None;
            this.InnerBodypnl.Controls.Add(manualinput);
            manualinput.Show();
        }

        private void DisplayBoardbtn_Click(object sender, EventArgs e)
        {
            buttonColour();
            currentFormpnl.BringToFront();
            currentFormpnl.Height = DisplayBoardbtn.Height;
            currentFormpnl.Top = DisplayBoardbtn.Top;
            currentFormpnl.Left = DisplayBoardbtn.Left;
            DisplayBoardbtn.BackColor = Color.FromArgb(46, 51, 73);

            this.InnerBodypnl.Controls.Clear();
            DisplayBoard displayboard = new DisplayBoard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            displayboard.FormBorderStyle = FormBorderStyle.None;
            this.InnerBodypnl.Controls.Add(displayboard);
            displayboard.Show();

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            this.InnerBodypnl.Controls.Clear();
            LoginPage loginpage = new LoginPage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            loginpage.FormBorderStyle = FormBorderStyle.None;
            this.InnerBodypnl.Controls.Add(loginpage);
            loginpage.Show();
        }



        private void LoadButtonImages()
        {
            string[] PageButtons = { "HomePageShortcutsbtn", "WIPTrackerbtn", "AgedWIPbtn", "EditPartsbtn", "ManualInputbtn", "DisplayBoardbtn", "Settingsbtn" };
            string[] images = { "redHouse", "clipboard", "exclamation", "spanner", "keyboard", "Monitor", "cog" };

            for (int x = 0; x < PageButtons.Length; x++)
            {
                string imageName = images[x];

                Control buttonControl = Controls.Find(PageButtons[x], true).FirstOrDefault();
                if (buttonControl is Button button)
                {
                    button.Image = new Bitmap((Image)Properties.Resources.ResourceManager.GetObject(imageName), new Size(22, 22));
                    button.ImageAlign = ContentAlignment.MiddleRight;
                    button.Padding = new Padding(0, 0, 10, 0);
                }
            }
        }

        private void currentPageHighlight(string buttonName)
        {
            Button buttonClicked = Controls.Find(buttonName, true).FirstOrDefault() as Button;
            selectionpnl.BringToFront();
            selectionpnl.Height = buttonClicked.Height;
            selectionpnl.Top = buttonClicked.Top;
            selectionpnl.Left = buttonClicked.Left;
            buttonClicked.BackColor = Color.FromArgb(46, 51, 73);
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
            if (hoverbtn.Bounds.Contains(currentFormpnl.Bounds))
            {
                // If the background color matches, don't change it
                return;
            }
            else
            {
                hoverbtn.BackColor = Color.FromArgb(24, 30, 54);
            }
        }

        public void buttonColour()
        {
            foreach (Control control in dashpnl.Controls)
            {
                if (control is Button)
                {
                    Button button = control as Button;
                    button.BackColor = Color.FromArgb(24, 30, 54);
                }
            }
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
        }

        private void expandpicbox_Click(object sender, EventArgs e)
        {
            manualTablepnl.ColumnStyles[0].Width = originalexpandWidth;
            expandpicbox.Visible = false;
        }

        public void InnerBodypnl_ControlAdded(object sender, ControlEventArgs e)
        {
            foreach (Control controls in InnerBodypnl.Controls)
            {
                if (controls is Form form)
                {
                    string formname = form.GetType().Name;
                    if (formname != "LoginPage")
                    {
                        buttonColour();
                        currentFormpnl.BringToFront();
                        string buttonname = formname + "btn";
                        Button button = this.Controls.Find(buttonname, true).FirstOrDefault() as Button;
                        currentFormpnl.Height = button.Height;
                        currentFormpnl.Top = button.Top;
                        currentFormpnl.Left = button.Left;
                        button.BackColor = Color.FromArgb(46, 51, 73);
                    }
                }
            }
        }


    }
}