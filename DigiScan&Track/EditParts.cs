using System.Data;
using System.Data.SqlClient;


namespace DigiScan_Track
{
    public partial class EditParts : Form
    {
        SqlConnection conn = new SqlConnection();
        HomePageShortcuts homePageShortcuts = new HomePageShortcuts();
        WIPTracker wiptracker = new WIPTracker(null, null);
        public EditParts()
        {
            InitializeComponent();
            LoadDepartmentcmbSQL();
            PartsToEditSQL();



            departmentcmbox.DrawItem += homePageShortcuts.ComboBox_DrawItem;
            addPartcmbox.DrawItem += homePageShortcuts.ComboBox_DrawItem;
            partNumbercmbox.DrawItem += homePageShortcuts.ComboBox_DrawItem;
            toEditGridView.CellPainting += wiptracker.WIPgridView_CellPainting;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



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
                departmentcmbox.Items.Add(dr["Department"].ToString());
                addPartcmbox.Items.Add(dr["Department"].ToString());

            }
            conn.Close();

            departmentcmbox.SelectedIndex = 0;
            addPartcmbox.SelectedIndex = 0;
        }



        private void Departmentcmbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (departmentcmbox.Text != null)
            {
                string chosenDepartment = departmentcmbox.Text.ToString();
                partNumbercmbox.Enabled = true;
                partNumbercmbox.Items.Clear();
                LoadDetails(chosenDepartment);
            }
        }



        private void LoadDetails(string chosenDepartment)
        {
            int countDepartments = departmentcmbox.Items.Count;
            string[] departmentList = new string[countDepartments];

            for (int x = 0; x < countDepartments; x++)
            {
                string department = departmentcmbox.Items[x].ToString();
                departmentList[x] = department;
            }

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source = Jenko\\MSSQLSERVER01; Initial Catalog=DigiTrackAndScan; Integrated Security = True;";
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();

            string[] partNumbers = new string[countDepartments];

            for (int x = 0; x < countDepartments; x++)
            {
                string department = departmentcmbox.Items[x].ToString();

                cmd.CommandText = "SELECT [PartNumber] FROM PartNumbers WHERE [Department] = @Department";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Department", department);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    List<string> str = new List<string>();
                    while (dr.Read())
                    {
                        str.Add(dr["PartNumber"].ToString());
                    }
                    partNumbers[x] = string.Join(",", str);
                }
            }

            int index = Array.IndexOf(departmentList, chosenDepartment);

            string[] arraySplit = partNumbers[index].Split(new string[] { "," }, StringSplitOptions.None);

            for (int x = 0; x < arraySplit.Length; x++)
            {
                partNumbercmbox.Items.Add(arraySplit[x]);
            }
            partNumbercmbox.SelectedIndex = 0;
            partNumbercmbox.SelectedItem = Color.FromArgb(255, 46, 51, 73);
        }



        private void PartsToEditSQL()
        {
            string pullPartsToEdit = "SELECT [SerialNumber], [PartNumber], [BatchNumber], [Department], [InStorage] FROM WIPTracking";
            SqlQuery(pullPartsToEdit, toEditGridView);
            PartsToEditLayout();
        }



        private void PartsToEditLayout()
        {
            toEditGridView.Columns[0].HeaderText = "Serial No";
            toEditGridView.Columns[1].HeaderText = "Part No";
            toEditGridView.Columns[2].HeaderText = "Batch No";
            toEditGridView.Columns[3].HeaderText = "Department";
            toEditGridView.Columns[4].HeaderText = "In Storage";

            wiptracker.TurnColumnIntoPercent(toEditGridView, 21, 21, 20, 22, 16);

        }



        private void SearchButton_Click(object sender, EventArgs e)
        {
            string SQLQuery;
            string department = departmentcmbox.Text;
            string partNumber = partNumbercmbox.Text;
            string serialNumber = searchtxt.Text;

            if (partNumber == "")
            {
                MessageBox.Show("Please choose a part number to search for");
            }

            else if (serialNumber == "")
            {
                SQLQuery = " SELECT [SerialNumber], [PartNumber], [BatchNumber], [Department], [InStorage] FROM WIPTracking" +
                           " WHERE [Department] = '" + department + "'" +
                           " AND [PartNumber] = '" + partNumber + "'";
                SqlQuery(SQLQuery, toEditGridView);
            }

            else
            {
                SQLQuery = "SELECT * FROM [WIPTracking] WHERE [Department] = '" + department + "'" +
                           " AND [PartNumber] = '" + partNumber + "' AND [SerialNumber] = '" + serialNumber + "'";
                SqlQuery(SQLQuery, toEditGridView);
            }
        }



        private void SqlQuery(string command, DataGridView gridview)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source = Jenko\\MSSQLSERVER01; Initial Catalog=DigiTrackAndScan; Integrated Security = True;";
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = command;
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            conn.Close();
            gridview.DataSource = dt;
        }



        private void ToEditGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string boolStorage = toEditGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            string serialNum = toEditGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            string inStorageMessage = "This part: " + serialNum + " is not in storage, would you like to edit this";
            string outStorageMessage = "This part " + serialNum + " is in storage, would you like to edit this";
            string title = "Edit Part";

            if (boolStorage == "True")
            {
                MessageBoxButtons msgbtn = MessageBoxButtons.YesNo;

                DialogResult result = MessageBox.Show(outStorageMessage, title, msgbtn);
                if (result == DialogResult.Yes)
                {

                    PartEditPage editPage = new PartEditPage(serialNum);
                    editPage.Dock = DockStyle.Fill;
                    this.InnerBorderpnl.Controls.Add(editPage);
                    crossOffpbox.Visible = true;
                    crossOffpbox.BringToFront();
                    editPage.BringToFront();

                }
            }

            else if (boolStorage == "False")
            {
                MessageBoxButtons msgbtn = MessageBoxButtons.YesNo;

                DialogResult result = MessageBox.Show(inStorageMessage, title, msgbtn);
                if (result == DialogResult.Yes)
                {
                    PartEditPage editPage = new PartEditPage(serialNum);
                    editPage.Dock = DockStyle.Fill;
                    this.InnerBorderpnl.Controls.Add(editPage);
                    crossOffpbox.Visible = true;
                    crossOffpbox.BringToFront();
                    editPage.BringToFront();
                }
            }

            else
            {
                MessageBox.Show(boolStorage);
            }
        }



        private void CrossOffpbox_Click(object sender, EventArgs e)
        {
            Control editPartsPage = InnerBorderpnl.Controls[0];
            InnerBorderpnl.Controls.Remove(editPartsPage);
            crossOffpbox.Visible = false;
        }



        public void ToEditGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && toEditGridView.Columns[e.ColumnIndex].Name == "InStorage")
            {
                e.PaintBackground(e.CellBounds, true);

                if (toEditGridView[e.ColumnIndex, e.RowIndex].Value != DBNull.Value)
                {
                    bool isChecked = (bool)toEditGridView[e.ColumnIndex, e.RowIndex].Value;
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



        private void SubmitAddpbox_Click(object sender, EventArgs e)
        {
            string department = addPartcmbox.SelectedItem.ToString();
            string partNum = addParttxt.Text;
            try
            {
                if (partNum != "")
                {
                    string message = "Do you want to insert part number: " + partNum + " into: " + department;
                    string title = "Add New Part Number to: " + department;
                    MessageBoxButtons msgbtn = MessageBoxButtons.YesNo;

                    DialogResult result = MessageBox.Show(message, title, msgbtn);
                    if (result == DialogResult.Yes)
                    {

                        conn.ConnectionString = "Data Source = Jenko\\MSSQLSERVER01; Initial Catalog=DigiTrackAndScan; Integrated Security = True;";
                        conn.Open();
                        string sqlInsert = "INSERT INTO [PartNumbers] (Department, PartNumber)" +
                                            " VALUES (@Department, @PartNumber)";
                        SqlCommand cmd = new SqlCommand(sqlInsert, conn);

                        cmd.Parameters.AddWithValue("@Department", department);
                        cmd.Parameters.AddWithValue("@PartNumber", partNum);

                        cmd.ExecuteNonQuery();

                        addParttxt.Clear();
                        MessageBox.Show("You have inputted a new part");
                    }
                }

                else
                {
                    MessageBox.Show("Please input a part number");
                }
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show("ERROR: This part is already in the database");
            }
        }



        private void ToEditgridview_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                toEditGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Coral;
            }
        }



        private void ToEditgridview_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                toEditGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.White;
            }
        }

    }
}