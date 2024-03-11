using DigiScan_Track.Properties;
using Microsoft.VisualBasic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;
using System.IO;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace DigiScan_Track
{
    public partial class HomePageSpare : Form
    {

        SqlConnection conn = new SqlConnection();
        int originalArrowWidth;
        int originalArrowHeight;
        int originalexpandWidth;
        public HomePageSpare()
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
            loadDepartmentcmb();
        }

        private void loadDepartmentcmb()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source = Jenko\\MSSQLSERVER01; Initial Catalog=DigiTrackAndScan; Integrated Security = True;";
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Distinct(Department) FROM Departments";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) // Loop through the result set
            {
                Departmentcmb.Items.Add(dr["Department"].ToString());
            }
            conn.Close();
        }

        private void Departmentcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string comboboxItem = Departmentcmb.SelectedItem.ToString();


            string[] militaryImages =
            {
              "GLMRS",
              "Shipping",
              "HMO",
              "GPS"
            };

            string[] nacellesImages =
            {

            };

            string[] GearsImages =
            {

            };

            // Calculate the size of each PictureBox
            int pictureBoxWidth = 250; // Adjust the size as needed
            int pictureBoxHeight = 160; // Adjust the size as needed
            int numImages = militaryImages.Length;
            int flowLayoutPanelWidth = HomepageImageflow.ClientSize.Width;

            // Calculate the total width occupied by the PictureBoxes (excluding margins)
            int totalPictureBoxWidth = numImages * pictureBoxWidth;

            // Calculate the horizontal spacing between PictureBoxes
            int horizontalSpacing = (flowLayoutPanelWidth - totalPictureBoxWidth) / (numImages + 1);


            switch (comboboxItem)
            {
                case "Military":
                    HomepageImageflow.Controls.Clear();
                    foreach (string image in militaryImages)
                    {
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(image);
                        pictureBox.Size = new Size(pictureBoxWidth, pictureBoxHeight); // Adjust the size as needed
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage; // Adjust the size mode as needed
                        pictureBox.Margin = new Padding(horizontalSpacing + 60, 30, horizontalSpacing, 30);

                        TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
                        tableLayoutPanel.BackColor = Color.Transparent;
                        tableLayoutPanel.Dock = DockStyle.Fill;
                        tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80));
                        tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90));
                        tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
                        tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));

                        Label title = new Label();
                        title.Text = image; // Set the text you want to display
                        title.Font = new Font("Arial", 12, FontStyle.Bold); // Set the font (you can adjust the font size and style as needed)
                        title.ForeColor = Color.White; // Set the text color
                        title.BackColor = Color.FromArgb(20, Color.Black); // Set the background color with transparency
                        title.AutoSize = false;
                        title.TextAlign = ContentAlignment.MiddleCenter; // Center the text

                        Button partInput = new Button();
                        partInput.Text = "Input Part";
                        partInput.ForeColor = Color.Black; // Set the text color
                        partInput.AutoSize = false;
                        partInput.TextAlign = ContentAlignment.MiddleCenter; // Center the text 
                        partInput.Size = new Size(100, 23);

                        Button tableView = new Button();
                        tableView.Text = "View Parts";
                        tableView.ForeColor = Color.Black; // Set the text color
                        tableView.AutoSize = false;
                        tableView.TextAlign = ContentAlignment.MiddleCenter; // Center the text
                        tableView.Size = new Size(100, 23);

                        tableLayoutPanel.Controls.Add(title, 1, 1); // Add label to center cell
                        tableLayoutPanel.Controls.Add(partInput, 1, 2); // Add button 1 to the bottom
                        tableLayoutPanel.SetColumnSpan(partInput, 1); // Set column span to center the button
                        tableLayoutPanel.Controls.Add(tableView, 1, 3); // Add button 2 below button 1
                        tableLayoutPanel.SetColumnSpan(tableView, 1); // Set column span to center the button
                        pictureBox.Controls.Add(tableLayoutPanel); // Add the label to the PictureBox


                        HomepageImageflow.Controls.Add(pictureBox);
                    }
                    HomepageImageflow.PerformLayout();
                    break;

                case "Nacelles":
                    HomepageImageflow.Controls.Clear();
                    break;

                case "Gears":
                    HomepageImageflow.Controls.Clear();
                    break;

            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            if (sender is Label clickedPictureBox)
            {

            }
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

       
    }
}