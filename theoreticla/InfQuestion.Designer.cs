namespace Theory
{
    partial class InfQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfQuestion));
            this.Question = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.test = new System.Windows.Forms.Label();
            this.PrevQuestions = new System.Windows.Forms.Button();
            this.ans1 = new System.Windows.Forms.RadioButton();
            this.Check_Pass = new System.Windows.Forms.Button();
            this.Photo = new System.Windows.Forms.PictureBox();
            this.ans2 = new System.Windows.Forms.RadioButton();
            this.ans3 = new System.Windows.Forms.RadioButton();
            this.ans4 = new System.Windows.Forms.RadioButton();
            this.returnButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // Question
            // 
            this.Question.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Question.Font = new System.Drawing.Font("Cascadia Mono", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Question.Location = new System.Drawing.Point(0, 0);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(1021, 92);
            this.Question.TabIndex = 0;
            this.Question.Text = "שאלה";
            this.Question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Question.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.test);
            this.panel1.Controls.Add(this.Question);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 92);
            this.panel1.TabIndex = 1;
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.BackColor = System.Drawing.Color.LightSkyBlue;
            this.test.Location = new System.Drawing.Point(12, 26);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(35, 13);
            this.test.TabIndex = 12;
            this.test.Text = "label2";
            // 
            // PrevQuestions
            // 
            this.PrevQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PrevQuestions.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PrevQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PrevQuestions.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrevQuestions.ForeColor = System.Drawing.Color.MidnightBlue;
            this.PrevQuestions.Location = new System.Drawing.Point(44, 462);
            this.PrevQuestions.Name = "PrevQuestions";
            this.PrevQuestions.Size = new System.Drawing.Size(336, 47);
            this.PrevQuestions.TabIndex = 13;
            this.PrevQuestions.Text = "הראה שאלות";
            this.PrevQuestions.UseVisualStyleBackColor = false;
            this.PrevQuestions.Click += new System.EventHandler(this.ShowPrevQuestions);
            // 
            // ans1
            // 
            this.ans1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ans1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ans1.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ans1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ans1.Location = new System.Drawing.Point(670, 147);
            this.ans1.Name = "ans1";
            this.ans1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ans1.Size = new System.Drawing.Size(339, 47);
            this.ans1.TabIndex = 2;
            this.ans1.Text = "תשובה1";
            this.ans1.UseVisualStyleBackColor = false;
            this.ans1.CheckedChanged += new System.EventHandler(this.Ans1_CheckedChanged);
            // 
            // Check_Pass
            // 
            this.Check_Pass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Check_Pass.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Check_Pass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Check_Pass.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check_Pass.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Check_Pass.Location = new System.Drawing.Point(670, 462);
            this.Check_Pass.Name = "Check_Pass";
            this.Check_Pass.Size = new System.Drawing.Size(159, 47);
            this.Check_Pass.TabIndex = 6;
            this.Check_Pass.Text = "בדוק";
            this.Check_Pass.UseVisualStyleBackColor = false;
            this.Check_Pass.Click += new System.EventHandler(this.Check_Or_Pass);
            // 
            // Photo
            // 
            this.Photo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Photo.Image = ((System.Drawing.Image)(resources.GetObject("Photo.Image")));
            this.Photo.Location = new System.Drawing.Point(44, 147);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(336, 276);
            this.Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Photo.TabIndex = 7;
            this.Photo.TabStop = false;
            // 
            // ans2
            // 
            this.ans2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ans2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ans2.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ans2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ans2.Location = new System.Drawing.Point(670, 222);
            this.ans2.Name = "ans2";
            this.ans2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ans2.Size = new System.Drawing.Size(339, 47);
            this.ans2.TabIndex = 8;
            this.ans2.Text = "תשובה2";
            this.ans2.UseVisualStyleBackColor = false;
            this.ans2.CheckedChanged += new System.EventHandler(this.ans2_CheckedChanged);
            // 
            // ans3
            // 
            this.ans3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ans3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ans3.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ans3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ans3.Location = new System.Drawing.Point(670, 299);
            this.ans3.Name = "ans3";
            this.ans3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ans3.Size = new System.Drawing.Size(339, 47);
            this.ans3.TabIndex = 9;
            this.ans3.Text = "תשובה3";
            this.ans3.UseVisualStyleBackColor = false;
            this.ans3.CheckedChanged += new System.EventHandler(this.ans3_CheckedChanged);
            // 
            // ans4
            // 
            this.ans4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ans4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ans4.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ans4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ans4.Location = new System.Drawing.Point(670, 376);
            this.ans4.Name = "ans4";
            this.ans4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ans4.Size = new System.Drawing.Size(339, 47);
            this.ans4.TabIndex = 10;
            this.ans4.Text = "תשובה4";
            this.ans4.UseVisualStyleBackColor = false;
            this.ans4.CheckedChanged += new System.EventHandler(this.ans4_CheckedChanged);
            // 
            // returnButton
            // 
            this.returnButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.returnButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.returnButton.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.returnButton.Location = new System.Drawing.Point(850, 462);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(159, 47);
            this.returnButton.TabIndex = 12;
            this.returnButton.Text = "לחזור ⇒";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.ReturnButton);
            // 
            // InfQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1021, 564);
            this.Controls.Add(this.PrevQuestions);
            this.Controls.Add(this.Check_Pass);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.ans3);
            this.Controls.Add(this.ans2);
            this.Controls.Add(this.Photo);
            this.Controls.Add(this.ans1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ans4);
            this.Name = "InfQuestion";
            this.Text = "InfQuestion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InfQuestion_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InfQuestion_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton ans1;
        private System.Windows.Forms.Button Check_Pass;
        private System.Windows.Forms.PictureBox Photo;
        private System.Windows.Forms.RadioButton ans2;
        private System.Windows.Forms.RadioButton ans3;
        private System.Windows.Forms.RadioButton ans4;
        private System.Windows.Forms.Label test;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button PrevQuestions;
    }
}

