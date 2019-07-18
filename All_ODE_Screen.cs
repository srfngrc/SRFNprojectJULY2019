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
    public partial class All_ODE_Screen : Form
    {
        /// <summary>
        /// Summary of the description of the method defined ahead
        /// </summary>
        public All_ODE_Screen()
        {
            InitializeComponent();

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_EODE_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_EODE_add_Click(object sender, EventArgs e)
        {
            //SRFNprojectJULY2019proj.Program.NumOperationsAdded = 1;
            this.Close();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridView1.Datasource
        }

        public void BtnLoadDataFromDBcust_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection connecSRFN;
            //SqlCommand command;
            connetionString = "workstation id=DatabaseSRFN.mssql.somee.com;" +
                                "packet size=4096;" +
                                "user id=serafin;" +
                                "pwd=19771977;" +
                                "data source=DatabaseSRFN.mssql.somee.com;" +
                                "persist security info=False;" +
                                "initial catalog=DatabaseSRFN";

            connecSRFN = new SqlConnection(connetionString);

            SqlCommand command = new SqlCommand(
                //"SELECT customerId, customerName FROM Nutella.customers;", connecSRFN);
                "SELECT * FROM Nutella.operations;", connecSRFN);
            connecSRFN.Open();
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTableSRFN = new DataTable();

            //dataTableSRFN.Columns.Add("customerId", typeof(int));
            //dataTableSRFN.Rows.Add(1, "", "");

            dataTableSRFN.Load(reader);
            dataGridView1.DataSource = dataTableSRFN;


            //HasRows(connecSRFN);
        }

        static void HasRows(SqlConnection connection)
        {
            using (connection)
            {
                SqlCommand command = new SqlCommand(
                  "SELECT customerId, customerName FROM Nutella.customers;",
                  connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                      MessageBox.Show(String.Format("{0}\t{1}", reader[0].ToString(), reader[1].ToString()));
                    }
                }
                else
                {
                    MessageBox.Show("No rows found.");
                }
                reader.Close();
            }
        }

        private void BtnTRY_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection connecSRFN;
            connetionString = "workstation id=DatabaseSRFN.mssql.somee.com;" +
                                "packet size=4096;" +
                                "user id=serafin;" +
                                "pwd=19771977;" +
                                "data source=DatabaseSRFN.mssql.somee.com;" +
                                "persist security info=False;" +
                                "initial catalog=DatabaseSRFN";

            connecSRFN = new SqlConnection(connetionString);
            HasRows(connecSRFN);
        }
    }
}
