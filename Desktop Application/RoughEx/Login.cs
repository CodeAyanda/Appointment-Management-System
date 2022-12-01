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
namespace RoughEx
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }
        SqlConnection conn = new SqlConnection(@"Data Source = 146.230.177.46; Initial Catalog = GroupWst15; User ID = GroupWst15; Password =2rjsc");
        public static bool LoginSuccess = false;
        public static string LoggedInAS = "";
        public string username = "";

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (txtNameU.Text != "" && (txtPass.Text != ""))
            {
                username = txtNameU.Text;
                loginTableAdapter1.CheckLogin(loginDS1.Login, username = "AM002", txtPass.Text);
                if (loginDS1.Login.Rows.Count > 0)
                {
                    LoginSuccess = true;
                    LoggedInAS = loginDS1.Login.Rows[0].ItemArray[2].ToString();
                    this.Close();
                }
                else
                {
                    LoginSuccess = false;
                    LoggedInAS = "";
                    MessageBox.Show("login Failed ", "Login Error ");
                    txtNameU.Clear();
                    txtPass.Clear();
                }

            }
            else
            {
                LoginSuccess = false;
                MessageBox.Show("A textbox cannot be empty", "Login error");
            }

        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNameU.Clear();
            txtPass.Clear();
            txtNameU.Focus();

        }

        private void btnShow_Click(object sender, EventArgs e)
        {

        }

        private void btnShow_MouseDown(object sender, MouseEventArgs e)
        {
            txtPass.PasswordChar = '\0';

        }

        private void btnShow_MouseUp(object sender, MouseEventArgs e)
        {
            txtPass.PasswordChar = '*';
        }

        private void btnPCLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnPCLogin_Click_1(object sender, EventArgs e)
        {
            if (txtNameU.Text != "AM002")

            {
                if (txtNameU.Text != "" && (txtPass.Text != ""))
                {

                    username = txtNameU.Text;
                    loginTableAdapter1.CheckLogin(loginDS1.Login, username = txtNameU.Text, txtPass.Text);
                    if (loginDS1.Login.Rows.Count > 0)
                    {
                        LoginSuccess = true;
                        LoggedInAS = loginDS1.Login.Rows[0].ItemArray[2].ToString();
                        this.Close();
                    }

                    else
                    {
                        LoginSuccess = false;
                        LoggedInAS = "";
                        MessageBox.Show("Login Failed", "Login failed");
                    }
                }


                else
                {
                    MessageBox.Show("A textbox cannot be empty  ", "Login Error");

                }
            }



            else
            {
                MessageBox.Show("A manager can  not log in as a pest controller", "Login Failed");
            }
        }
    
    }
}


            
        
    


