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
        string TheUserISadmin = "FALSE";
        myInfo infoFromLogScr = new myInfo();
        

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
                //FIRST I CHECK IF THE USER IS ADMINISTRATOR OR NOT 
                //TO PASS IT TO THE NEXT WINDOW FORM: MAINSCREEN
                if (CheckIfUserIsAdmin(connecSRFN2))
                {
                    infoFromLogScr.IsAnAdminTheUser = true;
                }
                else
                {
                    infoFromLogScr.IsAnAdminTheUser = false;
                }
                MainScreenForm mainWindow = new MainScreenForm(infoFromLogScr);
                mainWindow.Show();
            }
            else
            {
                MessageBox.Show("Sorry, the user and password indicated are not valid");
            }

        }

        

        bool CheckIfUserIsAdmin(SqlConnection connection3)
        {
            using (connection3)
            {
                SqlCommand command3 = new SqlCommand(
                        "SELECT isAdmin FROM Nutella.logins WHERE userName ='" +
                        textBox1.Text +
                        "';", connection3);
                connection3.Open();

                SqlDataReader readerofISADMINfield = command3.ExecuteReader();
                if (readerofISADMINfield.HasRows)
                {
                    while (readerofISADMINfield.Read())
                    {
                        TheUserISadmin = readerofISADMINfield[0].ToString();
                        if (TheUserISadmin == "TRUE")
                        {
                            return true;
                        }
                    }
                    return false;
                }
                else
                {
                    MessageBox.Show("No rows found in logins Table.");
                    return false;
                }
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
