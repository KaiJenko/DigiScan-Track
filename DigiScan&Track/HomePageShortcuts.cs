using System.Data.SqlClient;


namespace DigiScan_Track
{
    public partial class HomePageShortcuts : Form
    {

        public HomePageShortcuts()
        {
            InitializeComponent();
            LoadDepartmentcmbSQL();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //Populating the department combobox
        private void LoadDepartmentcmbSQL()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source = Jenko\\MSSQLSERVER01; Initial Catalog=DigiTrackAndScan; Integrated Security = True;";
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Distinct(Department) FROM Departments";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Departmentcmb.Items.Add(dr["Department"].ToString());
            }
            conn.Close();
            Departmentcmb.SelectedItem = Departmentcmb.Items[3].ToString();
            Departmentcmb.SelectedItem = Color.FromArgb(255, 46, 51, 73);

        }


        //Runs each time a new dropdown selection is made
        private void Departmentcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string comboboxItem = Departmentcmb.SelectedItem.ToString();

            //Each array corresponds to a department - needs to be hardcoded due to the naming of the images may change
            string[] militaryImages =
            {
              "GLMRS",
              "Shipping",
              "HMO",
              "GPS",
              "Folding Bay"
            };

            string[] actuationImages =
            {
                "Nacelles",
                "High-Lift",
                "Trac Lock",
                "Folding Wings"
            };

            string[] gearsImages =
            {
                "Bevelling",
                "Etching",
                "Precision",
                "Production",
                "Modelling",
                "Shim Grind"
            };

            string[] transmissionImages =
            {
                "Machined",
                "Taping",
                "Curing",
                "Pressure Test"
            };

            string[] compositeImages =
            {
                "Multi-spindle",
                "Tape Winding",
                "Braiding",
                "Mandrels",
                "Filament winding",
                "Ultrasonic"
            };

            string[] fuelPipesImages =
            {
                "Dry Winding",
                "Assembly",
                "Heat Treat",
                "Overwrap",
                "Finite Analysis"
            };

            // the shortcut size is calculated
            double pictureBoxWidth = HomepageImageflow.Width / 3.75;
            double pictureBoxHeight = HomepageImageflow.Height / 2.5;
            int pictureLength = actuationImages.Length;
            int flowLayoutPanelWidth = HomepageImageflow.ClientSize.Width;

            // Calculate width occupied by the shortcut - ensures they can all fit on the panel
            double totalPictureBoxWidth = 3 * pictureBoxWidth;

            // Calculate spacing between shortcuts - were too close together before
            double horizontalSpacing = (flowLayoutPanelWidth - totalPictureBoxWidth) / (pictureLength + 2);

