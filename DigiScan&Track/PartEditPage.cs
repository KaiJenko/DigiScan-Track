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
            userInputSQL();
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

        private void userInputSQL()
        {
            
        }
    }
}
