using Microsoft.VisualBasic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace DigiScan_Track
{
    public partial class EditParts : Form
    {
        SqlConnection conn = new SqlConnection();
        public EditParts()
        {
            InitializeComponent();
            loadDepartmentcmb();
            loadsecondDepartmentcmb();
            partsToEditSQL();
            HomePageShortcuts homePageShortcuts = new HomePageShortcuts();
            WIPTracker wiptracker = new WIPTracker(null, null);
            departmentcmbox.DrawItem += homePageShortcuts.ComboBox_DrawItem;
            addPartcmbox.DrawItem += homePageShortcuts.ComboBox_DrawItem;
            partNumbercmbox.DrawItem += homePageShortcuts.ComboBox_DrawItem;
            toEditGridView.CellPainting += wiptracker.WIPgridView_CellPainting;
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
            while (dr.Read())
            {
                departmentcmbox.Items.Add(dr["Department"].ToString());

            }
            conn.Close();

            departmentcmbox.SelectedIndex = 0;


        }

        private void loadsecondDepartmentcmb()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source = Jenko\\MSSQLSERVER01; Initial Catalog=DigiTrackAndScan; Integrated Security = True;";
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Distinct(Department) FROM Departments";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                addPartcmbox.Items.Add(dr["Department"].ToString());

            }
            conn.Close();

            addPartcmbox.SelectedIndex = 0;

        }

        private void departmentcmbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (departmentcmbox.Text != null)
            {
                string chosenDepartment = departmentcmbox.Text.ToString();
                partNumbercmbox.Enabled = true;
                partNumbercmbox.Items.Clear();
                loadDetails(chosenDepartment);
            }
        }

        private void loadDetails(string chosenDepartment)
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

        private void partsToEditSQL()
        {
            string pullPartsToEdit = "SELECT [SerialNumber], [PartNumber], [BatchNumber], [Department], [InStorage] FROM WIPTracking";
            sqlQuery(pullPartsToEdit, toEditGridView);
            partsToEditLayout();
        }

        private void partsToEditLayout()
        {
            toEditGridView.Columns[0].HeaderText = "Serial No";
            toEditGridView.Columns[1].HeaderText = "Part No";
            toEditGridView.Columns[2].HeaderText = "Batch No";
            toEditGridView.Columns[3].HeaderText = "Department";
            toEditGridView.Columns[4].HeaderText = "In Storage";

            toEditGridView.Columns[0].Width = 103;
            toEditGridView.Columns[1].Width = 103;
            toEditGridView.Columns[2].Width = 103;
            toEditGridView.Columns[3].Width = 100;
            toEditGridView.Columns[4].Width = 80;

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string SQLQuery = "";
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
                sqlQuery(SQLQuery, toEditGridView);
            }

            else
            {
                SQLQuery = "SELECT * FROM [WIPTracking] WHERE [Department] = '" + department + "'" +
                           " AND [PartNumber] = '" + partNumber + "' AND [SerialNumber] = '" + serialNumber + "'";
                sqlQuery(SQLQuery, toEditGridView);
            }
        }

        private void sqlQuery(string command, DataGridView gridview)
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

        private void toEditGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void crossOffpbox_Click(object sender, EventArgs e)
        {
            Control editPartsPage = InnerBorderpnl.Controls[0];
            InnerBorderpnl.Controls.Remove(editPartsPage);
            crossOffpbox.Visible = false;
        }

        public void toEditGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void submitAddpbox_Click(object sender, EventArgs e)
        {
            string department = addPartcmbox.SelectedItem.ToString();
            string partNum = addParttxt.Text;

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

        private void toEditgridview_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                toEditGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Coral;
            }
        }

        private void toEditgridview_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                toEditGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.White;
            }
        }

    }
}