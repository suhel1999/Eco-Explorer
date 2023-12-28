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

namespace Eco_Explorer
{
    public partial class Form_Admin : Form
    {
        //private object userTable;
        private static string ConnectionString = @"Data Source = LAPTOP-9GJN1TN3\SQLEXPRESS; Initial Catalog = Trek_project;Integrated Security=true";
        public Form_Admin()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form_Admin_Load(object sender, EventArgs e)
        {
            //flowLayoutPanel1.Hide();
        }

        private void LoadUserData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string selectQuery = @"SELECT * FROM Users; ";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, connection);
                    DataTable userTable = new DataTable();
                    dataAdapter.Fill(userTable);

                    User_dataGridView.DataSource = userTable;

                    // Attach the SelectionChanged event handler
                    //dataGridViewStudents.SelectionChanged += DataGridViewStudents_SelectionChanged;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            LoadUserData();
            user_panel.Show();
        }

        private void LoadBooking()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string selectQuery = @"SELECT * FROM Booking; ";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, connection);
                    DataTable bookingTable = new DataTable();
                    dataAdapter.Fill(bookingTable);

                    User_dataGridView.DataSource = bookingTable;

                    // Attach the SelectionChanged event handler
                    //dataGridViewStudents.SelectionChanged += DataGridViewStudents_SelectionChanged;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void lbl_booking_Click(object sender, EventArgs e)
        {
            LoadBooking();
            user_panel.Show();
        }

        private void LoadFood()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string selectQuery = @"SELECT * FROM Food; ";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, connection);
                    DataTable bookingFood = new DataTable();
                    dataAdapter.Fill(bookingFood);

                    User_dataGridView.DataSource = bookingFood;

                    // Attach the SelectionChanged event handler
                    //dataGridViewStudents.SelectionChanged += DataGridViewStudents_SelectionChanged;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void lbl_food_Click(object sender, EventArgs e)
        {
            LoadFood();
            user_panel.Show();
        }

        private void LoadEquipment()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string selectQuery = @"SELECT * FROM Equipment; ";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, connection);
                    DataTable bookingEquipment = new DataTable();
                    dataAdapter.Fill(bookingEquipment);

                    User_dataGridView.DataSource = bookingEquipment;

                    // Attach the SelectionChanged event handler
                    //dataGridViewStudents.SelectionChanged += DataGridViewStudents_SelectionChanged;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void lbl_equipment_Click(object sender, EventArgs e)
        {
            LoadEquipment();
            user_panel.Show();
        }


        private void LoadFeedback()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string selectQuery = @"SELECT * FROM FeedbackAndReview; ";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, connection);
                    DataTable bookingFeedback = new DataTable();
                    dataAdapter.Fill(bookingFeedback);

                    User_dataGridView.DataSource = bookingFeedback;

                    // Attach the SelectionChanged event handler
                    //dataGridViewStudents.SelectionChanged += DataGridViewStudents_SelectionChanged;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void lbl_feedback_Click(object sender, EventArgs e)
        {
            LoadFeedback();
            user_panel.Show();
        }
    }
}
