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

namespace SRFNprojectJULY2019proj
{
    public partial class ManageAppUsers : Form
    {
        static string connectionSRFN = "Server=DatabaseSRFN.mssql.somee.com;" +
            "Database=DatabaseSRFN;" +
            "User Id=serafin; "+
            "Password=19771977;";
        SqlConnection connect123 = new SqlConnection(connectionSRFN);
        
        public ManageAppUsers()
        {
            InitializeComponent();
            LoadDataGrid_logins();
        }

        public void LoadDataGrid_logins()
        {
            try
            {
                string myquery = "select * from Nutella.logins;";
                SqlCommand mycommand = new SqlCommand(myquery, connect123);
                connect123.Open();

                SqlDataReader WhatsRead = mycommand.ExecuteReader();
                DataTable tabla = new DataTable();
                tabla.Load(WhatsRead);
                dataGridView1.DataSource = tabla;
            }
            catch( Exception ex2)
            {
                MessageBox.Show(ex2.Message);
            }
            finally
            {
                if (connect123.State == ConnectionState.Open)
                {
                    connect123.Close();
                }
            }
        }
    }
}
