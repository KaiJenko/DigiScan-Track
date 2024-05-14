using System.Runtime.CompilerServices;
using Timer = System.Windows.Forms.Timer;

/*
 * 
 * This page is always open within the application, instead of opening and closing a new form each time
 * One of the panels inside this form is cleared and a new form takes its place. This allows for the taskbar and its buttons to always be visible
 * 
 */


namespace DigiScan_Track
{
    public partial class HomePage : Form
    {

        int originalArrowWidth;
        int originalArrowHeight;
        int originalexpandWidth;

        public Button previousButtonClicked;

        Timer timer;
        DateTime startTime;

        public HomePage()
        {
            InitializeComponent();
            LoadButtonImages();
            CreateTimer();
            previousButtonClicked = HomePageShortcutsbtn;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CurrentFormSelect();
        }


        //A timer to track how long the user has the application open for 
        private void CreateTimer()
        {
            timer = new Timer();
            timer.Interval = 1100;
            timer.Tick += TimerCalculation;
            startTime = DateTime.Now;
            timer.Start();
        }



        private void TimerCalculation(object sender, EventArgs e)
        {

            TimeSpan elapsedTimer = DateTime.Now - startTime;
            periodOnlinelbl.Text = elapsedTimer.ToString(@"hh\:mm\:ss");
        }


        //This loads the first form, homepageshortcuts, into the innerbody panel
        //the currentformpnl highlights the button to show the user which page they're on
        private void CurrentFormSelect()
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
            HomePageShortcutsbtn.Enabled = false;
        }


        //Quick check to see if the user has logged in
        public void SetLogin()
        {
            string username = UserLoginDetails.Instance.Username;
            bool hasPermission = UserLoginDetails.Instance.loggedIN;
            if (hasPermission)
            {
                loginbtn.Visible = false;
                usernamelbl.Visible = true;
                usernamelbl.Text = username;
                logoutbtn.Visible = true;
            }
        }



        /*------------------------------------------------Code which is always open and working------------------------------------------------------------------*/

        //This is the old method for opening my forms - however I chose to go down a different route and have multiple forms instead of just one open
        public static void HeaderButton(Form newForm, Form originalForm, FormWindowState windowState)
        {
            newForm.Show(); //in this case the newform would be the linked form of whichever button is clicked
            originalForm.Hide(); //Closes the previous tab so does not clog up users computer
            if (windowState == FormWindowState.Maximized) //If the user is working on a minimised screen then it stays minimised
            {
                newForm.WindowState = FormWindowState.Maximized;
            }
        }

        public void Loginbtn_Click(object sender, EventArgs e)
        {
            LoginPage loginpage = new LoginPage();
            HomePageButtonClick(loginpage, sender, e);
        }

        public void HomeAreabtn_Click(object sender, EventArgs e)
        {
            HomePageShortcuts shortcut = new HomePageShortcuts();
            HomePageButtonClick(shortcut, sender, e);
        }

        public void WIPTrackerbtn_Click(object sender, EventArgs e)
        {
            WIPTracker wip = new WIPTracker(null, null);
            HomePageButtonClick(wip, sender, e);
        }

        public void AgedWIPbtn_Click(object sender, EventArgs e)
        {
            AgedWIP agedwip = new AgedWIP();
            HomePageButtonClick(agedwip, sender, e);
        }

        public void EditPartsbtn_Click(object sender, EventArgs e)
        {
            EditParts edit = new EditParts();
            HomePageButtonClick(edit, sender, e);
        }

        public void ManualInputbtn_Click(object sender, EventArgs e)
        {
            ManualInput manual = new ManualInput(null, null);
            HomePageButtonClick(manual, sender, e);
        }

        public void DisplayBoardbtn_Click(object sender, EventArgs e)
        {
            DisplayBoard display = new DisplayBoard();
            HomePageButtonClick(display, sender, e);

        }

        private void actionHistorybtn_Click(object sender, EventArgs e)
        {
            HistoryPage history = new HistoryPage();
            HomePageButtonClick(history, sender, e);
        }

        public void Settingsbtn_Click(object sender, EventArgs e)
        {
            SettingsPage settings = new SettingsPage();
            HomePageButtonClick(settings, sender, e);

        }

        //This function is used to stop the user spamming the button clicks - during testing this was found
        //to crash the application if pressed consecutively. Disables the button which has been clicked
        //and re-enables it when clicked off
        private void HomePageButtonClick(Form newForm, object sender, EventArgs e)
        {

            Button buttonClicked = sender as Button;
            ButtonColour();

            if (previousButtonClicked == buttonClicked)
            {
                buttonClicked.Enabled = false;
                buttonClicked.ForeColor = Color.Red;
            }

            else
            {
                previousButtonClicked.Enabled = true;
                previousButtonClicked = buttonClicked;
            }

            currentFormpnl.BringToFront();
            currentFormpnl.Height = buttonClicked.Height;
            currentFormpnl.Top = buttonClicked.Top;
            currentFormpnl.Left = buttonClicked.Left;

            //Due to the login button being a different design it did not need to be highlighted
            if (buttonClicked.Name == "loginbtn")
            {
                buttonClicked.BackColor = Color.Transparent;
                currentFormpnl.Visible = false;
            }
            else
            {
                buttonClicked.BackColor = Color.FromArgb(46, 51, 73);
                buttonClicked.Enabled = false;
            }

            //Removes all contents of the main panel and replaces it with the new forms

            InnerBodypnl.Controls.Clear();
            newForm.Dock = DockStyle.Fill;
            newForm.TopLevel = false;
            newForm.TopMost = true;
            newForm.FormBorderStyle = FormBorderStyle.None;

            InnerBodypnl.Controls.Add(newForm);
            newForm.Show();
        }


