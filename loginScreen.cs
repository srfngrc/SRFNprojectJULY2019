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
    public partial class loginScreen : Form
    {
        myInfo infoFromLogScr = new myInfo();

        public loginScreen()
        {
            infoFromLogScr.IsAnAdminTheUser = false;
            InitializeComponent();
        }

        private void ButtonCancel_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string connetionString = "Server=DatabaseSRFN.mssql.somee.com;" +
                "Database=DatabaseSRFN;" +
                "User Id=serafin;" +
                "Password = 19771977; ";

            SqlConnection connecSRFN2 = new SqlConnection(connetionString);

            //First, I check if both fields are NOT empty
            if ((TBusername.Text == String.Empty) || (TBpassword.Text == String.Empty))
            {
                MessageBox.Show("Please enter both Username and Password. Both of them are mandatory");
                return;
            }
            else
            //If both fields are filled, I check if are both values in the same row of the Table logins at the DB
            //I implement that with the function CheckIfLoginIsValid
            {
                bool ValidLogin = CheckIfLoginIsValid(connecSRFN2);
                if (ValidLogin)
                {
                    MainScreenForm mainWindow = new MainScreenForm(infoFromLogScr);
                    mainWindow.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sorry, the user and password indicated are not valid");
                    TBusername.Text = String.Empty;
                    TBpassword.Text = String.Empty;
                }
            }
           
        }

        bool CheckIfLoginIsValid(SqlConnection connection2)
        {
            using (connection2)
            {
                SqlCommand commandLog = new SqlCommand(
                  "SELECT userName, passWord, isAdmin FROM Nutella.logins;",
                  connection2);

                try
                {
                    connection2.Open();
                    SqlDataReader loginsReader = commandLog.ExecuteReader();

                    if (loginsReader.HasRows)
                    {
                        while (loginsReader.Read())
                        {
                            if ((TBusername.Text == loginsReader[0].ToString()) && (TBpassword.Text == loginsReader[1].ToString()))
                            {
                                if (loginsReader[2].ToString().ToLower() == "true")
                                {
                                    infoFromLogScr.IsAnAdminTheUser = true;
                                }
                                loginsReader.Close();
                                return true;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No rows found.");
                    }
                    loginsReader.Close();
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sorry, It is not possible to open the connection ! " + ex.Message);
                    return false;
                }
                finally
                {
                    if (connection2.State == ConnectionState.Open)
                    {
                        connection2.Close();
                    }
                }
            }
           
        }

    }
}
