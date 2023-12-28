using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eco_Explorer
{
    public partial class Form_Food : Form
    {
        private Form previousForm;
        public static string ConnectionString = @"Data Source = LAPTOP-9GJN1TN3\SQLEXPRESS; Initial Catalog = Trek_project;Integrated Security=true";

        public Form_Food()
        {
            InitializeComponent();
        }

        public Form_Food(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void Form_food_Load(object sender, EventArgs e)
        {

        }

        private void txt_poha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_done_Click(object sender, EventArgs e)
        {

            MessageBox.Show("All Items you selected is ordered");

            //    // Get the selected breakfast option
            //    string selectedBreakfast = GetSelectedOption(panelBreakfast);

            //    // Get the selected lunch option
            //    string selectedLunch = GetSelectedOption(panelLunch);

            //    // Insert data into the database
            //    InsertDataIntoDatabase(selectedBreakfast, selectedLunch);
            }

            private string GetSelectedOption(Panel panel)
        {
            // Iterate through the radio buttons in the panel and return the tag (actual value) of the selected one
            foreach (RadioButton radioButton in panel.Controls.OfType<RadioButton>())
            {
                if (radioButton.Checked)
                {
                    return radioButton.Tag?.ToString();
                }
            }

            // Return an empty string or handle the case when no option is selected
            return "";
        }

        private void InsertDataIntoDatabase(string selectedBreakfast, string selectedLunch)
        {
            // Replace with your actual connection string
            //string connectionString = "YourConnectionString";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Assuming you have a table named 'Food' with columns 'breakfast' and 'lunch'
                string query = "INSERT INTO Food (Food_id,Booking_id,Breakfast_meal, Lunch_meal,Price) VALUES (' ',' ',@Breakfast, @Lunch,  )";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Food_id", "F111");
                    command.Parameters.AddWithValue("@Booking_id","11");
                    command.Parameters.AddWithValue("@Breakfast", selectedBreakfast);
                    command.Parameters.AddWithValue("@Lunch", selectedLunch);
                    

                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show($"Data inserted into the database: Breakfast - {selectedBreakfast}, Lunch - {selectedLunch}");
        }





        private void btn_back_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Form_Trek trek = new Form_Trek();
            //trek.Show();

            previousForm.Show();
            this.Close();

        }

       

       

       

        

       

        

       

       

        

       

       

        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }
    

