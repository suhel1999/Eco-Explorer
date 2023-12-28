using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eco_Explorer
{
    public partial class Form_FeedbackAndReview : Form
    {
        public static string ConnectionString = @"Data Source = LAPTOP-9GJN1TN3\SQLEXPRESS; Initial Catalog = Trek_project;Integrated Security=true";
        public Form_FeedbackAndReview()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form_FeedbackAndReview_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Trek trek = new Form_Trek();
            trek.Show();
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            MessageBox.Show("your feedback and review is noted");
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_feedback.Text = string.Empty;
            txt_guideID.Text = string.Empty;
            txt_review.Text = string.Empty;
            txt_userID.Text = string.Empty;

        }
    }
}
