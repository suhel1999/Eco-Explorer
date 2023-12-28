namespace Eco_Explorer
{
    partial class Form_FeedbackAndReview
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_guideID = new System.Windows.Forms.TextBox();
            this.lbl_guideID = new System.Windows.Forms.Label();
            this.lbl_reviewRating = new System.Windows.Forms.Label();
            this.lbl_review = new System.Windows.Forms.Label();
            this.txt_review = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_feedbackRating = new System.Windows.Forms.Label();
            this.txt_feedback = new System.Windows.Forms.TextBox();
            this.lbl_feedback = new System.Windows.Forms.Label();
            this.lbl_userid = new System.Windows.Forms.Label();
            this.txt_userID = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_heading
            // 
            this.lbl_heading.AutoSize = true;
            this.lbl_heading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_heading.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading.Location = new System.Drawing.Point(513, 35);
            this.lbl_heading.Name = "lbl_heading";
            this.lbl_heading.Size = new System.Drawing.Size(351, 46);
            this.lbl_heading.TabIndex = 0;
            this.lbl_heading.Text = "Feedback and  Review\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(188, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Feedback for Admin";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.txt_guideID);
            this.panel1.Controls.Add(this.lbl_guideID);
            this.panel1.Controls.Add(this.lbl_reviewRating);
            this.panel1.Controls.Add(this.lbl_review);
            this.panel1.Controls.Add(this.txt_review);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(709, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 463);
            this.panel1.TabIndex = 2;
            // 
            // txt_guideID
            // 
            this.txt_guideID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_guideID.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guideID.Location = new System.Drawing.Point(249, 414);
            this.txt_guideID.Name = "txt_guideID";
            this.txt_guideID.Size = new System.Drawing.Size(242, 30);
            this.txt_guideID.TabIndex = 4;
            // 
            // lbl_guideID
            // 
            this.lbl_guideID.AutoSize = true;
            this.lbl_guideID.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_guideID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_guideID.Location = new System.Drawing.Point(37, 412);
            this.lbl_guideID.Name = "lbl_guideID";
            this.lbl_guideID.Size = new System.Drawing.Size(109, 25);
            this.lbl_guideID.TabIndex = 7;
            this.lbl_guideID.Text = "Guide Id :";
            // 
            // lbl_reviewRating
            // 
            this.lbl_reviewRating.AutoSize = true;
            this.lbl_reviewRating.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reviewRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_reviewRating.Location = new System.Drawing.Point(37, 345);
            this.lbl_reviewRating.Name = "lbl_reviewRating";
            this.lbl_reviewRating.Size = new System.Drawing.Size(87, 25);
            this.lbl_reviewRating.TabIndex = 6;
            this.lbl_reviewRating.Text = "Rating :";
            // 
            // lbl_review
            // 
            this.lbl_review.AutoSize = true;
            this.lbl_review.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_review.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_review.Location = new System.Drawing.Point(37, 113);
            this.lbl_review.Name = "lbl_review";
            this.lbl_review.Size = new System.Drawing.Size(94, 25);
            this.lbl_review.TabIndex = 6;
            this.lbl_review.Text = "Review :";
            this.lbl_review.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_review
            // 
            this.txt_review.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_review.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_review.Location = new System.Drawing.Point(249, 111);
            this.txt_review.Multiline = true;
            this.txt_review.Name = "txt_review";
            this.txt_review.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_review.Size = new System.Drawing.Size(361, 164);
            this.txt_review.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(244, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Review for Guide";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.lbl_feedbackRating);
            this.panel2.Controls.Add(this.txt_feedback);
            this.panel2.Controls.Add(this.lbl_feedback);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(36, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(667, 463);
            this.panel2.TabIndex = 0;
            // 
            // lbl_feedbackRating
            // 
            this.lbl_feedbackRating.AutoSize = true;
            this.lbl_feedbackRating.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_feedbackRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_feedbackRating.Location = new System.Drawing.Point(18, 345);
            this.lbl_feedbackRating.Name = "lbl_feedbackRating";
            this.lbl_feedbackRating.Size = new System.Drawing.Size(87, 25);
            this.lbl_feedbackRating.TabIndex = 5;
            this.lbl_feedbackRating.Text = "Rating :";
            // 
            // txt_feedback
            // 
            this.txt_feedback.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_feedback.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_feedback.Location = new System.Drawing.Point(193, 113);
            this.txt_feedback.Multiline = true;
            this.txt_feedback.Name = "txt_feedback";
            this.txt_feedback.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_feedback.Size = new System.Drawing.Size(361, 164);
            this.txt_feedback.TabIndex = 4;
            // 
            // lbl_feedback
            // 
            this.lbl_feedback.AutoSize = true;
            this.lbl_feedback.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_feedback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_feedback.Location = new System.Drawing.Point(18, 111);
            this.lbl_feedback.Name = "lbl_feedback";
            this.lbl_feedback.Size = new System.Drawing.Size(116, 25);
            this.lbl_feedback.TabIndex = 2;
            this.lbl_feedback.Text = "Feedback :";
            // 
            // lbl_userid
            // 
            this.lbl_userid.AutoSize = true;
            this.lbl_userid.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_userid.Location = new System.Drawing.Point(42, 115);
            this.lbl_userid.Name = "lbl_userid";
            this.lbl_userid.Size = new System.Drawing.Size(100, 25);
            this.lbl_userid.TabIndex = 2;
            this.lbl_userid.Text = "User ID :";
            // 
            // txt_userID
            // 
            this.txt_userID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_userID.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userID.Location = new System.Drawing.Point(229, 118);
            this.txt_userID.Name = "txt_userID";
            this.txt_userID.Size = new System.Drawing.Size(242, 30);
            this.txt_userID.TabIndex = 3;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(1317, 676);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(84, 39);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_back.Location = new System.Drawing.Point(1047, 676);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(83, 39);
            this.btn_back.TabIndex = 7;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Yellow;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clear.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_clear.Location = new System.Drawing.Point(1184, 676);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(83, 39);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form_FeedbackAndReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1478, 744);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_userID);
            this.Controls.Add(this.lbl_userid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_heading);
            this.MaximumSize = new System.Drawing.Size(1500, 800);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1500, 800);
            this.Name = "Form_FeedbackAndReview";
            this.Text = "Feedback and Review";
            this.Load += new System.EventHandler(this.Form_FeedbackAndReview_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_heading;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_userid;
        private System.Windows.Forms.TextBox txt_userID;
        private System.Windows.Forms.TextBox txt_review;
        private System.Windows.Forms.Label lbl_review;
        private System.Windows.Forms.Label lbl_feedbackRating;
        private System.Windows.Forms.TextBox txt_feedback;
        private System.Windows.Forms.Label lbl_feedback;
        private System.Windows.Forms.TextBox txt_guideID;
        private System.Windows.Forms.Label lbl_guideID;
        private System.Windows.Forms.Label lbl_reviewRating;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_clear;
    }
}