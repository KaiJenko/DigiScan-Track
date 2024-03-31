using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;
using System.Windows.Forms;
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
            getSQLWIPTracker(sentDepartment, sentWorkstation);
            HomePageShortcuts homePageShortcuts = new HomePageShortcuts();
            searchcmb.DrawItem += homePageShortcuts.ComboBox_DrawItem;
            searchcmb.SelectedIndex = 0;
            transparentBackground(this, "searchbtn", "resetbtn", "addFieldbtn", "bottomLeftBorderbtn");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void create_defaultGridView_WIP()
        {

            WIPgridView.Columns[0].HeaderText = "Part No";
            WIPgridView.Columns[1].HeaderText = "Serial No";
            WIPgridView.Columns[2].HeaderText = "Batch No";
            WIPgridView.Columns[3].HeaderText = "Department";
            WIPgridView.Columns[4].HeaderText = "Workstation";
            WIPgridView.Columns[5].HeaderText = "Time in";
            WIPgridView.Columns[6].HeaderText = "Time out";
            WIPgridView.Columns[7].HeaderText = "Storage";

            WIPgridView.Columns[0].Width = 118;
            WIPgridView.Columns[1].Width = 118;
            WIPgridView.Columns[2].Width = 118;
            WIPgridView.Columns[3].Width = 110;
            WIPgridView.Columns[4].Width = 128;
            WIPgridView.Columns[5].Width = 150;
            WIPgridView.Columns[6].Width = 150;
            WIPgridView.Columns[7].Width = 70;

            WIPgridView.ColumnHeadersDefaultCellStyle.Font = new Font(WIPgridView.Font.FontFamily, 12, FontStyle.Bold);
            WIPgridView.ColumnHeadersHeight = 50;

        }

        private void create_customGridView_WIP()
        {

            WIPgridView.Columns[0].HeaderText = "Part No";
            WIPgridView.Columns[1].HeaderText = "Serial No";
            WIPgridView.Columns[2].HeaderText = "Batch No";
            WIPgridView.Columns[3].HeaderText = "Time in";
            WIPgridView.Columns[4].HeaderText = "Time out";
            WIPgridView.Columns[5].HeaderText = "Storage";

            WIPgridView.Columns[0].Width = 160;
            WIPgridView.Columns[1].Width = 160;
            WIPgridView.Columns[2].Width = 160;
            WIPgridView.Columns[3].Width = 160;
            WIPgridView.Columns[4].Width = 160;
            WIPgridView.Columns[5].Width = 85;

            WIPgridView.ColumnHeadersDefaultCellStyle.Font = new Font(WIPgridView.Font.FontFamily, 12, FontStyle.Bold);
            WIPgridView.ColumnHeadersHeight = 50;

        }

        private void getSQLWIPTracker(string department, string workstation)
        {
            string cmdText = "";

            if (department == null && workstation == null)
            {
                departmentlbl.Text = "";
                workstationlbl.Text = "";

                cmdText = "SELECT TOP(1000)[PartNumber] ,[SerialNumber] ,[BatchNumber] ,[Department] ,[Workstation] " +
                          " ,[WSTimestampIN] ,[WSTimestampOUT] ,[InStorage] FROM [WIPTracking]";
                defaultOrCustom = 0;

            }

            else if (department != null || workstation != null)
            {
                departmentlbl.Text = "DP:  " + department;
                workstationlbl.Text = "WS:  " + workstation;
                cmdText = "SELECT TOP(1000)[PartNumber] ,[SerialNumber] ,[BatchNumber]" +
                          " ,[WSTimestampIN] ,[WSTimestampOUT] ,[InStorage] FROM [WIPTracking] WHERE [Department] = '" + department + "'" +
                          " AND [Workstation] = '" + workstation + "'";
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
                create_defaultGridView_WIP();
            }

            else
            {
                create_customGridView_WIP();
            }

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            buttonPressedColourChange(sender);

            string searchval = searchtxt.Text.Trim();
            string dropdownSelection = searchcmb.Text.Replace(" ", "");

            if (searchval != "" && dropdownSelection != "")
            {
                addFieldbtn_Click(sender, e);

                int index = 0;
                string sqlQuery = "";

                foreach (Panel panel in searchFieldpnl.Controls)
                {
                    foreach (Label label in panel.Controls.OfType<Label>())
                    {
                        string labelOutput = label.Text.ToString();
                        string[] parts = labelOutput.Split(new string[] { " - " }, StringSplitOptions.None);
                        string SearchField = parts[0];
                        string SearchValue = parts[1];

                        if (index == 0)
                        {
                            sqlQuery = "WHERE [" + SearchField + "] LIKE '%" + SearchValue + "%'"; // do i need '
                            index++;
                        }

                        else if (index != 0)
                        {
                            sqlQuery += " AND [" + SearchField + "] LIKE '%" + searchval + "%'";
                        }

                        if (defaultOrCustom == 1)
                        {
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
                    cmd.CommandText = "SELECT TOP (1000) [PartNumber] ,[SerialNumber] ,[BatchNumber] ,[Department] ,[Workstation] " +
                                      ",[WSTimestampIN] ,[WSTimestampOUT] ,[InStorage] FROM [WIPTracking] " +
                                      sqlQuery;

                    cmd.Parameters.AddWithValue("@SQLSearchQuery", sqlQuery); //reduces SQL injection
                    SqlDataReader dr = cmd.ExecuteReader();

                    dt.Load(dr);

                    con.Close();

                    WIPgridView.DataSource = dt;
                    create_defaultGridView_WIP();
                }

                else
                {
                    cmd.CommandText = "SELECT TOP (1000) [PartNumber] ,[SerialNumber] ,[BatchNumber]" +
                                     ",[WSTimestampIN] ,[WSTimestampOUT] ,[InStorage] FROM [WIPTracking] " +
                                     sqlQuery;

                    cmd.Parameters.AddWithValue("@SQLSearchQuery", sqlQuery); //reduces SQL injection
                    SqlDataReader dr = cmd.ExecuteReader();

                    dt.Load(dr);

                    con.Close();

                    WIPgridView.DataSource = dt;
                    create_customGridView_WIP();
                }

            }

            else
            {
                MessageBox.Show("Please input a value into the search query");
            }
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            buttonPressedColourChange(sender);
            searchFieldpnl.Controls.Clear();
            getSQLWIPTracker(null, null);
            defaultOrCustom = 0;
        }


        private void addFieldbtn_Click(object sender, EventArgs e)
        {
            buttonPressedColourChange(sender);
            string searchField = searchcmb.Text.Replace(" ", "");
            string searchValue = searchtxt.Text.Trim();

            searchcmb.Text = null;
            searchtxt.Text = null;

            int index = searchFieldpnl.Controls.Count;

            if (index == 3)
            {
                MessageBox.Show("No more search fields can be added");
            }

            else
            {
                Panel panel = new Panel();
                panel.Name = "InnerPanel" + index;
                panel.BackgroundImage = Properties.Resources.blueBorder;
                panel.BackgroundImageLayout = ImageLayout.Stretch;
                panel.MinimumSize = new Size(0, 25);
                panel.MaximumSize = new Size(500, 25);

                Label searchFieldLabel = new Label();
                searchFieldLabel.Text = searchField + " - " + searchValue;
                searchFieldLabel.ForeColor = Color.White;
                searchFieldLabel.BackColor = Color.Transparent;
                searchFieldLabel.Padding = new Padding(10, 0, 0, 0);
                searchFieldLabel.AutoSize = true;

                PictureBox redCrosspbox = new PictureBox();
                redCrosspbox.Image = Properties.Resources.cross;
                redCrosspbox.SizeMode = PictureBoxSizeMode.StretchImage;
                redCrosspbox.Size = new Size(15, 15);
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
                        clearPanels(panel);
                        index--;
                    }
                };
            }
        }

        private void clearPanels(Panel panel)
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

        public void transparentBackground(Form form, params string[] buttonName) //params means array doesnt need to be created
        {
            string newbtn = buttonName[0];
            foreach (string button in buttonName)
            {
                Control[] controls = form.Controls.Find(button, true);
                if (controls.Length > 0)
                {
                    Button background = (Button)controls[0];
                    background.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
                    background.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
                    background.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
                }
            }
        }

        private void buttonPressedColourChange(object sender)
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

        public void WIPgridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && WIPgridView.Columns[e.ColumnIndex].Name == "InStorage")
            {
                e.PaintBackground(e.CellBounds, true);

                if (WIPgridView[e.ColumnIndex, e.RowIndex].Value != DBNull.Value)
                {
                    bool isChecked = (bool)WIPgridView[e.ColumnIndex, e.RowIndex].Value;
                    string displayText = isChecked ? "Yes" : "No";
                    using (StringFormat sf = new StringFormat())
                    {
                        sf.Alignment = StringAlignment.Center;
                        sf.LineAlignment = StringAlignment.Center;

                        using (Brush brush = new SolidBrush(e.CellStyle.ForeColor))
                        {
                            e.Graphics.DrawString(displayText, e.CellStyle.Font, brush, e.CellBounds, sf);
                        }
                    }

                    e.Handled = true;
                }
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


    }


}
