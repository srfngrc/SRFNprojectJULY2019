using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SRFNprojectJULY2019proj
{
    public partial class MainScreenForm : Form
    {
        string connetionString = null;
        SqlConnection connecSRFN;
        SqlCommand command;
        public MainScreenForm()
        {
            InitializeComponent();
        }

        private void MFCancelbtn_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void BtnMFdataEnter_Click(object sender, EventArgs e)
        {
            EachODE_Screen a = new EachODE_Screen();
            a.Show();
        }

        private void BtnDBconnect_Click(object sender, EventArgs e)
        {
            //string connetionString = null;
            //SqlConnection connecSRFN;
            //SqlCommand command;
            string tax_sql = null;
            MessageBox.Show("the values received from the windows form are: " + textBox1ISIN.Text + "......" + textBox1.Text);
        
            connetionString = "workstation id=DatabaseSRFN.mssql.somee.com;" +
                                "packet size=4096;" +
                                "user id=serafin;" +
                                "pwd=19771977;" +
                                "data source=DatabaseSRFN.mssql.somee.com;" +
                                "persist security info=False;" +
                                "initial catalog=DatabaseSRFN";
            //tax_sql = "Your SQL Statemnt Here";
            //tax_sql = "select * from Nutella.customers";
            //tax_sql = "insert into Nutella.customers (customerId,customerName, customerLastName, phone, addressLine1, addressLine2, city, State, postcode) values (3,'John','Doe', 416-648-9999', 'wodford avenue', 'apartment 206', 'toronto', 'ON', 'm5n2j6')";
            //tax_sql = "insert into Nutella.customers (customerId,customerName) values (3,'customer name 3')";
            tax_sql = "insert into Nutella.customers(customerId, customerName, addressLine1) " +
                    "values(" +
                    textBox1ISIN.Text +
                    ", '" +
                    textBox1.Text +
                    "', '" +
                    textBox2.Text +
                    "')";
      

            connecSRFN = new SqlConnection(connetionString);

            try
            {
                connecSRFN.Open();
                MessageBox.Show("Connection Open ! ");
                command = new SqlCommand(tax_sql, connecSRFN);
                int numRowsAffected = command.ExecuteNonQuery();
                MessageBox.Show("Number of rows affected: " + numRowsAffected);
                command.Dispose();
                connecSRFN.Close();
                MessageBox.Show("if no exception thrown so far... Connection Closed !! ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }
        }

        

        private void BtnReadDataFromDB_Click(object sender, EventArgs e)
        {
            //HasRows(connecSRFN);
        }
    }
}
