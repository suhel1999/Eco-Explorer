﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Eco_Explorer.Form_Login;

namespace Eco_Explorer
{
    public partial class Form_Rajgad : Form
    {
        //for booking the trek username is required so we we create object of loginform
        //public Form_Login loginform = new Form_Login();


        public static string ConnectionString = @"Data Source = LAPTOP-9GJN1TN3\SQLEXPRESS; Initial Catalog = Trek_project;Integrated Security=true";
        

        //private String username;
        private DateTime Date;

        public Form_Rajgad()
        {
            InitializeComponent();
          

        }

        public Form_Rajgad(string username)
        {
            InitializeComponent();
            textbox_username.Text = username;



        }

       



        /*// Open FoodForm from TrekForm
                              private void OpenFoodForm()
                          {
                   FoodForm foodForm = new FoodForm(this); // 'this' refers to the current trek form
                              foodForm.Show();
                              this.Hide(); // Hide the current trek form
                          }*/

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_Food food = new Form_Food(this);
            food.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_Equipment equipment = new Form_Equipment(this);
            equipment.Show();
            
            this.Hide();
        }

          

        private void button2_Click(object sender, EventArgs e)
        {
            string userid = textbox_username.Text;
            this.Hide();
            Form_Trek trek = new Form_Trek(userid);
            trek.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private string GenerateUniqueBookingId()
        {
            // Implement a method to generate a unique booking ID (you can customize this)
            string randomPart = new Random().Next(100000, 999999).ToString();
            return randomPart;

            // Example: Combine date/time and a random number
            //return txt_date.Text + new Random().Next(1000, 9999);

        }
        private void btn_book_Click(object sender, EventArgs e)
        {
            // Generate unique booking ID
            string bookingId = GenerateUniqueBookingId();
            //string userid= loginform.Run123();
            
            //String userid = loginform.username;

            string userid = textbox_username.Text;



            //MessageBox.Show("Congratulations ! you succesfully book this trek");

            // SQL query to insert data into the database


            string query = "INSERT INTO Booking (Booking_id, Trek_id, User_id,Date) " +
                           "VALUES (@Booking_id, @Trek_id, @User_id, @Date)";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    // Open the connection and execute the query
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the SQL query
                        command.Parameters.AddWithValue("@Booking_id", bookingId);
                        command.Parameters.AddWithValue("@Trek_id", "T101");
                        command.Parameters.AddWithValue("@User_id", userid);
                        command.Parameters.AddWithValue("@Date", txt_date.Text);


                        command.ExecuteNonQuery();
                        MessageBox.Show($"Trek booked successfully!\nBooking ID: {bookingId}");
                    }
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message ); }

        } 







    private void Form_Rajgad_Load(object sender, EventArgs e)
    {
            //textBox_username.Hide();

        }

        private void textBox_username_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}       