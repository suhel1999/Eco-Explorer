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
    public partial class Form_Equipment : Form
    {
        private Form previousForm;
        public static string ConnectionString = @"Data Source = LAPTOP-9GJN1TN3\SQLEXPRESS; Initial Catalog = Trek_project;Integrated Security=true";
        public Form_Equipment()
        {
            InitializeComponent();
        }

        public Form_Equipment(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
        }

       

        private void Form_Equipment_Load(object sender, EventArgs e)
        {

        }


        private void btn_back_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All Items you selected is ordered");

        }
    }
}
