namespace Theory
{
    partial class QuestionList
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
            this.returnInf = new System.Windows.Forms.Button();
            this.returnMain = new System.Windows.Forms.Button();
            this.TopBar = new System.Windows.Forms.Panel();
            this.Reset_Questions = new System.Windows.Forms.Button();
            this.GoQuestions = new System.Windows.Forms.Button();
            this.WrongQuestions_button = new System.Windows.Forms.RadioButton();
            this.AllQuestions_button = new System.Windows.Forms.RadioButton();
            this.unanswered = new System.Windows.Forms.Label();
            this.Example = new System.Windows.Forms.Panel();
            this.Show_Hide_Button = new System.Windows.Forms.Button();
            this.ans_3 = new System.Windows.Forms.Label();
            this.ans_2 = new System.Windows.Forms.Label();
            this.ans_4 = new System.Windows.Forms.Label();
            this.ans_1 = new System.Windows.Forms.Label();
            this.Question = new System.Windows.Forms.Label();
            this.Scroll_Panel = new System.Windows.Forms.Panel();
            this.question_Pic = new System.Windows.Forms.PictureBox();
            this.TopBar.SuspendLayout();
            this.Example.SuspendLayout();
            this.Scroll_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.question_Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // returnInf
            // 
            this.returnInf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.returnInf.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.returnInf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.returnInf.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnInf.ForeColor = System.Drawing.Color.MidnightBlue;
            this.returnInf.Location = new System.Drawing.Point(724, 9);
            this.returnInf.Name = "returnInf";
            this.returnInf.Size = new System.Drawing.Size(151, 47);
            this.returnInf.TabIndex = 14;
            this.returnInf.Text = "חזור למאגר";
            this.returnInf.UseVisualStyleBackColor = false;
            this.returnInf.Click += new System.EventHandler(this.returnInf_Click);
            // 
            // returnMain
            // 
            this.returnMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.returnMain.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.returnMain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.returnMain.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnMain.ForeColor = System.Drawing.Color.MidnightBlue;
            this.returnMain.Location = new System.Drawing.Point(881, 9);
            this.returnMain.Name = "returnMain";
            this.returnMain.Size = new System.Drawing.Size(151, 47);
            this.returnMain.TabIndex = 15;
            this.returnMain.Text = "חזור לעמוד הראשי";
            this.returnMain.UseVisualStyleBackColor = false;
            this.returnMain.Click += new System.EventHandler(this.returnMain_Click);
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TopBar.Controls.Add(this.Reset_Questions);
            this.TopBar.Controls.Add(this.GoQuestions);
            this.TopBar.Controls.Add(this.WrongQuestions_button);
            this.TopBar.Controls.Add(this.AllQuestions_button);
            this.TopBar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(1062, 75);
            this.TopBar.TabIndex = 16;
            // 
            // Reset_Questions
            // 
            this.Reset_Questions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Reset_Questions.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Reset_Questions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Reset_Questions.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset_Questions.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Reset_Questions.Location = new System.Drawing.Point(560, 9);
            this.Reset_Questions.Name = "Reset_Questions";
            this.Reset_Questions.Size = new System.Drawing.Size(151, 47);
            this.Reset_Questions.TabIndex = 24;
            this.Reset_Questions.Text = "מאגר שאלות מחדש";
            this.Reset_Questions.UseVisualStyleBackColor = false;
            this.Reset_Questions.Click += new System.EventHandler(this.Reset_Questions_Click);
            // 
            // GoQuestions
            // 
            this.GoQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GoQuestions.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GoQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GoQuestions.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoQuestions.ForeColor = System.Drawing.Color.MidnightBlue;
            this.GoQuestions.Location = new System.Drawing.Point(403, 9);
            this.GoQuestions.Name = "GoQuestions";
            this.GoQuestions.Size = new System.Drawing.Size(151, 47);
            this.GoQuestions.TabIndex = 23;
            this.GoQuestions.Text = "לשאלות";
            this.GoQuestions.UseVisualStyleBackColor = false;
            this.GoQuestions.Click += new System.EventHandler(this.GoQuestions_Click);
            // 
            // WrongQuestions_button
            // 
            this.WrongQuestions_button.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WrongQuestions_button.Location = new System.Drawing.Point(12, 32);
            this.WrongQuestions_button.Name = "WrongQuestions_button";
            this.WrongQuestions_button.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.WrongQuestions_button.Size = new System.Drawing.Size(123, 24);
            this.WrongQuestions_button.TabIndex = 1;
            this.WrongQuestions_button.Text = "שאלות שטעיתי";
            this.WrongQuestions_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WrongQuestions_button.UseVisualStyleBackColor = true;
            this.WrongQuestions_button.CheckedChanged += new System.EventHandler(this.WrongQuestions_button_CheckedChanged);
            // 
            // AllQuestions_button
            // 
            this.AllQuestions_button.Checked = true;
            this.AllQuestions_button.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllQuestions_button.Location = new System.Drawing.Point(31, 9);
            this.AllQuestions_button.Name = "AllQuestions_button";
            this.AllQuestions_button.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AllQuestions_button.Size = new System.Drawing.Size(104, 24);
            this.AllQuestions_button.TabIndex = 0;
            this.AllQuestions_button.TabStop = true;
            this.AllQuestions_button.Text = "כל השאלות";
            this.AllQuestions_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AllQuestions_button.UseVisualStyleBackColor = true;
            this.AllQuestions_button.CheckedChanged += new System.EventHandler(this.AllQuestions_button_CheckedChanged);
            // 
            // unanswered
            // 
            this.unanswered.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.unanswered.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unanswered.ForeColor = System.Drawing.Color.MidnightBlue;
            this.unanswered.Location = new System.Drawing.Point(322, 338);
            this.unanswered.Name = "unanswered";
            this.unanswered.Size = new System.Drawing.Size(405, 104);
            this.unanswered.TabIndex = 8;
            this.unanswered.Text = "לא ענית על שאלות";
            this.unanswered.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.unanswered.Click += new System.EventHandler(this.unanswered_Click_1);
            // 
            // Example
            // 
            this.Example.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Example.BackColor = System.Drawing.Color.MidnightBlue;
            this.Example.Controls.Add(this.Show_Hide_Button);
            this.Example.Controls.Add(this.ans_3);
            this.Example.Controls.Add(this.ans_2);
            this.Example.Controls.Add(this.ans_4);
            this.Example.Controls.Add(this.ans_1);
            this.Example.Controls.Add(this.Question);
            this.Example.Controls.Add(this.question_Pic);
            this.Example.Location = new System.Drawing.Point(122, 81);
            this.Example.Name = "Example";
            this.Example.Size = new System.Drawing.Size(800, 268);
            this.Example.TabIndex = 17;
            // 
            // Show_Hide_Button
            // 
            this.Show_Hide_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Show_Hide_Button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Show_Hide_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Show_Hide_Button.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_Hide_Button.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Show_Hide_Button.Location = new System.Drawing.Point(262, 222);
            this.Show_Hide_Button.Name = "Show_Hide_Button";
            this.Show_Hide_Button.Size = new System.Drawing.Size(238, 32);
            this.Show_Hide_Button.TabIndex = 7;
            this.Show_Hide_Button.Text = "הראה תשובה";
            this.Show_Hide_Button.UseVisualStyleBackColor = false;
            // 
            // ans_3
            // 
            this.ans_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ans_3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ans_3.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ans_3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ans_3.Location = new System.Drawing.Point(532, 175);
            this.ans_3.Name = "ans_3";
            this.ans_3.Size = new System.Drawing.Size(265, 32);
            this.ans_3.TabIndex = 5;
            this.ans_3.Text = "תשובה3";
            this.ans_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ans_2
            // 
            this.ans_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ans_2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ans_2.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ans_2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ans_2.Location = new System.Drawing.Point(532, 128);
            this.ans_2.Name = "ans_2";
            this.ans_2.Size = new System.Drawing.Size(265, 32);
            this.ans_2.TabIndex = 4;
            this.ans_2.Text = "תשובה2";
            this.ans_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ans_4
            // 
            this.ans_4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ans_4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ans_4.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ans_4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ans_4.Location = new System.Drawing.Point(532, 222);
            this.ans_4.Name = "ans_4";
            this.ans_4.Size = new System.Drawing.Size(265, 32);
            this.ans_4.TabIndex = 3;
            this.ans_4.Text = "תשובה4";
            this.ans_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ans_1
            // 
            this.ans_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ans_1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ans_1.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ans_1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ans_1.Location = new System.Drawing.Point(532, 82);
            this.ans_1.Name = "ans_1";
            this.ans_1.Size = new System.Drawing.Size(265, 32);
            this.ans_1.TabIndex = 2;
            this.ans_1.Text = "תשובה1";
            this.ans_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Question
            // 
            this.Question.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Question.Font = new System.Drawing.Font("Cascadia Mono", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Question.Location = new System.Drawing.Point(26, 0);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(749, 69);
            this.Question.TabIndex = 1;
            this.Question.Text = "שאלה";
            this.Question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Scroll_Panel
            // 
            this.Scroll_Panel.AutoScroll = true;
            this.Scroll_Panel.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.Scroll_Panel.Controls.Add(this.unanswered);
            this.Scroll_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Scroll_Panel.Location = new System.Drawing.Point(0, 0);
            this.Scroll_Panel.Name = "Scroll_Panel";
            this.Scroll_Panel.Size = new System.Drawing.Size(1062, 450);
            this.Scroll_Panel.TabIndex = 8;
            // 
            // question_Pic
            // 
            this.question_Pic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.question_Pic.Image = global::Theory.Properties.Resources.question_1_img;
            this.question_Pic.Location = new System.Drawing.Point(9, 113);
            this.question_Pic.Name = "question_Pic";
            this.question_Pic.Size = new System.Drawing.Size(228, 141);
            this.question_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.question_Pic.TabIndex = 0;
            this.question_Pic.TabStop = false;
            // 
            // QuestionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1062, 450);
            this.Controls.Add(this.returnMain);
            this.Controls.Add(this.returnInf);
            this.Controls.Add(this.TopBar);
            this.Controls.Add(this.Scroll_Panel);
            this.Controls.Add(this.Example);
            this.Name = "QuestionList";
            this.Text = "QuestionList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuestionList_FormClosing);
            this.TopBar.ResumeLayout(false);
            this.Example.ResumeLayout(false);
            this.Scroll_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.question_Pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button returnInf;
        private System.Windows.Forms.Button returnMain;
        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.RadioButton AllQuestions_button;
        private System.Windows.Forms.Button Reset_Questions;
        private System.Windows.Forms.Button GoQuestions;
        private System.Windows.Forms.RadioButton WrongQuestions_button;
        private System.Windows.Forms.Label unanswered;
        private System.Windows.Forms.Panel Example;
        private System.Windows.Forms.Button Show_Hide_Button;
        private System.Windows.Forms.Label ans_3;
        private System.Windows.Forms.Label ans_2;
        private System.Windows.Forms.Label ans_4;
        private System.Windows.Forms.Label ans_1;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.PictureBox question_Pic;
        private System.Windows.Forms.Panel Scroll_Panel;
    }
}