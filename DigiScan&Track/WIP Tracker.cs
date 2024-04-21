using System.Data;
using System.Data.SqlClient;
using Timer = System.Windows.Forms.Timer;


namespace DigiScan_Track
{
    public partial class WIPTracker : Form
    {

        SqlConnection conn = new SqlConnection();
        int defaultOrCustom = 0;

        public WIPTracker(string sentDepartment, string sentWorkstation)
        {
            InitializeComponent();
            GetWIPTrackerSQL(sentDepartment, sentWorkstation);
            TransparentBackground(this, "searchbtn", "resetbtn", "addFieldbtn", "bottomLeftBorderbtn");

            HomePageShortcuts homePageShortcuts = new HomePageShortcuts();

            searchcmb.SelectedIndex = 0;
            searchcmb.DrawItem += homePageShortcuts.ComboBox_DrawItem;

            WIPgridView.CellPainting += WIPgridview_CellPainting;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //SQL query to pull rows from the WIP tracker table and display in the data gridview 
        private void GetWIPTrackerSQL(string department, string workstation) //These values are retrieved from shortcuts page if the user clicked the view parts button
                                                                             //If they didnt click it they are set to null and all data is pulled through
        {
            string cmdText = "";

            if (department == null && workstation == null)
            {
                departmentlbl.Text = "";
                workstationlbl.Text = "";

                cmdText = "SELECT TOP(1000)[PartNumber] ,[SerialNumber] ,[Department] ,[Workstation] " +
                          " ,[WSTimestampIN] ,[WSTimestampOUT], [InStorage] FROM [WIPTracking] ORDER BY [SerialNumber]";
                defaultOrCustom = 0;
            }

            else if (department != null || workstation != null)
            {
                departmentlbl.Text = "DP:  " + department;
                workstationlbl.Text = "WS:  " + workstation;
                cmdText = "SELECT TOP(1000)[PartNumber] ,[SerialNumber] ,[BatchNumber]" +
                          " ,[WSTimestampIN] ,[WSTimestampOUT], [InStorage] FROM [WIPTracking] WHERE [Department] = '" + department + "'" +
                          " AND [Workstation] = '" + workstation + "' ORDER BY [SerialNumber]";
                defaultOrCustom = 1;
            }

            DataTable dt = new DataTable();

            conn.ConnectionString = "Data Source = Jenko\\MSSQLSERVER01; Initial Catalog=DigiTrackAndScan; Integrated Security = True;";
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = cmdText;
            SqlDataReader dr = cmd.ExecuteReader();

            dt.Load(dr);

            conn.Close();

            WIPgridView.DataSource = dt;

            if (defaultOrCustom == 0)
            {
                Create_defaultGridView_WIP();
            }

            else
            {
                Create_customGridView_WIP();
            }

        }


        //Different amount of columns in each SQL query requires different formatting of the columns
        private void Create_defaultGridView_WIP()
        {
            WIPgridView.Columns[0].HeaderText = "Part No";
            WIPgridView.Columns[1].HeaderText = "Serial No";
            WIPgridView.Columns[2].HeaderText = "Department";
            WIPgridView.Columns[3].HeaderText = "Workstation";
            WIPgridView.Columns[4].HeaderText = "Time in";
            WIPgridView.Columns[5].HeaderText = "Time out";
            WIPgridView.Columns[6].HeaderText = "In Storage";


            TurnColumnIntoPercent(WIPgridView, 14, 14, 12, 14, 17, 17, 12);

            WIPgridView.ColumnHeadersDefaultCellStyle.Font = new Font(WIPgridView.Font.FontFamily, 12, FontStyle.Bold);
            WIPgridView.ColumnHeadersHeight = 50;
        }



        private void Create_customGridView_WIP()
        {
            WIPgridView.Columns[0].HeaderText = "Part No";
            WIPgridView.Columns[1].HeaderText = "Serial No";
            WIPgridView.Columns[2].HeaderText = "Batch No";
            WIPgridView.Columns[3].HeaderText = "Time in";
            WIPgridView.Columns[4].HeaderText = "Time out";
            WIPgridView.Columns[5].HeaderText = "Storage";


            TurnColumnIntoPercent(WIPgridView, 17, 17, 17, 17, 17, 9);

            WIPgridView.ColumnHeadersDefaultCellStyle.Font = new Font(WIPgridView.Font.FontFamily, 12, FontStyle.Bold);
            WIPgridView.ColumnHeadersHeight = 50;
        }


        //Due to scalability bugs - instead of using a hardcoded pixel measurement, percentages are used to ensure no matter the screen size it will always stay the same
        public void TurnColumnIntoPercent(DataGridView dataGridView, params double[] percentages)
        {
            int totalWidth = dataGridView.ClientSize.Width - dataGridView.RowHeadersWidth;
            //uses the int input to work out how many pixels the column width should be
            for (int i = 0; i < dataGridView.Columns.Count && i < percentages.Length; i++)
            {
                int columnWidth = (int)(totalWidth * percentages[i] / 100);
                dataGridView.Columns[i].Width = columnWidth;
            }
        }



        private void Searchbtn_Click(object sender, EventArgs e)
        {
            ButtonPressedColourChange(sender);

            string searchval = searchtxt.Text.Trim();
            string dropdownSelection = searchcmb.Text.Replace(" ", ""); //some dropdown selections have spaces - part number - in the table its names partnumber
            //Ensures no null values
            if (searchval != "" && dropdownSelection != "")
            {
                AddFieldbtn_Click(sender, e);

                int index = 0;
                string sqlQuery = "";

                foreach (Panel panel in searchFieldpnl.Controls)
                {
                    //Checks for labels within the main panel
                    foreach (Label label in panel.Controls.OfType<Label>())
                    {
                        string labelOutput = label.Text.ToString();
                        string[] parts = labelOutput.Split(new string[] { " - " }, StringSplitOptions.None);
                        string SearchField = parts[0];
                        string SearchValue = parts[1];
                        //THe first sql query must contain a WHERE statement however none after can instead they must contain a AND to append the query 
                        if (index == 0)
                        {
                            sqlQuery = "WHERE [" + SearchField + "] LIKE '%" + SearchValue + "%'"; //Here the ' are needed unlike other forms
                            index++;
                        }

                        else if (index != 0)
                        {
                            sqlQuery += " AND [" + SearchField + "] LIKE '%" + SearchValue + "%'";
                        }

                        if (defaultOrCustom == 1)
                        {
                            //Takes the entire search query as one string - partnumber: 'HGD745' - and splits it into two strings on the :
                            string departmentlblS = departmentlbl.Text.ToString();
                            string workstationlblS = workstationlbl.Text.ToString();
                            string[] departmentSplit = departmentlblS.Split(new string[] { ":  " }, StringSplitOptions.None);
                            string[] workstationSplit = workstationlblS.Split(new string[] { ":  " }, StringSplitOptions.None);
                            string department = departmentSplit[1];
                            string workstation = workstationSplit[1];

                            sqlQuery += " AND [Department] = '" + department + "' AND [Workstation] = '" + workstation + "'";
                        }
                    }
                }

                DataTable dt = new DataTable();
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source = Jenko\\MSSQLSERVER01; Initial Catalog=DigiTrackAndScan; Integrated Security = True;";
                con.Open();
                SqlCommand cmd = con.CreateCommand();

                if (defaultOrCustom == 0)
                {
                    cmd.CommandText = "SELECT TOP (1000) [PartNumber] ,[SerialNumber] ,[Department] ,[Workstation] " +
                                      ",[WSTimestampIN] ,[WSTimestampOUT] ,[InStorage] FROM [WIPTracking] " + sqlQuery;
                    //This reduces the risk of SQL injection
                    cmd.Parameters.AddWithValue("@SQLSearchQuery", sqlQuery); // the ' ' bug was found here and solved
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (!dr.HasRows)
                    {
                        MessageBox.Show("No search results im afraid");
                    }

                    dt.Load(dr);
                    con.Close();

                    WIPgridView.DataSource = dt;
                    Create_defaultGridView_WIP();
                }

                else
                {
                    cmd.CommandText = "SELECT TOP (1000) [PartNumber] ,[SerialNumber] ,[BatchNumber]" +
                                     ",[WSTimestampIN] ,[WSTimestampOUT] ,[InStorage] FROM [WIPTracking] " +
                                     sqlQuery;

                    cmd.Parameters.AddWithValue("@SQLSearchQuery", sqlQuery); //reduces SQL injection
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (!dr.HasRows)
                    {
                        MessageBox.Show("No search results im afraid");
                    }

                    dt.Load(dr);
                    con.Close();

                    WIPgridView.DataSource = dt;
                    Create_customGridView_WIP();
                }

            }

            else
            {
                MessageBox.Show("Please input a value into the search query");
            }
        }



        private void Resetbtn_Click(object sender, EventArgs e)
        {
            ButtonPressedColourChange(sender);
            searchFieldpnl.Controls.Clear();
            GetWIPTrackerSQL(null, null);
            defaultOrCustom = 0;
        }


        //This function allows multiple search fields to be inputted 
        private void AddFieldbtn_Click(object sender, EventArgs e)
        {
            if (searchtxt.Text != "")
            {
                ButtonPressedColourChange(sender);
                string searchField = searchcmb.Text.Replace(" ", "");
                string searchValue = searchtxt.Text.Trim();

                searchcmb.Text = null;
                searchtxt.Text = null;

                int index = searchFieldpnl.Controls.Count;
                //Only three search fields allow as the panel will overflow with anymore
                if (index == 3)
                {
                    MessageBox.Show("No more search fields can be added");
                }

                //Dynamically create panels with the information the user has inputted
                else
                {
                    Panel panel = new Panel();
                    panel.Name = "InnerPanel" + index;
                    panel.BackgroundImage = Properties.Resources.blueBorder;
                    panel.BackgroundImageLayout = ImageLayout.Stretch;
                    panel.MinimumSize = new Size(0, 35);
                    panel.MaximumSize = new Size(500, 35);


                    Label searchFieldLabel = new Label();
                    searchFieldLabel.Text = searchField + " - " + searchValue;
                    searchFieldLabel.ForeColor = Color.White;
                    searchFieldLabel.BackColor = Color.Transparent;
                    searchFieldLabel.Padding = new Padding(10, 0, 0, 0);
                    searchFieldLabel.AutoSize = true;

                    //This acts as a button allowing the user to cross off the search fields individually
                    PictureBox redCrosspbox = new PictureBox();
                    redCrosspbox.Image = Properties.Resources.cross;
                    redCrosspbox.SizeMode = PictureBoxSizeMode.StretchImage;
                    redCrosspbox.Size = new Size(20, 20);
                    redCrosspbox.Cursor = Cursors.Hand;


                    panel.Controls.Add(searchFieldLabel);
                    panel.Controls.Add(redCrosspbox);


                    searchFieldLabel.Location = new Point(5, 5);
                    redCrosspbox.Location = new Point(searchFieldLabel.Right, 5);
                    redCrosspbox.Padding = new Padding(1, 1, 1, 1);
                    panel.Size = new Size(redCrosspbox.Right + 15, 25);
                    searchFieldpnl.Controls.Add(panel);


                    if (index > 0)
                    {
                        Panel nextPanel = (Panel)searchFieldpnl.Controls["InnerPanel" + (index - 1)];
                        panel.Location = new Point(nextPanel.Right + 10, nextPanel.Top);
                    }

                    redCrosspbox.MouseDown += (sender, e) =>
                    {
                        Point clickLocation = redCrosspbox.PointToClient(Cursor.Position);
                        if (new Rectangle(Point.Empty, redCrosspbox.Size).Contains(clickLocation))
                        {
                            ClearPanels(panel);
                            index--;
                            if (index == -1)
                            {
                                resetbtn.PerformClick();
                            }
                        }
                    };
                }
            }

            else
            {
                MessageBox.Show("Please input a value in the textbox");
                searchcmb.SelectedIndex = 0;
            }
        }


        //Remove all search fields from the panel but store the results to be used later in a list 
        private void ClearPanels(Panel panel)
        {
            List<Panel> storedPanels = new List<Panel>();
            foreach (Control control in searchFieldpnl.Controls)
            {
                if (control is Panel innerPanel)
                {
                    storedPanels.Add(innerPanel);
                }
            }
            searchFieldpnl.Controls.Clear();
            //Deletes all fields, rewrites all panels back apart from the one the user crossed off
            int newX = 5;
            foreach (Panel innerPanel in storedPanels)
            {
                if (innerPanel != panel)
                {
                    innerPanel.Location = new Point(newX, 0);
                    searchFieldpnl.Controls.Add(innerPanel);
                    newX += innerPanel.Width + 10;
                }
            }

        }


        //When the mouse hovers over buttons it displays a annoying grey highlight - this removes it and allows for standard colour highlights
        public void TransparentBackground(Form form, params string[] buttonName) //params means array doesnt need to be created
        {
            foreach (string button in buttonName)
            {
                Control[] controls = form.Controls.Find(button, true);
                if (controls.Length > 0)
                {
                    Button background = (Button)controls[0];
                    background.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    background.FlatAppearance.MouseDownBackColor = Color.Transparent;
                    background.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
                }
            }
        }


        //Mimics the button pressing and the font changing colour to show this 
        private void ButtonPressedColourChange(object sender)
        {
            Button button = sender as Button;
            Timer timer = new Timer();
            timer.Interval = 80;
            button.ForeColor = Color.Turquoise;
            timer.Tick += (sender, e) =>
            {
                button.ForeColor = Color.White;
                timer.Stop();
                timer.Dispose();
            };
            timer.Start();
        }



        public void WIPgridview_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            GridviewCellPainting(WIPgridView, sender, e);
        }


