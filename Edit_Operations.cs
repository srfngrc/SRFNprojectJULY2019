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
        public Edit_Operations()
        {
            InitializeComponent();
            LoadDataFromDBtoGrid_SRFN();
        }

        public void LoadDataFromDBtoGrid_SRFN()
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

            SqlCommand command = new SqlCommand("SELECT * FROM Nutella.operations;", connecSRFN);
            connecSRFN.Open();
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTableSRFN = new DataTable();

            dataTableSRFN.Load(reader);
            dataGridView87.DataSource = dataTableSRFN;
        }
    }

   
}
