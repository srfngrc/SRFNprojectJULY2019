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

        public MainScreenForm(myInfo infoFromLoginScreen)
        {
            InitializeComponent();
            if (infoFromLoginScreen.IsAnAdminTheUser == true)
            {
                //MessageBox.Show("I DID enter the MainScreen Form as ADMIN");
                SetValueOfPB5(true);
            }
            else
            {
                //MessageBox.Show("I entered the MainScreen Form as NORMAL USER");
                SetValueOfPB5(false);
            }
        }

        public MainScreenForm()
        {
            InitializeComponent();
        }

        private void SetValueOfPB5(bool AdminOrNot)
        {
            this.PBManageAppUsers.Visible = AdminOrNot;
            this.label4operation.Visible = AdminOrNot;
        }
        private void MFCancelbtn_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void BtnMFdataEnter_Click(object sender, EventArgs e)
        {
            Insert_Each_ODE insertForm = new Insert_Each_ODE();
            insertForm.Show();
        }

        private void BtnDBconnect_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection connecSRFN;
            SqlCommand command;
            string tax_sql = null;
            //MessageBox.Show("the values received from the windows form are: " + textBox1ISIN.Text + "......" + textBox1.Text);
        
            connetionString = "Server=DatabaseSRFN.mssql.somee.com;" +
                "Database=DatabaseSRFN;" +
                "User Id=serafin;" +
                "Password = 19771977; ";

            connecSRFN = new SqlConnection(connetionString);

            try
            {
                connecSRFN.Open();
                command = new SqlCommand(tax_sql, connecSRFN);
                int numRowsAffected = command.ExecuteNonQuery();
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open the connection ! " + ex.Message);
            }
            finally
            {
                if (connecSRFN.State == ConnectionState.Open)
                {
                    connecSRFN.Close();
                }
            }
        }

        

        private void BtnReadDataFromDB_Click(object sender, EventArgs e)
        {
            All_ODE_Screen a = new All_ODE_Screen();
            a.Show();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Insert_Each_ODE insertForm = new Insert_Each_ODE();
            insertForm.Show();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            All_ODE_Screen ListAllEnteredOperations = new All_ODE_Screen();
            ListAllEnteredOperations.Show();
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            Edit_Operations ModifyPastOperations = new Edit_Operations();
            ModifyPastOperations.Show();
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            ManageAppUsers ManageAppUsers = new ManageAppUsers();
            ManageAppUsers.Show();
        }

        private void PBAcceptMS_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