        //Loops through the buttons in the taskbar assigning an image to each based on the string array
        private void LoadButtonImages()
        {
            WIPTracker wip = new WIPTracker(null, null);
            wip.TransparentBackground(this, "loginbtn", "logoutbtn");

            string[] images = { "redHouse", "clipboard", "exclamation", "spanner", "keyboard", "Monitor", "cog", "newHistory"};
            int x = images.Length - 1; //as the login button doesnt need a button - minus 1 here stops the loop just as it reaches it

            foreach (Control control in dashpnl.Controls)
            {
                //Checks the control is a button
                if (control.GetType() == typeof(Button))
                {
                    string imageName = images[x];

                    if (control is Button button)
                    {
                        if (button.Name == "logoutbtn")
                        {
                            continue;
                        }
                        //Resizing of the images to ensure theyfit nicely
                        button.Image = new Bitmap((Image)Properties.Resources.ResourceManager.GetObject(imageName), new Size(button.Height / 2, button.Height / 2));
                        button.ImageAlign = ContentAlignment.MiddleRight;
                        button.Padding = new Padding(0, 0, 10, 0);
                        x--;
                    }
                }
            }
        }


        //Aesthetic highlight of the buttons when the user hovers over it 
        private void HoverButton(object sender, EventArgs e)
        {
            Button hoverbtn = sender as Button;
            selectionpnl.BringToFront();
            selectionpnl.Height = hoverbtn.Height;
            selectionpnl.Top = hoverbtn.Top;
            selectionpnl.Left = hoverbtn.Left;
            hoverbtn.BackColor = Color.FromArgb(46, 51, 73);
        }



        private void UnHoverButton(object sender, EventArgs e)
        {

            Button hoverbtn = sender as Button;
            selectionpnl.SendToBack();
            if (!hoverbtn.Bounds.Contains(currentFormpnl.Bounds))
            {
                hoverbtn.BackColor = Color.FromArgb(24, 30, 54);
            }
        }


        //Used to reset the colour once the button has been unselected
        public void ButtonColour()
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



        private void EnlargeImage(object sender, EventArgs e)
        {
            PictureBox picturebox = sender as PictureBox;
            originalArrowWidth = picturebox.Width;
            originalArrowHeight = picturebox.Height;
            int newWidth = (int)(picturebox.Width * 1.1);
            int newHeight = (int)(picturebox.Height * 1.1);
            picturebox.Size = new Size(newWidth, newHeight);
        }



        private void ShrinkImage(object sender, EventArgs e)
        {
            PictureBox picturebox = sender as PictureBox;
            picturebox.Size = new Size(originalArrowWidth, originalArrowHeight);
        }


        //Taskbar closed 
        private void Collapsepicbox_Click(object sender, EventArgs e)
        {
            originalexpandWidth = (int)manualTablepnl.ColumnStyles[0].Width;
            manualTablepnl.ColumnStyles[0].Width = 0;

            expandpicbox.Visible = true;
        }


        //Taskbar opened
        private void Expandpicbox_Click(object sender, EventArgs e)
        {
            manualTablepnl.ColumnStyles[0].Width = originalexpandWidth;
            expandpicbox.Visible = false;
        }


        //Everytime a new form is opened in the innerbody panel, if its not the loginpage form
        public void InnerBodypnl_ControlAdded(object sender, ControlEventArgs e)
        {
            foreach (Control controls in InnerBodypnl.Controls)
            {
                if (controls is Form form)
                {
                    string formname = form.GetType().Name;
                    if (formname != "LoginPage")
                    {
                        ButtonColour();
                        currentFormpnl.BringToFront();
                        string buttonname = formname + "btn";
                        Button button = Controls.Find(buttonname, true).FirstOrDefault() as Button;
                        currentFormpnl.Height = button.Height;
                        currentFormpnl.Top = button.Top;
                        currentFormpnl.Left = button.Left;
                        button.BackColor = Color.FromArgb(46, 51, 73);
                    }
                }
            }
        }


        //Logout button visible once the user has logged in - useful for shop floor due to multiple operators to a PC
        private void LogOutbtn_Click(object sender, EventArgs e)
        {
            MessageBoxButtons msgbtn = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show("Do you want to Log Out?", "Log Out", msgbtn);
            if (result == DialogResult.Yes)
            {
                //Resets all instances from Userlogindetails
                UserLoginDetails.Instance.Username = "";
                UserLoginDetails.Instance.Permission = "";
                UserLoginDetails.Instance.loggedIN = false;
                loginbtn.Visible = true;
                logoutbtn.Visible = false;
                usernamelbl.Visible = false;
                usernamelbl.Text = string.Empty;
            }
        }


        //This is called in multiple forms - checks each keystroke for the enter key. if it is pressed then it presses the associated button
        public void EnterButtonClicked(Button button, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                button.PerformClick();
            }
        }
    }
}