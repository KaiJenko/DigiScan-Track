using System.Data.SqlClient;
using System.Xml.Serialization;

namespace DigiScan_Track
{
    public partial class HomePageShortcuts : Form
    {
        public HomePageShortcuts()
        {
            InitializeComponent();
            /*getSQLHomepage();*/
            loadDepartmentcmb();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            Departmentcmb.SelectedItem = Departmentcmb.Items[0].ToString();

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

            string[] gearsImages =
            {
                "Bevelling",
                "Etching",
                "Precision",
                "Production",
                "Modelling",
                "Shim Grinding"
            };

            // Calculate the size of each PictureBox
            int pictureBoxWidth = 250;
            int pictureBoxHeight = 160;
            int MilitaryLength = militaryImages.Length;
            int NacellesLength = nacellesImages.Length;
            int GearsLength = gearsImages.Length;
            int flowLayoutPanelWidth = HomepageImageflow.ClientSize.Width;

            // Calculate the total width occupied by the PictureBoxes (excluding margins)
            int totalPictureBoxWidth = MilitaryLength * pictureBoxWidth;

            // Calculate the horizontal spacing between PictureBoxes
            int horizontalSpacing = (flowLayoutPanelWidth - totalPictureBoxWidth) / (MilitaryLength + 1);


            switch (comboboxItem)
            {
                case "Military":
                    HomepageImageflow.Controls.Clear();
                    foreach (string image in militaryImages)
                    {
                        createshortcuts(pictureBoxWidth, pictureBoxHeight, image, horizontalSpacing);
                    }
                    HomepageImageflow.PerformLayout();
                    break;

                case "Nacelles":
                    HomepageImageflow.Controls.Clear();
                    foreach (string image in nacellesImages)
                    {
                        createshortcuts(pictureBoxWidth, pictureBoxHeight, image, horizontalSpacing);
                    }
                    break;

                case "Gears":
                    HomepageImageflow.Controls.Clear();
                    foreach (string image in gearsImages)
                    {
                        createshortcuts(pictureBoxWidth, pictureBoxHeight, image, horizontalSpacing);
                    }
                    break;

            }
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            string departmentName = Departmentcmb.Text;
            string workstation = clickedButton.Name.ToString();

            if (clickedButton.Text == "Input Part")
            {

                

                if (Application.OpenForms["Homepage"] is HomePage homepage)
                {

                    ManualInput newForm = new ManualInput(departmentName, workstation);

                    newForm.TopLevel = false;
                    newForm.Dock = DockStyle.Fill;
                    homepage.InnerBodypnl.Controls.Clear();
                    homepage.InnerBodypnl.Controls.Add(newForm);
                    newForm.Show();
                }
            }

            else if (clickedButton.Text == "View Parts")
            {
                 if (Application.OpenForms["Homepage"] is HomePage homepage)
                 {
                    WIPTracker WIP = new WIPTracker(departmentName, workstation);

                    WIP.TopLevel = false;
                    WIP.Dock = DockStyle.Fill;
                    homepage.InnerBodypnl.Controls.Clear();
                    homepage.InnerBodypnl.Controls.Add(WIP);
                    WIP.Show();
                 }
            }
        }

        private void createshortcuts(int width, int height, string image, int spacing)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(image);
            pictureBox.Size = new Size(width, height);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Margin = new Padding(spacing + 60, 30, spacing, 30);

            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.BackColor = Color.Transparent;
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));

            Label title = new Label();
            title.Text = image;
            title.Font = new Font("Arial", 12, FontStyle.Bold);
            title.ForeColor = Color.White;
            title.BackColor = Color.FromArgb(20, Color.Black);
            title.AutoSize = false;
            title.TextAlign = ContentAlignment.MiddleCenter;

            Button partInput = new Button();
            partInput.Text = "Input Part";
            partInput.Name = image;
            partInput.ForeColor = Color.Black;
            partInput.AutoSize = false;
            partInput.TextAlign = ContentAlignment.MiddleCenter;
            partInput.Size = new Size(100, 23);
            partInput.Click += ButtonClicked;

            Button tableView = new Button();
            tableView.Text = "View Parts";
            tableView.Name = image;
            tableView.ForeColor = Color.Black; // Set the text color
            tableView.AutoSize = false;
            tableView.TextAlign = ContentAlignment.MiddleCenter; // Center the text
            tableView.Size = new Size(100, 23);
            tableView.Click += ButtonClicked;

            tableLayoutPanel.Controls.Add(title, 1, 1); // Add label to center cell
            tableLayoutPanel.Controls.Add(partInput, 1, 2); // Add button 1 to the bottom
            tableLayoutPanel.SetColumnSpan(partInput, 1); // Set column span to center the button
            tableLayoutPanel.Controls.Add(tableView, 1, 3); // Add button 2 below button 1
            tableLayoutPanel.SetColumnSpan(tableView, 1); // Set column span to center the button
            pictureBox.Controls.Add(tableLayoutPanel); // Add the label to the PictureBox

            HomepageImageflow.Controls.Add(pictureBox);
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
    }
}