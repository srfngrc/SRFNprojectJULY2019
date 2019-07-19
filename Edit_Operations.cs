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
        static string connetionString = "workstation id=DatabaseSRFN.mssql.somee.com;" +
                                "packet size=4096;" +
                                "user id=serafin;" +
                                "pwd=19771977;" +
                                "data source=DatabaseSRFN.mssql.somee.com;" +
                                "persist security info=False;" +
                                "initial catalog=DatabaseSRFN";
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
            if (textBox1.Text != "")
            {
                SqlCommand cmd;
                cmd = new SqlCommand("delete Nutella.operations where operationId=@operationId", connecSRFN);
                connecSRFN.Open();
                //cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@operationId", idOperationSRFN); //ID esta bien ahi?no, harcodeo el 4
                cmd.ExecuteNonQuery();
                connecSRFN.Close();
                MessageBox.Show("Record Deleted Successfully!");
                //DisplayData();
                LoadDataFromDBtoGrid_SRFN();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }
    }

   
}
