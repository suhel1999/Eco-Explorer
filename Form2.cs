using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace Eco_Explorer
{
    public partial class Form_SignUp : Form
    {
        public static string ConnectionString = @"Data Source = LAPTOP-9GJN1TN3\SQLEXPRESS; Initial Catalog = Trek_project;Integrated Security=true";
        Boolean availability = false;
        public Form_SignUp()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form_SignUp_Load(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string insertquery = @"insert into Users(User_id,Password,F_name,L_name,Age,Contact_no,Adharcard_no)
           values('"
            + txt_username.Text + "', '" + txt_password.Text + "', '" + txt_fname.Text + "','" + txt_lname.Text + "','" + txt_age.Text  + "','" + txt_contact.Text + "','" + txt_adhar.Text + "')";
            try
            {
                if (availability == true)
                {
                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {//users info
                        connection.Open();
                        using (SqlCommand cmd = new SqlCommand(insertquery, connection))
                        {
                            cmd.CommandText = insertquery;

                            int numberofrowsaffected = cmd.ExecuteNonQuery();
                            if (numberofrowsaffected > 0)
                            {
                                MessageBox.Show("Data Inserted Successfully");
                                txt_fname.Text = "";
                                txt_lname.Text = "";
                                txt_username.Text = "";
                                txt_password.Text = "";
                                txt_age.Text = "";
                                txt_contact.Text = "";
                                txt_adhar.Text = "";

                                this.Hide();
                                Form_Login login = new Form_Login();
                                login.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Error: Something went wrong! Data not Inserted.");
                            }
                            connection.Close();
                        }
                    }

                }
                else
                {

                    MessageBox.Show("username is not available");

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Login login = new Form_Login();
            login.ShowDialog();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_age.Text = string.Empty;
            txt_adhar.Text = string.Empty;
            txt_contact.Text = string.Empty;
            txt_fname.Text = string.Empty;
            txt_lname.Text = string.Empty;
            txt_password.Text = string.Empty;
            txt_username.Text = string.Empty;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            String checkquery = @"select User_id from Users where User_id='" + txt_username.Text + "'";

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(checkquery, connection))
                    {
                        // Execute the query
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            MessageBox.Show("This Username not available.");
                            availability = false;
                        }
                        else
                        {
                            MessageBox.Show("This username is available.");
                            availability = true;
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

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            txt_password.PasswordChar = '*';

        }
    }
}

