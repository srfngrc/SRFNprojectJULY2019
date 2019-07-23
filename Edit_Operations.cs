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

        static int idOperationSRFN = -1;

        public Edit_Operations()
        {
            InitializeComponent();
            DisplayData();
        }

        public void LoadDataFromDBtoGrid_SRFN()
        {
        }
        public void DisplayData()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Nutella.operations;", connecSRFN);
            //DisplayData();
            connecSRFN.Open();
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTableSRFN = new DataTable();
            dataTableSRFN.Load(reader);
            dataGridView87.DataSource = dataTableSRFN;
        }

        private void dataGridView87_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //textBox1.Text = Convert.ToInt32(dataGridView87.Rows[e.RowIndex].Cells[0].Value.ToString());
            idOperationSRFN = Convert.ToInt32(dataGridView87.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBox1.Text = dataGridView87.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView87.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox3.Text = dataGridView87.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
        ////Display Data in DataGridView  
        //private void DisplayData()
        //{
        //    con.Open();
        //    DataTable dt = new DataTable();
        //    adapt = new SqlDataAdapter("select * from tbl_Record", con);
        //    adapt.Fill(dt);
        //    dataGridView87.DataSource = dt;
        //    con.Close();
        //}
        //Clear Data  
        private void ClearData()
        {
            textBox1.Text = "";
            dateTimePicker1.ResetText();
            dateTimePicker2.ResetText();
            textBox2.Text = "";
            textBox3.Text = "";
            //ID = 0;
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        //UPDATE RECORDDD
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                SqlCommand cmd;
                //cmd = new SqlCommand("update tbl_Record set Name=@name,State=@state where ID=@id", con);
                cmd = new SqlCommand("update Nutella.operations SET isin=@isin WHERE operationId=@operationId", connecSRFN);

                connecSRFN.Open();
                cmd.Parameters.AddWithValue("@operationId", idOperationSRFN); //ID
                cmd.Parameters.AddWithValue("@isin", textBox1.Text);
                //cmd.Parameters.AddWithValue("@state", txt_State.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                connecSRFN.Close();
                //DisplayData();
                LoadDataFromDBtoGrid_SRFN();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        //DELETE RECORDDD
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            //if (ID != 0)
            if (TBoperationId.Text != string.Empty)
            {
                SqlCommand cmd;
                string query123 = "delete Nutella.operations where operationId="+
                    TBoperationId.Text +
                    ";";
                cmd = new SqlCommand(query123, connecSRFN);
                connecSRFN.Close();
                connecSRFN.Open();
                //cmd.Parameters.AddWithValue("@id", ID);
                //cmd.Parameters.AddWithValue("@operationId", idOperationSRFN); //ID esta bien ahi?no, harcodeo el 4
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
            //TBoperationId.Text = Convert.ToInt32(dataGridView87[e.ColumnIndex, e.RowIndex].Value.ToString());
            MessageBox.Show("hhhhhhhhhhhhh:     " + dataGridView87[e.ColumnIndex, e.RowIndex].Value.ToString());
            MessageBox.Show("column number is:  " + e.ColumnIndex);
            //TBoperationId.Text = dataGridView87[0, e.RowIndex].Value;
            //string.Format.int
            if (dataGridView87.SelectedRows.Count > 0)
            {
                string aa = dataGridView87.SelectedRows[0].Cells[0].Value + string.Empty;
                MessageBox.Show("POSITION 0 OF THAT ROW is:  " + aa);
            }
        }

        private void SelectionChanget(object sender, EventArgs e)
        {
            //if (dataGridView87.SelectedRows.Count = 0)
            //{
            //    textBox1.Text = dataGridView87.SelectedRows(0).Cells(0).Value;
            //    dateTimePicker1.Value = dataGridView87.SelectedRows(1).
            //    textBox2.Value = dataGridView87.SelectedRows(0).Cells(1).Value;
            //    textBox3.Value = dataGridView87.SelectedRows(0).Cells(2).Value;
            //    //textBox1.Value = dataGridView87.SelectedRows(0).Cells(3).Value;
            //}
        }
    }

   
}