        //Checks for the columns instorage and workstation - creating new paint objects for these
        public void GridviewCellPainting(DataGridView gridview, object sender, DataGridViewCellPaintingEventArgs e)
        {
            //for instorage instead of displaying 1's and 0's like the values in te SQL table - it replaces them with a cross for false and tick for true
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && gridview.Columns[e.ColumnIndex].Name == "InStorage")
            {
                e.PaintBackground(e.CellBounds, true);

                if (e.Value != null && e.Value is bool)
                {
                    //Makes sure the value pulled from SQL and stored in the gridview is a boolean value
                    bool value = (bool)e.Value;
                    Image image = value ? Properties.Resources.GreenTick : Properties.Resources.RedCross;

                    int desiredWidth = 25;
                    int desiredHeight = 25;
                    Image resizedImage = new Bitmap(image, desiredWidth, desiredHeight);

                    // Adjusts the position of the image
                    int x = e.CellBounds.Left + (e.CellBounds.Width - resizedImage.Width) / 2;
                    int y = e.CellBounds.Top + (e.CellBounds.Height - resizedImage.Height) / 2;

                    // Draws the image
                    e.Graphics.DrawImage(image, new Rectangle(x, y, resizedImage.Width, resizedImage.Height));

                    e.Handled = true;
                }
            }

