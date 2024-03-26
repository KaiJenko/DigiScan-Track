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
        private PartEditPage editPage;
        SqlConnection conn = new SqlConnection();

        public EditParts()
        {
            InitializeComponent();
            loadDepartmentcmb();
            partsToEditSQL();
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
            departmentcmbox.SelectedItem = departmentcmbox.Items[0].ToString();

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
            string[] departmentList = { "Nacelles", "Gears", "Military" };

            string[][] partNumbers = new string[3][];
            partNumbers[0] = new string[0] { };
            partNumbers[1] = new string[4] { "COG78643", "FYG345", "AAG320", "BIO879" };
            partNumbers[2] = new string[6] { "TYM93787", "AQM45", "TYM8143", "AUM15", "PLM258", "PGM55" };

            int index = Array.IndexOf(departmentList, chosenDepartment);

            for (int i = 0; i < partNumbers[index].Length; i++)
            {
                partNumbercmbox.Items.Add(partNumbers[index][i]);
            }
        }

        private void partsToEditSQL()
        {
            string pullPartsToEdit = "SELECT * FROM WIPTracking";
            sqlQuery(pullPartsToEdit, toEditGridView);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string department = departmentcmbox.Text;
            string partNumber = partNumbercmbox.Text;
            string serialNumber = searchtxt.Text;

            string query = "SELECT * FROM [WIPTracking] WHERE [Department] = '" + department + "'" +
                           "  AND [PartNumber] = '" + partNumber + "' AND [SerialNumber] = '" + serialNumber + "'";
            sqlQuery(query, toEditGridView);
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
            string boolStorage = toEditGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
            string serialNum = toEditGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            string inStorageMessage = "Do you want to put " + serialNum + " into storage";
            string outStorageMessage = "Do you want to remove " + serialNum + " out of storage";
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
                    xbtn.Visible = true;
                    xbtn.BringToFront();
                    editPage.BringToFront();

                }
            }

            else if (boolStorage == "False")
            {
                MessageBoxButtons msgbtn = MessageBoxButtons.YesNo;

                DialogResult result = MessageBox.Show(inStorageMessage, title, msgbtn);
                if (result == DialogResult.Yes)
                {

                }
            }

            else
            {
                MessageBox.Show(boolStorage);
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

        private void xbtn_Click(object sender, EventArgs e)
        {
            Control editPartsPage = InnerBorderpnl.Controls[0];
            InnerBorderpnl.Controls.Remove(editPartsPage);
            xbtn.Visible = false;
        }
    }
}