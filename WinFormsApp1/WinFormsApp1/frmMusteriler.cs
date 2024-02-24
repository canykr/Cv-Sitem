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


namespace WinFormsApp1
{
    public partial class frmMusteriler : Form
    {
        public frmMusteriler()
        {
            InitializeComponent();
        }
        private void frmMusteriler_Load(object sender, EventArgs e)
        {
            string connectionString = "server=DESKTOP-JSK0MB8;database=Northwind;Trusted_Connection=true;";
            string connectionString1 = "server=DESKTOP-JSK0MB8;database=Northwind;uid=sa;pwd=1";
            string connectionString2 = "server=DESKTOP-JSK0MB8;database=Northwind;user id=sa;password=1";
            SqlConnection connection = new SqlConnection(connectionString1);

            //SqlCommand sqlCommand = new SqlCommand("",connection);  
            SqlCommand sqlCommand = new SqlCommand("", connection);
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = "select CustomerID,CompanyName,ContactName,City,Country from dbo.Customers order by CompanyName";

            connection.Open();

            SqlDataReader reader = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CustomerID");
            dt.Columns.Add("CompanyName");
            dt.Columns.Add("City");
            dt.Columns.Add("Country");

            while (reader.Read())
            {
                dt.Rows.Add(reader["CustomerID"], reader["CompanyName"], reader["City"], reader["Country"]);
            }
            reader.Close();
            connection.Close();
            gridListe.DataSource = dt;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
