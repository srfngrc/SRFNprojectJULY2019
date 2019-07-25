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
            DataLoad();
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

        private void DataLoad()
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

            SqlCommand command = new SqlCommand(
                "SELECT * FROM Nutella.operations;", connecSRFN);
            SqlCommand commandAdd = new SqlCommand(
                "SELECT sum(CAST (replace(amount, ',', '.') AS NUMERIC(10,2))) " +
                "FROM Nutella.Operations;", connecSRFN);

            try
            {
                connecSRFN.Open();
                SqlDataReader reader = command.ExecuteReader();
                DataTable dataTableSRFN = new DataTable();

                dataTableSRFN.Load(reader);
                dataGridView1.DataSource = dataTableSRFN;

                SqlDataReader readerOftheSUM = commandAdd.ExecuteReader();
                while (readerOftheSUM.Read())
                {
                    string myString = readerOftheSUM[0].ToString();
                    //MessageBox.Show("la consulta de SUMA a la basedeDatos da: " + myString);
                    TBsumatory.Text = myString;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connecSRFN.State == ConnectionState.Open)
                {
                    connecSRFN.Close();
                }
            }

        }

    }
}
