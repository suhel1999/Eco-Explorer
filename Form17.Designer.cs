namespace Eco_Explorer
{
    partial class Form_Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_feedback = new System.Windows.Forms.Label();
            this.lbl_booking = new System.Windows.Forms.Label();
            this.lbl_equipment = new System.Windows.Forms.Label();
            this.lbl_food = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.user_panel = new System.Windows.Forms.Panel();
            this.User_dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.user_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.User_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Page";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSalmon;
            this.panel1.Controls.Add(this.lbl_feedback);
            this.panel1.Controls.Add(this.lbl_booking);
            this.panel1.Controls.Add(this.lbl_equipment);
            this.panel1.Controls.Add(this.lbl_food);
            this.panel1.Controls.Add(this.lbl_user);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 644);
            this.panel1.TabIndex = 1;
            // 
            // lbl_feedback
            // 
            this.lbl_feedback.AutoSize = true;
            this.lbl_feedback.BackColor = System.Drawing.Color.SeaShell;
            this.lbl_feedback.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_feedback.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_feedback.Location = new System.Drawing.Point(18, 542);
            this.lbl_feedback.Name = "lbl_feedback";
            this.lbl_feedback.Size = new System.Drawing.Size(151, 76);
            this.lbl_feedback.TabIndex = 6;
            this.lbl_feedback.Text = "Feedback/\r\nReview";
            this.lbl_feedback.Click += new System.EventHandler(this.lbl_feedback_Click);
            // 
            // lbl_booking
            // 
            this.lbl_booking.AutoSize = true;
            this.lbl_booking.BackColor = System.Drawing.Color.SeaShell;
            this.lbl_booking.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_booking.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_booking.Location = new System.Drawing.Point(37, 194);
            this.lbl_booking.Name = "lbl_booking";
            this.lbl_booking.Size = new System.Drawing.Size(126, 39);
            this.lbl_booking.TabIndex = 5;
            this.lbl_booking.Text = "Booking";
            this.lbl_booking.Click += new System.EventHandler(this.lbl_booking_Click);
            // 
            // lbl_equipment
            // 
            this.lbl_equipment.AutoSize = true;
            this.lbl_equipment.BackColor = System.Drawing.Color.SeaShell;
            this.lbl_equipment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_equipment.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_equipment.Location = new System.Drawing.Point(18, 428);
            this.lbl_equipment.Name = "lbl_equipment";
            this.lbl_equipment.Size = new System.Drawing.Size(158, 39);
            this.lbl_equipment.TabIndex = 4;
            this.lbl_equipment.Text = "Equipment";
            this.lbl_equipment.Click += new System.EventHandler(this.lbl_equipment_Click);
            // 
            // lbl_food
            // 
            this.lbl_food.AutoSize = true;
            this.lbl_food.BackColor = System.Drawing.Color.SeaShell;
            this.lbl_food.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_food.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_food.Location = new System.Drawing.Point(37, 311);
            this.lbl_food.Name = "lbl_food";
            this.lbl_food.Size = new System.Drawing.Size(86, 39);
            this.lbl_food.TabIndex = 3;
            this.lbl_food.Text = "Food";
            this.lbl_food.Click += new System.EventHandler(this.lbl_food_Click);
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.BackColor = System.Drawing.Color.SeaShell;
            this.lbl_user.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_user.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Location = new System.Drawing.Point(37, 81);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(92, 39);
            this.lbl_user.TabIndex = 1;
            this.lbl_user.Text = "Users";
            this.lbl_user.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 49);
            this.panel2.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Controls.Add(this.user_panel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(194, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1084, 644);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // user_panel
            // 
            this.user_panel.Controls.Add(this.User_dataGridView);
            this.user_panel.Location = new System.Drawing.Point(3, 3);
            this.user_panel.Name = "user_panel";
            this.user_panel.Size = new System.Drawing.Size(1081, 641);
            this.user_panel.TabIndex = 0;
            // 
            // User_dataGridView
            // 
            this.User_dataGridView.BackgroundColor = System.Drawing.Color.Gray;
            this.User_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.User_dataGridView.Location = new System.Drawing.Point(0, 0);
            this.User_dataGridView.Name = "User_dataGridView";
            this.User_dataGridView.RowHeadersWidth = 62;
            this.User_dataGridView.RowTemplate.Height = 28;
            this.User_dataGridView.Size = new System.Drawing.Size(1078, 641);
            this.User_dataGridView.TabIndex = 0;
            // 
            // Form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 644);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1300, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1300, 700);
            this.Name = "Form_Admin";
            this.Text = "Admin page";
            this.Load += new System.EventHandler(this.Form_Admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.user_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.User_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_feedback;
        private System.Windows.Forms.Label lbl_booking;
        private System.Windows.Forms.Label lbl_equipment;
        private System.Windows.Forms.Label lbl_food;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel user_panel;
        private System.Windows.Forms.DataGridView User_dataGridView;
    }
}