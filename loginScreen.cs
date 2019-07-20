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
        public loginScreen()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection connecSRFN2;
            connetionString = "workstation id=DatabaseSRFN.mssql.somee.com;" +
                                "packet size=4096;" +
                                "user id=serafin;" +
                                "pwd=19771977;" +
                                "data source=DatabaseSRFN.mssql.somee.com;" +
                                "persist security info=False;" +
                                "initial catalog=DatabaseSRFN";

            connecSRFN2 = new SqlConnection(connetionString);
            bool ValidLogin = CheckIfLoginIsValid(connecSRFN2);

            //IN CASE LOGIN AND PASSWORD ARE OK:
            if (ValidLogin)
            {
                MainScreenForm mainWindow = new MainScreenForm();
                mainWindow.Show();
            }
            else
            {
                //MessageBox.Show("SORRY, THE USER AND PASSWORD INDICATED ARE NOT VALID. CHECK THE SPELLING PLEASE");
                MessageBox.Show("sorry");
            }

        }

        //The method CheckIfLoginIsValid connects to the DataBase through the connection 
        //indicated and checks if the combination of user and password inserted through 
        //the winform correspond to any combination of 2 values at table logins

        bool CheckIfLoginIsValid(SqlConnection connection2)
        {
            using (connection2)
            {
                SqlCommand commandLog = new SqlCommand(
                  "SELECT userName, passWord FROM Nutella.logins;",
                  connection2);
                connection2.Open();

                SqlDataReader loginsReader = commandLog.ExecuteReader();

                if (loginsReader.HasRows)
                {
                    while (loginsReader.Read())
                    {
                        //MessageBox.Show(String.Format("{0}\t{1}", loginsReader[0].ToString(), loginsReader[1].ToString()));
                        if ((textBox1.Text == loginsReader[0].ToString()) && (textBox2.Text == loginsReader[1].ToString()))
                        {
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
           
        }
    }
}
