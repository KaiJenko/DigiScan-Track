using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DigiScan_Track
{
    public partial class PartEditPage : UserControl
    {
        public PartEditPage(string serialNumber)
        {
            InitializeComponent();
            editPartDetailsSQL(serialNumber);
            furtherEditPartsSQL(serialNumber);
        }

        private void editPartDetailsSQL(string serialNumber)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source = Jenko\\MSSQLSERVER01; Initial Catalog=DigiTrackAndScan; Integrated Security = True;";

            DataTable dt = new DataTable();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM [WIPTracking] WHERE [SerialNumber] = '" + serialNumber + "'";
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            conn.Close();
            partTobeEditedGridView.DataSource = dt;
            partsEditLayout();

        }

        private void furtherEditPartsSQL(string serialNumber)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source = Jenko\\MSSQLSERVER01; Initial Catalog=DigiTrackAndScan; Integrated Security = True;";

            DataTable dt = new DataTable();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT [DateEnteredStorage], [ReasonForStorage], [UserWhoInputted] FROM [AgedWIP] WHERE [SerialNumber] = '" + serialNumber + "'";
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            conn.Close();
            furtherDetailsgridview.DataSource = dt;
            furtherDetailsLayout();

            if (furtherDetailsgridview.Rows.Count == 0)
            {
                furtherDetailsgridview.Visible = false;
                furtherDetailspnl.Visible = false;
            }
        }


        private void InputEdit_Click(object sender, EventArgs e)
        {
            int repeat = 0;
            foreach (Control control in userInputpnl.Controls)
            {

                if (control is RichTextBox richTextBox)
                {
                    if (!string.IsNullOrWhiteSpace(richTextBox.Text))
                    {

                        DataGridViewCell partToBeEdited = partTobeEditedGridView.Rows[0].Cells[1];
                        int count = 0;

                        string sqlquery = "";

                        foreach (Control userControl in userInputpnl.Controls)
                        {

                            if (control is CheckBox)
                            {
                                CheckBox checkbox = control as CheckBox;
                                if (checkbox.Checked)
                                {
                                    sqlquery += " [" + checkbox.Tag + "] = 1";
                                }

                                else if (checkbox.Checked = false)
                                {
                                    sqlquery += " [" + checkbox.Tag + "] = 0";
                                }
                            }

                            else if (control is RichTextBox)
                            {
                                RichTextBox richtextbox = control as RichTextBox;
                                if (richtextbox.Text != "")
                                {
                                    if (count == 0)
                                    {
                                        sqlquery += " [" + richtextbox.Tag + "] = '" + richtextbox.Text + "'";
                                        count++;
                                    }

                                    else if (count > 0)
                                    {
                                        sqlquery += " , [" + richtextbox.Tag + "] = '" + richtextbox.Text + "'";
                                        count++;
                                    }

                                }

                            }

                        }

                        DataTable dt = new DataTable();
                        SqlConnection conn = new SqlConnection();
                        conn.ConnectionString = "Data Source = Jenko\\MSSQLSERVER01; Initial Catalog=DigiTrackAndScan; Integrated Security = True;";
                        conn.Open();
                        string sqlUpdate = "UPDATE [WIPTracking] SET " + sqlquery + " WHERE [SerialNumber] = '" + partToBeEdited.Value.ToString() + "'";
                        SqlCommand cmd = new SqlCommand(sqlUpdate, conn);
                        cmd.ExecuteNonQuery();
                    }                                  
                    
                    else
                    {
                        if (repeat == 0)
                        {
                            MessageBox.Show("Please input at least one different value");
                            repeat++;
                        }
                    }
                }
            }
        }

        private void partsEditLayout()
        {
            partTobeEditedGridView.Columns[0].HeaderText = "Part No";
            partTobeEditedGridView.Columns[1].HeaderText = "Serial No";
            partTobeEditedGridView.Columns[2].HeaderText = "Batch No";
            partTobeEditedGridView.Columns[3].HeaderText = "Department";
            partTobeEditedGridView.Columns[4].HeaderText = "Workstation";
            partTobeEditedGridView.Columns[5].HeaderText = "Time In";
            partTobeEditedGridView.Columns[6].HeaderText = "Time Out";
            partTobeEditedGridView.Columns[7].HeaderText = "In Storage";

            partTobeEditedGridView.Columns[0].Width = 110;
            partTobeEditedGridView.Columns[1].Width = 110;
            partTobeEditedGridView.Columns[2].Width = 110;
            partTobeEditedGridView.Columns[3].Width = 120;
            partTobeEditedGridView.Columns[4].Width = 130;
            partTobeEditedGridView.Columns[5].Width = 140;
            partTobeEditedGridView.Columns[6].Width = 140;
            partTobeEditedGridView.Columns[7].Width = 90;

        }

        private void furtherDetailsLayout()
        {
            furtherDetailsgridview.Columns[0].HeaderText = "Storage Date";
            furtherDetailsgridview.Columns[1].HeaderText = "Reason";
            furtherDetailsgridview.Columns[2].HeaderText = "User";

            furtherDetailsgridview.Columns[0].Width = 150;
            furtherDetailsgridview.Columns[1].Width = 200;
            furtherDetailsgridview.Columns[2].Width = 150;
        }
    }
}
