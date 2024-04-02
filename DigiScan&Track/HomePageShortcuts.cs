using System.Data.SqlClient;

namespace DigiScan_Track
{
    public partial class HomePageShortcuts : Form
    {

        public HomePageShortcuts()
        {
            InitializeComponent();
            loadDepartmentcmbSQL();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void loadDepartmentcmbSQL()
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



        private void Departmentcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string comboboxItem = Departmentcmb.SelectedItem.ToString();


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

            // Calculate the size of each PictureBox
            int pictureBoxWidth = 250;
            int pictureBoxHeight = 160;
            int pictureLength = actuationImages.Length;
            int flowLayoutPanelWidth = HomepageImageflow.ClientSize.Width;

            // Calculate the total width occupied by the PictureBoxes (excluding margins)
            int totalPictureBoxWidth = pictureLength * pictureBoxWidth;

            // Calculate the horizontal spacing between PictureBoxes
            int horizontalSpacing = (flowLayoutPanelWidth - totalPictureBoxWidth) / (pictureLength + 1);

            switch (comboboxItem)
            {
                case "Actuation":
                    HomepageImageflow.Controls.Clear();
                    foreach (string image in actuationImages)
                    {
                        createshortcuts(pictureBoxWidth, pictureBoxHeight, image, horizontalSpacing);
                    }
                    break;

                case "Composites":
                    HomepageImageflow.Controls.Clear();
                    foreach (string image in compositeImages)
                    {
                        createshortcuts(pictureBoxWidth, pictureBoxHeight, image, horizontalSpacing);
                    }
                    break;

                case "Fuel Pipes":
                    HomepageImageflow.Controls.Clear();
                    foreach (string image in fuelPipesImages)
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

                case "Military":
                    HomepageImageflow.Controls.Clear();
                    foreach (string image in militaryImages)
                    {
                        createshortcuts(pictureBoxWidth, pictureBoxHeight, image, horizontalSpacing);
                    }
                    HomepageImageflow.PerformLayout();
                    break;


                case "Transmission":
                    HomepageImageflow.Controls.Clear();
                    foreach (string image in transmissionImages)
                    {
                        createshortcuts(pictureBoxWidth, pictureBoxHeight, image, horizontalSpacing);
                    }
                    break;

            }
        }



        private void createshortcuts(int width, int height, string image, int spacing)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(image);
            pictureBox.Size = new Size(width, height);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Margin = new Padding(spacing + 60, 30, spacing, 30); //display problem for laptops here


            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.BackColor = Color.Transparent;
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75)); //is this the display problem 
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));


            Label title = new Label();
            title.Text = image;
            title.Font = new Font("Arial", 12, FontStyle.Bold);
            title.ForeColor = Color.White;
            title.BackColor = Color.FromArgb(150, Color.Black);
            title.TextAlign = ContentAlignment.MiddleCenter;
            if (title.Text.Length > 10)
            {
                title.AutoSize = true;
            }
            else
            {
                title.AutoSize = false;
            }
            title.TextAlign = ContentAlignment.MiddleCenter;


            Button partInput = new Button();
            partInput.Text = "Input Part";
            partInput.Name = image;
            partInput.ForeColor = Color.Black;
            partInput.AutoSize = false;
            partInput.TextAlign = ContentAlignment.MiddleCenter;
            partInput.Size = new Size(100, 23);
            partInput.Click += ShortcutButtonClicked;
            partInput.Cursor = Cursors.Hand;
            partInput.FlatStyle = FlatStyle.Popup;
            partInput.BackColor = Color.PaleTurquoise;


            Button tableView = new Button();
            tableView.Text = "View Parts";
            tableView.Name = image;
            tableView.ForeColor = Color.Black; 
            tableView.AutoSize = false;
            tableView.TextAlign = ContentAlignment.MiddleCenter; 
            tableView.Size = new Size(100, 23);
            tableView.Click += ShortcutButtonClicked;
            tableView.Cursor = Cursors.Hand;
            tableView.FlatStyle = FlatStyle.Popup;
            tableView.BackColor = Color.DarkTurquoise;


            tableLayoutPanel.Controls.Add(title, 1, 1); 
            tableLayoutPanel.Controls.Add(partInput, 1, 2); // Add button 1 to the bottom
            tableLayoutPanel.SetColumnSpan(partInput, 1); // Set column span to center the button
            tableLayoutPanel.Controls.Add(tableView, 1, 3); // Add button 2 below button 1
            tableLayoutPanel.SetColumnSpan(tableView, 1); // Set column span to center the button
            pictureBox.Controls.Add(tableLayoutPanel); // Add the label to the PictureBox


            HomepageImageflow.Controls.Add(pictureBox);
        }



        private void ShortcutButtonClicked(object sender, EventArgs e)
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



        public void ComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
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