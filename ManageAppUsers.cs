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
                DataGridViewLOGINS.DataSource = tabla;
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


        private void ClearDataLOGINS()
        {
            TBloginId.Text = "";
            textBox2.Text = "";
            textBox3.ResetText();
            textBox4.ResetText();
            textBox5.Text = "";
        }

        private void BTNok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectionChangetLOGINS(object sender, EventArgs e)
        {
            if (DataGridViewLOGINS.SelectedRows.Count > 0)
            {
                MessageBox.Show("AAAAAAAAAAAAAAAAAAAAAAAA" + DataGridViewLOGINS.SelectedRows[0].Cells[0].Value);
                TBloginId.Text = DataGridViewLOGINS.SelectedRows[0].Cells[0].Value + string.Empty;
                textBox2.Text = DataGridViewLOGINS.SelectedRows[0].Cells[1].Value + string.Empty;
                textBox3.Text = DataGridViewLOGINS.SelectedRows[0].Cells[2].Value.ToString() + string.Empty;
                textBox4.Text = DataGridViewLOGINS.SelectedRows[0].Cells[3].Value.ToString() + string.Empty;
                textBox5.Text = DataGridViewLOGINS.SelectedRows[0].Cells[4].Value.ToString() + string.Empty;
                //TBdescription.Text = DataGridViewLOGINS.SelectedRows[0].Cells[5].Value.ToString() + String.Empty;
            }
        }

        private void DataGridViewLOGINS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //UPDATE A LOGIN
        private void PBupdateLogins_Click(object sender, EventArgs e)
        {

        }

        //DELETE A LOGIN
        private void PBdeleteLogins_Click(object sender, EventArgs e)
        {

        }
    }
}
