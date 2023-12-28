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

namespace Eco_Explorer
{
    public partial class Form_Garuda : Form
    {
        public static string ConnectionString = @"Data Source = LAPTOP-9GJN1TN3\SQLEXPRESS; Initial Catalog = Trek_project;Integrated Security=true";
        public Form_Garuda()
        {
            InitializeComponent();
        }

        public Form_Garuda(string username)
        {
            InitializeComponent();
            textbox_username.Text = username;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_Equipment equipment = new Form_Equipment(this);
            equipment.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_Food food = new Form_Food(this);
            food.Show();
            this.Hide();
        }

        private string GenerateUniqueBookingId()
        {
            // Implement a method to generate a unique booking ID (you can customize this)
            string randomPart = new Random().Next(100000, 999999).ToString();
            return randomPart;

        }
        private void btn_book_Click(object sender, EventArgs e)
        {
            // Generate unique booking ID
            string bookingId = GenerateUniqueBookingId();

            string userid = textbox_username.Text;

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
                        command.Parameters.AddWithValue("@Trek_id", "T110");
                        command.Parameters.AddWithValue("@User_id", userid);
                        command.Parameters.AddWithValue("@Date", txt_date.Text);


                        command.ExecuteNonQuery();
                        MessageBox.Show($"Trek booked successfully!\nBooking ID: {bookingId}");
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            string userid = textbox_username.Text;
            Form_Trek trek = new Form_Trek(userid);
            trek.Show();
        }

        private void Form_Garuda_Load(object sender, EventArgs e)
        {

        }

   
    
    }
}