            //Highlights the enter row of the cell which is equal to shipping in workstation - allows for quick visualisation
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && gridview.Columns[e.ColumnIndex].Name == "Workstation")
            {
                if ((string)gridview[e.ColumnIndex, e.RowIndex].Value == "Shipping")
                {
                    gridview.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Plum;
                }
            }

            //If the timestamp column has a null vlaue - it means this is the parts current location, here it draws this string to the empty string
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && gridview.Columns[e.ColumnIndex].Name == "WSTimestampOUT")
            {
                e.PaintBackground(e.CellBounds, true);

                if (gridview[e.ColumnIndex, e.RowIndex].Value == DBNull.Value)
                {
                    string displayText = "";

                    if ((bool)gridview[6, e.RowIndex].Value == true)
                    {
                        displayText = "Storage";
                    }

                    else
                    {
                        displayText = "Current Location";
                    }

                    using (StringFormat sf = new StringFormat())
                    {
                        sf.Alignment = StringAlignment.Center;
                        sf.LineAlignment = StringAlignment.Center;

                        using (Brush brush = new SolidBrush(e.CellStyle.ForeColor))
                        {
                            e.Graphics.DrawString(displayText, e.CellStyle.Font, brush, e.CellBounds, sf);
                            gridview.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.RebeccaPurple;
                        }
                    }

                    e.Handled = true;
                }
            }
        }
    }
}
