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
            transparentBackground("searchbtn", "resetbtn", "addFieldbtn", "bottomLeftBorderbtn");
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

            WIPgridView.Columns[0].Width = 150;
            WIPgridView.Columns[1].Width = 150;
            WIPgridView.Columns[2].Width = 150;
            WIPgridView.Columns[3].Width = 150;
            WIPgridView.Columns[4].Width = 150;
            WIPgridView.Columns[5].Width = 150;
            WIPgridView.Columns[6].Width = 150;
            WIPgridView.Columns[7].Width = 75;

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

            WIPgridView.Columns[0].Width = 150;
            WIPgridView.Columns[1].Width = 150;
            WIPgridView.Columns[2].Width = 150;
            WIPgridView.Columns[3].Width = 150;
            WIPgridView.Columns[4].Width = 150;
            WIPgridView.Columns[5].Width = 75;

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

                foreach (Label label in searchFieldpnl.Controls)
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

            if (index == 0)
            {
                /*Panel panel = new Panel();
                panel.BackgroundImage = Properties.Resources.blueBorder;
                panel.BackgroundImageLayout = ImageLayout.Stretch;
                panel.Size = new Size(200, 25);
                panel.AutoSize = true;

                Button field = new Button();
                field.Name = "label" + index;
                field.ForeColor = Color.White;
                field.Text = searchField + " - " + searchValue;
                field.AutoSize = true;
                field.BackColor = Color.Transparent;
                field.FlatStyle = FlatStyle.Flat;
                field.Padding = new Padding(5, 0, 0, 0);


                PictureBox pic = new PictureBox();
                pic.BackgroundImage = Properties.Resources.cross;
                pic.BackgroundImageLayout = ImageLayout.Stretch;
                pic.Size = new Size(15, 15);
                pic.Cursor = Cursors.Hand;
                pic.BackColor = Color.Transparent;
                pic.Padding = new Padding(20,0,0,0);

                pic.MouseDown += (sender, e) =>
                {
                    Point clickLocation = pic.PointToClient(Cursor.Position);
                    if (new Rectangle(Point.Empty, pic.Size).Contains(clickLocation))
                    {
                        MessageBox.Show("Image clicked!");
                    }
                };

                panel.Controls.Add(pic);
                panel.Controls.Add(field);*/

                Panel panel = new Panel();

                panel.BackgroundImage = Properties.Resources.blueBorder;
                panel.BackgroundImageLayout = ImageLayout.Stretch;
                panel.MinimumSize = new Size(0, 25);
                panel.MaximumSize = new Size(500, 25);

                Label label = new Label();
                label.Name = "label" + index;
                label.Text = searchField + " - " + searchValue;
                label.ForeColor = Color.White;
                label.BackColor = Color.Transparent;
                label.Padding = new Padding(10, 0, 0, 0);
                label.AutoSize = true;

                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Properties.Resources.cross;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Size = new Size(15, 15);
                pictureBox.Cursor = Cursors.Hand;

                panel.Controls.Add(label);
                panel.Controls.Add(pictureBox);

                label.Location = new Point(5, 5);
                pictureBox.Location = new Point(label.Right, 5);
                pictureBox.Padding = new Padding(1, 1, 1, 1);

                panel.Size = new Size(pictureBox.Right + 15, 25);

                pictureBox.MouseDown += (sender, e) =>
                {
                    Point clickLocation = pictureBox.PointToClient(Cursor.Position);
                    if (new Rectangle(Point.Empty, pictureBox.Size).Contains(clickLocation))
                    {
                        MessageBox.Show("Image clicked!");
                    }
                };

                /*  panel.Controls.Add(label);
                  panel.Controls.Add(pictureBox);*/
                searchFieldpnl.Controls.Add(panel);


                /*    ImageList imageList = new ImageList();
                    imageList.Images.Add(Properties.Resources.cross);*/

                /*field.ImageAlign = ContentAlignment.MiddleRight;
                field.ImageIndex = 0;
                field.Image = imageList.Images[0];*/
                /*
                                field.MouseDown += (sender, e) =>
                                {
                                    foreach(Control control in field)
                                    {

                                    }

                                    if (new Rectangle(Point.Empty, field.Size).Contains(clickLocation))
                                    {
                                        MessageBox.Show("Image clicked!");
                                    }
                                };*/


                /* transparentBackground(field.Name);*/
            }

            else
            {
                if (index < 4)
                {
                    Button field = new Button();
                    field.Name = "label" + index;
                    field.ForeColor = Color.White;
                    field.Text = searchField + " - " + searchValue;
                    field.MaximumSize = new Size(200, 28);
                    field.MinimumSize = new Size(50, 28);
                    field.AutoSize = true;
                    field.BackColor = Color.Transparent;
                    field.FlatStyle = FlatStyle.Flat;
                    field.BackgroundImage = Properties.Resources.blueBorder;
                    field.BackgroundImageLayout = ImageLayout.Stretch;
                    field.Padding = new Padding(5, 0, 30, 0);
                    Button oldLabel = (Button)searchFieldpnl.Controls["label" + (index - 1)];
                    field.Location = new Point(oldLabel.Right + 10, oldLabel.Top);



                    searchFieldpnl.Controls.Add(field);
                    transparentBackground(field.Name);
                }

                else
                {
                    MessageBox.Show("No More Search Fields Can Be Added!");
                }
            }
        }

        private void image_click()
        {

        }

        public void transparentBackground(params string[] buttonName) //params means array doesnt need to be created
        {
            string hi = buttonName[0];
            foreach (string button in buttonName)
            {
                Control[] controls = this.Controls.Find(button, true);
                Button background = (Button)controls[0];
                background.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
                background.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
                background.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
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
