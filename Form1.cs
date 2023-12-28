using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eco_Explorer
{
    public partial class Form_Login : Form

    {
       

        //for booking the trek username is required

        //public  string username => txt_username.Text;   

        private static string ConnectionString = @"Data Source = LAPTOP-9GJN1TN3\SQLEXPRESS; Initial Catalog = Trek_project;Integrated Security=true";
        public Form_Login()
        {
            
            InitializeComponent();
            

        }
        

       


        private void button2_Click(object sender, EventArgs e)
        {

        }

        

        public void Form_Login_Load(object sender, EventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            this.Hide();
            Form_SignUp signup = new Form_SignUp();
            signup.ShowDialog();

           
          


        }
        
        private void btnOpenForm2_Click(object sender, EventArgs e)
        {
           
        }

        
        



        public void btn_Signin_Click(object sender, EventArgs e)
        {
             
            string username= txt_username.Text;
            string password = txt_password.Text;

            // Call the Run method to get the username
            //string returnedUsername = Run123();

            // Use the returned username as needed
           // MessageBox.Show(returnedUsername);



            string checkquery = @"SELECT User_id, Password FROM Users WHERE User_id='" + txt_username.Text + "' AND Password='" + txt_password.Text + "'";

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(checkquery, connection))
                    {
                        // Execute the query
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (username.Equals("admin") && password.Equals("pass"))
                        {
                            this.Hide();
                            Form_Admin admin = new Form_Admin();
                            admin.ShowDialog();

                        }


                        else if (reader.HasRows)
                          {
                              this.Hide();
                              Form_Trek trek = new Form_Trek(txt_username.Text);
                              trek.ShowDialog();
                          }

                        

                        else
                        {
                            MessageBox.Show("please enter correct username or password");
                            
                        }
                        connection.Close();
                    }
                }
            }
            catch (Exception i)
            {
                MessageBox.Show(i.Message);
            }

        }
        //public string Run123()
        //{
        //    string username = txt_username.Text;
        //    return username;

        //}


        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            txt_password.PasswordChar = '*';

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
