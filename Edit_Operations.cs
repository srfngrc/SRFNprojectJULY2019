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
    public partial class Edit_Operations : Form
    {
        //SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Sample;Integrated Security=true;");
        //SqlCommand cmd;
        //SqlDataAdapter adapt;


        //string connetionString = null;
        //static SqlConnection connecSRFN;
        //IT CANNOT BE DONE IN 2 STEPS THE DECLARATION IN THE MAIN CLASS
        //static string connetionString = "workstation id=DatabaseSRFN.mssql.somee.com;" +
        //                        "packet size=4096;" +
        //                        "user id=serafin;" +
        //                        "pwd=19771977;" +
        //                        "data source=DatabaseSRFN.mssql.somee.com;" +
        //                        "persist security info=False;" +
        //                        "initial catalog=DatabaseSRFN";

        static string connetionString = "Server=DatabaseSRFN.mssql.somee.com;" +
                "Database=DatabaseSRFN;" +
                "User Id=serafin;" +
                "Password = 19771977; ";
        SqlConnection connecSRFN = new SqlConnection(connetionString);

        public Edit_Operations()
        {
            InitializeComponent();
            DisplayData();
        }

        public void DisplayData()
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Nutella.operations;", connecSRFN);
                connecSRFN.Open();
                SqlDataReader reader = command.ExecuteReader();
                DataTable dataTableSRFN = new DataTable();
                dataTableSRFN.Load(reader);
                dataGridView87.DataSource = dataTableSRFN;
            }
            catch (Exception ex3)
            {
                MessageBox.Show(ex3.Message);
            }
            finally
            {
                if (connecSRFN.State == ConnectionState.Open)
                {
                    connecSRFN.Close();
                }
            }
        }

        //private void dataGridView87_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    //textBox1.Text = Convert.ToInt32(dataGridView87.Rows[e.RowIndex].Cells[0].Value.ToString());
        //    idOperationSRFN = Convert.ToInt32(dataGridView87.Rows[e.RowIndex].Cells[0].Value.ToString());
        //    TBisin.Text = dataGridView87.Rows[e.RowIndex].Cells[1].Value.ToString();
        //    TBamount.Text = dataGridView87.Rows[e.RowIndex].Cells[2].Value.ToString();
        //    TBdescription.Text = dataGridView87.Rows[e.RowIndex].Cells[3].Value.ToString();
        //}

        //Clear Data  
        private void ClearData()
        {
            TBoperationId.Text = "";
            TBisin.Text = "";
            DTPpurchaseDate.ResetText();
            DTPsellDate.ResetText();
            TBamount.Text = "";
            TBdescription.Text = "";
        }

        //UPDATE RECORDDD

        private void PBUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (TBoperationId.Text != "")
                //TBisin.Text != "" && TBamount.Text != "" && TBdescription.Text != "")
                {
                    SqlCommand cmd;
                    cmd = new SqlCommand("update Nutella.operations SET " +
                        "isin=@isin," +
                        "purchaseDate=@PurchaseDate," +
                        "sellDate= @SellDate," +
                        "amount= @amount," +
                        "description= @description " +
                        "WHERE operationId=@operationId;", connecSRFN);

                    connecSRFN.Open();
                    cmd.Parameters.AddWithValue("@operationId", TBoperationId.Text);
                    cmd.Parameters.AddWithValue("@isin", TBisin.Text);
                    cmd.Parameters.AddWithValue("@PurchaseDate", DTPpurchaseDate.Value);
                    cmd.Parameters.AddWithValue("@SellDate", DTPsellDate.Value);
                    cmd.Parameters.AddWithValue("@amount", TBamount.Text);
                    cmd.Parameters.AddWithValue("@description", TBdescription.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully");
                    connecSRFN.Close();
                    DisplayData();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Please Select a Record to Update");
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
        

        //DELETE RECORDDD
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (TBoperationId.Text != string.Empty)
            {
                SqlCommand cmd;
                string query123 = "delete Nutella.operations where operationId="+
                    TBoperationId.Text +
                    ";";
                cmd = new SqlCommand(query123, connecSRFN);
                connecSRFN.Close();
                connecSRFN.Open();
                cmd.ExecuteNonQuery();
                //ExecuteNonQuery is used for inserts,updates and deletes. Not for selects.
                if (connecSRFN.State == ConnectionState.Open)
                {
                    connecSRFN.Close();
                    MessageBox.Show("Record Deleted Successfully!");
                }
                DisplayData();
                //LoadDataFromDBtoGrid_SRFN();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void DataGridView87_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ////TBoperationId.Text = Convert.ToInt32(dataGridView87[e.ColumnIndex, e.RowIndex].Value.ToString());
            //MessageBox.Show("hhhhhhhhhhhhh:     " + dataGridView87[e.ColumnIndex, e.RowIndex].Value.ToString());
            //MessageBox.Show("column number is:  " + e.ColumnIndex);
            ////TBoperationId.Text = dataGridView87[0, e.RowIndex].Value;
            ////string.Format.int
            //if (dataGridView87.SelectedRows.Count > 0)
            //{
            //    TBoperationId.Text = dataGridView87.SelectedRows[0].Cells[0].Value + string.Empty;
            //    string aa = dataGridView87.SelectedRows[0].Cells[0].Value + string.Empty;
            //    MessageBox.Show("POSITION 0 OF THAT ROW is:  " + aa);
            //}
        }

        private void SelectionChanget(object sender, EventArgs e)
        {
            if (dataGridView87.SelectedRows.Count > 0)
            {
                TBoperationId.Text = dataGridView87.SelectedRows[0].Cells[0].Value + string.Empty;
                TBisin.Text = dataGridView87.SelectedRows[0].Cells[1].Value + string.Empty;
                DTPpurchaseDate.Text = dataGridView87.SelectedRows[0].Cells[2].Value.ToString() + string.Empty;
                DTPsellDate.Text = dataGridView87.SelectedRows[0].Cells[3].Value.ToString() + string.Empty;
                TBamount.Text = dataGridView87.SelectedRows[0].Cells[4].Value.ToString() + string.Empty;
                TBdescription.Text = dataGridView87.SelectedRows[0].Cells[5].Value.ToString() + String.Empty;
            }
        }
    }

   
}
