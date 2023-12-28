using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Eco_Explorer.Form_Login;

namespace Eco_Explorer
{
    public partial class Form_Trek : Form
    {
        public Form_Trek()
        {
            InitializeComponent();
        }

        public Form_Trek(string username)
        {
            InitializeComponent();
            textbox_username.Text = username;
        }

        private void Form_Trek_Load(object sender, EventArgs e)
        {
            //textbox_username.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            string username = textbox_username.Text;
            Form_Rajgad rajgad = new Form_Rajgad(username);
            rajgad.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            string username = textbox_username.Text;
            Form_Kataldhar kataldhar = new Form_Kataldhar(username);
            kataldhar.Show();
            
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            string username = textbox_username.Text;
            Form_Bhairavgad bhairavgad = new Form_Bhairavgad(username);
            bhairavgad.Show();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            string username = textbox_username.Text;
            Form_Devkund devkund = new Form_Devkund(username);
            devkund.Show();
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            string username = textbox_username.Text;
            Form_Garuda garuda = new Form_Garuda(username);
            garuda.Show();
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            string username = textbox_username.Text;
            Form_Harihar harihar = new Form_Harihar(username);
            harihar.Show();
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            string username = textbox_username.Text;
            Form_Visapur visapur = new Form_Visapur(username);
            visapur.Show();
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            string username = textbox_username.Text;
            Form_Kalu kalu = new Form_Kalu(username);
            kalu.Show();
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            string username = textbox_username.Text;
            Form_Ratangad ratangad = new Form_Ratangad(username);
            ratangad.Show();
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            string username = textbox_username.Text;
            Form_Harishchandragad harishchandragad = new Form_Harishchandragad(username);
            harishchandragad.Show();
               
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form_FeedbackAndReview feedbackAndReview = new Form_FeedbackAndReview();
            feedbackAndReview.ShowDialog();
            
        }

        private void textbox_username_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
