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
    public partial class Insert_Each_ODE : Form
    {
        public Insert_Each_ODE()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string connetionString3 = null;
            SqlConnection connecSRFN3;
            SqlCommand command3;
            string tax_sql = null;
            //MessageBox.Show("the values received from the windows form are: " + textISINnumber.Text + "......" + textAmount.Text + "......" + textDescripODE.Text);
            MessageBox.Show("the values received from the windows form are: " + textISINnumber.Text + "......" + textAmount.Text + "......" + textDescripODE.Text + ";;;;;;;;" + dateTimePicker1.Value.ToString("yyyy-MM-dd"));

            connetionString3 = "workstation id=DatabaseSRFN.mssql.somee.com;" +
                                "packet size=4096;" +
                                "user id=serafin;" +
                                "pwd=19771977;" +
                                "data source=DatabaseSRFN.mssql.somee.com;" +
                                "persist security info=False;" +
                                "initial catalog=DatabaseSRFN";
            //tax_sql = "select * from Nutella.customers";
            //tax_sql = "insert into Nutella.customers (customerId,customerName) values (3,'customer name 3')";
            tax_sql = "insert into Nutella.operations(isin, purchaseDate, sellDate, amount, description) " +
                    "values('" +
                    textISINnumber.Text +
                    "', '" +
                    dateTimePicker1.Value.ToString("yyyy-MM-dd") +
                    "', '" +
                    dateTimePicker2.Value.ToString("yyyy-MM-dd") +
                    "', '" +
                    textAmount.Text +
                    "', '" +
                    textDescripODE.Text +
                    "')";


            connecSRFN3 = new SqlConnection(connetionString3);

            try
            {
                connecSRFN3.Open();
                MessageBox.Show("Connection Open ! ");
                command3 = new SqlCommand(tax_sql, connecSRFN3);
                int numRowsAffected = command3.ExecuteNonQuery();
                MessageBox.Show("Number of rows affected: " + numRowsAffected);
                command3.Dispose();
                connecSRFN3.Close();
                MessageBox.Show("if no exception thrown so far... Connection Closed !! ");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }
        }
    }
}
