using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiScan_Track
{
    public partial class PartEditPage : UserControl
    {
        public PartEditPage(string serialNumber)
        {
            InitializeComponent();
            editPartDetailsSQL(serialNumber);

        }

        private void editPartDetailsSQL(string serialNumber)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source = Jenko\\MSSQLSERVER01; Initial Catalog=DigiTrackAndScan; Integrated Security = True;";
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM [WIPTracking] WHERE [SerialNumber] = '" + serialNumber + "'";
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            conn.Close();
            partTobeEditedGridView.DataSource = dt;
        }

        private void InputEdit_Click(object sender, EventArgs e)
        {
            DataGridViewCell partToBeEdited = partTobeEditedGridView.Rows[0].Cells[1];
            int count = 0;

            /*foreach (Control control in userInputpnl.Controls)
            {
                MessageBox.Show(control.Name);
            }*/
            string sqlquery = "";

            foreach (Control control in userInputpnl.Controls)
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
            SqlDataReader dr = cmd.ExecuteReader();

                

        }
    }
}
