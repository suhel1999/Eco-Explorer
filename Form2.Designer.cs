namespace Eco_Explorer
{
    partial class Form_SignUp
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
            this.lbl_heading = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLbl_check_avaibility = new System.Windows.Forms.LinkLabel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.txt_adhar = new System.Windows.Forms.TextBox();
            this.lbl_age = new System.Windows.Forms.Label();
            this.lbl_contact = new System.Windows.Forms.Label();
            this.lbl_adhar = new System.Windows.Forms.Label();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.lbl_lname = new System.Windows.Forms.Label();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_heading
            // 
            this.lbl_heading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_heading.AutoSize = true;
            this.lbl_heading.BackColor = System.Drawing.Color.Transparent;
            this.lbl_heading.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_heading.Location = new System.Drawing.Point(391, 9);
            this.lbl_heading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_heading.Name = "lbl_heading";
            this.lbl_heading.Size = new System.Drawing.Size(426, 55);
            this.lbl_heading.TabIndex = 0;
            this.lbl_heading.Text = "Register yourself here";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.linkLbl_check_avaibility);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.btn_submit);
            this.panel1.Controls.Add(this.txt_age);
            this.panel1.Controls.Add(this.txt_contact);
            this.panel1.Controls.Add(this.txt_adhar);
            this.panel1.Controls.Add(this.lbl_age);
            this.panel1.Controls.Add(this.lbl_contact);
            this.panel1.Controls.Add(this.lbl_adhar);
            this.panel1.Controls.Add(this.txt_lname);
            this.panel1.Controls.Add(this.txt_fname);
            this.panel1.Controls.Add(this.lbl_lname);
            this.panel1.Controls.Add(this.lbl_fname);
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Controls.Add(this.lbl_password);
            this.panel1.Controls.Add(this.txt_username);
            this.panel1.Controls.Add(this.lbl_username);
            this.panel1.Location = new System.Drawing.Point(13, 85);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 551);
            this.panel1.TabIndex = 1;
            // 
            // linkLbl_check_avaibility
            // 
            this.linkLbl_check_avaibility.AutoSize = true;
            this.linkLbl_check_avaibility.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLbl_check_avaibility.LinkColor = System.Drawing.Color.Navy;
            this.linkLbl_check_avaibility.Location = new System.Drawing.Point(432, 125);
            this.linkLbl_check_avaibility.Name = "linkLbl_check_avaibility";
            this.linkLbl_check_avaibility.Size = new System.Drawing.Size(145, 21);
            this.linkLbl_check_avaibility.TabIndex = 17;
            this.linkLbl_check_avaibility.TabStop = true;
            this.linkLbl_check_avaibility.Text = "Check Availability";
            this.linkLbl_check_avaibility.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.Info;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_clear.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_clear.Location = new System.Drawing.Point(925, 452);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(77, 42);
            this.btn_clear.TabIndex = 16;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.Info;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_back.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_back.Location = new System.Drawing.Point(808, 452);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(77, 42);
            this.btn_back.TabIndex = 15;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.SystemColors.Info;
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_submit.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_submit.Location = new System.Drawing.Point(1045, 452);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(77, 42);
            this.btn_submit.TabIndex = 14;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // txt_age
            // 
            this.txt_age.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_age.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_age.Location = new System.Drawing.Point(303, 300);
            this.txt_age.Margin = new System.Windows.Forms.Padding(4);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(278, 30);
            this.txt_age.TabIndex = 13;
            // 
            // txt_contact
            // 
            this.txt_contact.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contact.Location = new System.Drawing.Point(844, 301);
            this.txt_contact.Margin = new System.Windows.Forms.Padding(4);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(278, 30);
            this.txt_contact.TabIndex = 12;
            // 
            // txt_adhar
            // 
            this.txt_adhar.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_adhar.Location = new System.Drawing.Point(303, 398);
            this.txt_adhar.Margin = new System.Windows.Forms.Padding(4);
            this.txt_adhar.Name = "txt_adhar";
            this.txt_adhar.Size = new System.Drawing.Size(278, 30);
            this.txt_adhar.TabIndex = 11;
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_age.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_age.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_age.Location = new System.Drawing.Point(62, 300);
            this.lbl_age.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(61, 25);
            this.lbl_age.TabIndex = 10;
            this.lbl_age.Text = "Age :";
            this.lbl_age.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbl_contact
            // 
            this.lbl_contact.AutoSize = true;
            this.lbl_contact.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_contact.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contact.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_contact.Location = new System.Drawing.Point(650, 306);
            this.lbl_contact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_contact.Name = "lbl_contact";
            this.lbl_contact.Size = new System.Drawing.Size(178, 25);
            this.lbl_contact.TabIndex = 9;
            this.lbl_contact.Text = "Contact number :";
            // 
            // lbl_adhar
            // 
            this.lbl_adhar.AutoSize = true;
            this.lbl_adhar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_adhar.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adhar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_adhar.Location = new System.Drawing.Point(62, 398);
            this.lbl_adhar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_adhar.Name = "lbl_adhar";
            this.lbl_adhar.Size = new System.Drawing.Size(205, 25);
            this.lbl_adhar.TabIndex = 8;
            this.lbl_adhar.Text = "Adharcard number :";
            // 
            // txt_lname
            // 
            this.txt_lname.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lname.Location = new System.Drawing.Point(844, 199);
            this.txt_lname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(278, 30);
            this.txt_lname.TabIndex = 7;
            // 
            // txt_fname
            // 
            this.txt_fname.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fname.Location = new System.Drawing.Point(303, 199);
            this.txt_fname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(278, 30);
            this.txt_fname.TabIndex = 6;
            // 
            // lbl_lname
            // 
            this.lbl_lname.AutoSize = true;
            this.lbl_lname.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_lname.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_lname.Location = new System.Drawing.Point(650, 204);
            this.lbl_lname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_lname.Name = "lbl_lname";
            this.lbl_lname.Size = new System.Drawing.Size(124, 25);
            this.lbl_lname.TabIndex = 5;
            this.lbl_lname.Text = "Last name :";
            // 
            // lbl_fname
            // 
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_fname.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_fname.Location = new System.Drawing.Point(62, 199);
            this.lbl_fname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(127, 25);
            this.lbl_fname.TabIndex = 4;
            this.lbl_fname.Text = "First name :";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(844, 86);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(278, 30);
            this.txt_password.TabIndex = 3;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_password.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_password.Location = new System.Drawing.Point(650, 91);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(116, 25);
            this.lbl_password.TabIndex = 2;
            this.lbl_password.Text = "Password :";
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(303, 91);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(278, 30);
            this.txt_username.TabIndex = 1;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_username.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_username.Location = new System.Drawing.Point(62, 91);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(120, 25);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "Username :";
            // 
            // Form_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1178, 694);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_heading);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_SignUp";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Form_SignUp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_heading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_lname;
        private System.Windows.Forms.Label lbl_fname;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Label lbl_contact;
        private System.Windows.Forms.Label lbl_adhar;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.TextBox txt_adhar;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.LinkLabel linkLbl_check_avaibility;
    }
}