            //Switch statement for assigning image to the correct shortcut picturebox - one for each department 
            switch (comboboxItem)
            {
                case "Actuation":
                    HomepageImageflow.Controls.Clear();
                    foreach (string image in actuationImages)
                    {
                        Createshortcuts(pictureBoxWidth, pictureBoxHeight, image, horizontalSpacing);
                    }
                    break;

                case "Composites":
                    HomepageImageflow.Controls.Clear();
                    foreach (string image in compositeImages)
                    {
                        Createshortcuts(pictureBoxWidth, pictureBoxHeight, image, horizontalSpacing);
                    }
                    break;

                case "Fuel Pipes":
                    HomepageImageflow.Controls.Clear();
                    foreach (string image in fuelPipesImages)
                    {
                        Createshortcuts(pictureBoxWidth, pictureBoxHeight, image, horizontalSpacing);
                    }
                    break;

                case "Gears":
                    HomepageImageflow.Controls.Clear();
                    foreach (string image in gearsImages)
                    {
                        Createshortcuts(pictureBoxWidth, pictureBoxHeight, image, horizontalSpacing);
                    }
                    break;

                case "Military":
                    HomepageImageflow.Controls.Clear();
                    foreach (string image in militaryImages)
                    {
                        Createshortcuts(pictureBoxWidth, pictureBoxHeight, image, horizontalSpacing);
                    }
                    HomepageImageflow.PerformLayout();
                    break;


                case "Transmission":
                    HomepageImageflow.Controls.Clear();
                    foreach (string image in transmissionImages)
                    {
                        Createshortcuts(pictureBoxWidth, pictureBoxHeight, image, horizontalSpacing);
                    }
                    break;

            }
        }


        //This dyncamically creates as many picturebox shortcuts as is needed - uses the amount of departments in the SQL database to calculate
        private void Createshortcuts(double width, double height, string image, double spacing)
        {
            //First creates the picturebox 
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(image);
            pictureBox.Size = new Size((int)width, (int)height);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Margin = new Padding((int)spacing - 5, (int)spacing - 5, (int)spacing - 5, (int)spacing - 5); //display problem for laptops here

            //Adds a layout style - one column with two rows - one row for the title and one for the buttons
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.BackColor = Color.Transparent;
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, (float)width / 3)); //Display problem was here as width was hardcoded
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, (float)(width / 5)));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, (float)(width / 7)));

            //Creates a label based of the image's name 
            Label title = new Label();
            title.Text = image;
            title.Font = new Font("Arial", 12, FontStyle.Bold);
            title.ForeColor = Color.White;
            title.BackColor = Color.FromArgb(150, Color.Black);
            title.TextAlign = ContentAlignment.MiddleCenter;
            title.AutoSize = true;
            title.Anchor = AnchorStyles.None;

            //Creates the first button - for redirecting user to the manual part input page
            Button partInput = new Button();
            partInput.Text = "Input Part";
            partInput.Name = image;
            partInput.ForeColor = Color.Black;
            partInput.AutoSize = false;
            partInput.TextAlign = ContentAlignment.MiddleCenter;
            partInput.Size = new Size((int)(width / 3), (int)(width / 10));
            //Assigns a assignment to the click - in this case it works out where the button needs to take the user
            partInput.Click += ShortcutButtonClicked;
            partInput.Cursor = Cursors.Hand;
            partInput.FlatStyle = FlatStyle.Popup;
            partInput.BackColor = Color.PaleTurquoise;
            partInput.Anchor = AnchorStyles.Top;

            //Creates second button - for redirecting user to the WIP tracker page
            Button tableView = new Button();
            tableView.Text = "View Parts";
            tableView.Name = image;
            tableView.ForeColor = Color.Black;
            tableView.AutoSize = false;
            tableView.TextAlign = ContentAlignment.MiddleCenter;
            tableView.Size = new Size((int)(width / 3), (int)(width / 10));
            tableView.Click += ShortcutButtonClicked;
            tableView.Cursor = Cursors.Hand;
            tableView.FlatStyle = FlatStyle.Popup;
            tableView.BackColor = Color.DarkTurquoise;
            tableView.Anchor = AnchorStyles.None;


            tableLayoutPanel.Controls.Add(title, 0, 1); //the 0 corresponds to the column as there is only one column 
            tableLayoutPanel.SetColumnSpan(title, 1);
            tableLayoutPanel.Controls.Add(partInput, 0, 2); //1 means added to second row as 0 leaves a gap at the top
            tableLayoutPanel.SetColumnSpan(partInput, 1);
            tableLayoutPanel.Controls.Add(tableView, 0, 2); //2 is for both buttons to be added to the third row down
            tableLayoutPanel.SetColumnSpan(tableView, 1);
            pictureBox.Controls.Add(tableLayoutPanel); //This adds all controls to the picturebox into a nice box


            HomepageImageflow.Controls.Add(pictureBox); //Adds all pictureboxes to the image flow in the innerbody panel
        }


        //Determines which button has been clicked in the shortcut 
        private void ShortcutButtonClicked(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            string departmentName = Departmentcmb.Text;
            string workstation = clickedButton.Name.ToString();

            if (clickedButton.Text == "Input Part")
            {
                if (Application.OpenForms["Homepage"] is HomePage homepage) //Checks that homepage is still open - as must always be open 
                {
                    ManualInput newForm = new ManualInput(departmentName, workstation);

                    newForm.TopLevel = false;
                    newForm.Dock = DockStyle.Fill;
                    homepage.InnerBodypnl.Controls.Clear();
                    homepage.InnerBodypnl.Controls.Add(newForm);
                    newForm.Show();

                    homepage.previousButtonClicked.Enabled = true;
                    homepage.ManualInputbtn.Enabled = false;
                    homepage.previousButtonClicked = homepage.ManualInputbtn;

                }
            }

            else if (clickedButton.Text == "View Parts")
            {
                if (Application.OpenForms["Homepage"] is HomePage homepage)
                {
                    WIPTracker wip = new WIPTracker(departmentName, workstation);

                    wip.TopLevel = false;
                    wip.Dock = DockStyle.Fill;
                    homepage.InnerBodypnl.Controls.Clear();
                    homepage.InnerBodypnl.Controls.Add(wip);
                    wip.Show();

                    homepage.previousButtonClicked.Enabled = true;
                    homepage.WIPTrackerbtn.Enabled = false;
                    homepage.previousButtonClicked = homepage.WIPTrackerbtn;
                }
            }
        }


        //Used in other forms - this function removes an annoying grey highlight colour on all comboboxes replacing it with a dark blue
        //Youtube tutorial on a NUGET package called SFcomboboxes was used
        public void ComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= ((ComboBox)sender).Items.Count)
                return;

            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            ComboBox comboBox = sender as ComboBox;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(24, 30, 54)), e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(46, 51, 73)), e.Bounds);
            }
            e.Graphics.DrawString(comboBox.Items[e.Index].ToString(), e.Font, new SolidBrush(Color.White), e.Bounds);
        }
    }
}