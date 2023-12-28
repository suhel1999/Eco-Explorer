namespace Eco_Explorer
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.lbl_eco_explorer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLbl_signUP = new System.Windows.Forms.LinkLabel();
            this.btn_Signin = new System.Windows.Forms.Button();
            this.lbl_notRegister = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_eco_explorer
            // 
            this.lbl_eco_explorer.AutoSize = true;
            this.lbl_eco_explorer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_eco_explorer.Font = new System.Drawing.Font("Modern No. 20", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_eco_explorer.ForeColor = System.Drawing.Color.Navy;
            this.lbl_eco_explorer.Location = new System.Drawing.Point(146, 62);
            this.lbl_eco_explorer.Name = "lbl_eco_explorer";
            this.lbl_eco_explorer.Size = new System.Drawing.Size(432, 75);
            this.lbl_eco_explorer.TabIndex = 0;
            this.lbl_eco_explorer.Text = "Eco Explorer";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(871, 354);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 322);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.linkLbl_signUP);
            this.panel2.Controls.Add(this.btn_Signin);
            this.panel2.Controls.Add(this.lbl_notRegister);
            this.panel2.Controls.Add(this.txt_password);
            this.panel2.Controls.Add(this.txt_username);
            this.panel2.Controls.Add(this.lbl_password);
            this.panel2.Controls.Add(this.lbl_username);
            this.panel2.Location = new System.Drawing.Point(27, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(437, 256);
            this.panel2.TabIndex = 0;
            // 
            // linkLbl_signUP
            // 
            this.linkLbl_signUP.AutoSize = true;
            this.linkLbl_signUP.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLbl_signUP.LinkColor = System.Drawing.Color.Black;
            this.linkLbl_signUP.Location = new System.Drawing.Point(35, 205);
            this.linkLbl_signUP.Name = "linkLbl_signUP";
            this.linkLbl_signUP.Size = new System.Drawing.Size(77, 23);
            this.linkLbl_signUP.TabIndex = 6;
            this.linkLbl_signUP.TabStop = true;
            this.linkLbl_signUP.Text = "Sign UP";
            this.linkLbl_signUP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btn_Signin
            // 
            this.btn_Signin.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Signin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Signin.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Signin.Location = new System.Drawing.Point(292, 144);
            this.btn_Signin.Name = "btn_Signin";
            this.btn_Signin.Size = new System.Drawing.Size(118, 38);
            this.btn_Signin.TabIndex = 5;
            this.btn_Signin.Text = "Sign in";
            this.btn_Signin.UseVisualStyleBackColor = false;
            this.btn_Signin.Click += new System.EventHandler(this.btn_Signin_Click);
            // 
            // lbl_notRegister
            // 
            this.lbl_notRegister.AutoSize = true;
            this.lbl_notRegister.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_notRegister.Location = new System.Drawing.Point(35, 153);
            this.lbl_notRegister.Name = "lbl_notRegister";
            this.lbl_notRegister.Size = new System.Drawing.Size(153, 23);
            this.lbl_notRegister.TabIndex = 4;
            this.lbl_notRegister.Text = "Not Registered ?";
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.SystemColors.Info;
            this.txt_password.Location = new System.Drawing.Point(155, 86);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(222, 26);
            this.txt_password.TabIndex = 3;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.SystemColors.Info;
            this.txt_username.Location = new System.Drawing.Point(155, 41);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(222, 26);
            this.txt_username.TabIndex = 2;
            this.txt_username.TextChanged += new System.EventHandler(this.txt_username_TextChanged);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(35, 86);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(102, 23);
            this.lbl_password.TabIndex = 1;
            this.lbl_password.Text = "Password :";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(35, 41);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(107, 23);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "Username :";
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1478, 744);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_eco_explorer);
            this.MaximumSize = new System.Drawing.Size(1500, 800);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1500, 800);
            this.Name = "Form_Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_eco_explorer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Signin;
        private System.Windows.Forms.Label lbl_notRegister;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.LinkLabel linkLbl_signUP;
    }
}

