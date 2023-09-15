namespace Theory
{
    partial class TestForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.Question = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.test = new System.Windows.Forms.Label();
            this.ans1 = new System.Windows.Forms.RadioButton();
            this.NextQuestion = new System.Windows.Forms.Button();
            this.Photo = new System.Windows.Forms.PictureBox();
            this.ans2 = new System.Windows.Forms.RadioButton();
            this.ans3 = new System.Windows.Forms.RadioButton();
            this.ans4 = new System.Windows.Forms.RadioButton();
            this.returnButton = new System.Windows.Forms.Button();
            this.Progress = new System.Windows.Forms.ProgressBar();
            this.FinishTest = new System.Windows.Forms.Button();
            this.QuestionsData = new System.Windows.Forms.Label();
            this.AllQuestions = new System.Windows.Forms.ComboBox();
            this.TestTimer = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.Previous = new System.Windows.Forms.Button();
            this.Countdown = new System.Windows.Forms.Timer(this.components);
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
            // NextQuestion
            // 
            this.NextQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NextQuestion.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.NextQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NextQuestion.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextQuestion.ForeColor = System.Drawing.Color.MidnightBlue;
            this.NextQuestion.Location = new System.Drawing.Point(670, 462);
            this.NextQuestion.Name = "NextQuestion";
            this.NextQuestion.Size = new System.Drawing.Size(159, 47);
            this.NextQuestion.TabIndex = 6;
            this.NextQuestion.Text = "עבור שאלה";
            this.NextQuestion.UseVisualStyleBackColor = false;
            this.NextQuestion.Click += new System.EventHandler(this.Pass);
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
            // Progress
            // 
            this.Progress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Progress.Location = new System.Drawing.Point(0, 541);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(1021, 23);
            this.Progress.TabIndex = 13;
            this.Progress.Value = 69;
            // 
            // FinishTest
            // 
            this.FinishTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FinishTest.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FinishTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FinishTest.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishTest.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FinishTest.Location = new System.Drawing.Point(44, 462);
            this.FinishTest.Name = "FinishTest";
            this.FinishTest.Size = new System.Drawing.Size(336, 47);
            this.FinishTest.TabIndex = 14;
            this.FinishTest.Text = "סיים";
            this.FinishTest.UseVisualStyleBackColor = false;
            this.FinishTest.Click += new System.EventHandler(this.FinishTest_Click);
            // 
            // QuestionsData
            // 
            this.QuestionsData.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.QuestionsData.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.QuestionsData.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.QuestionsData.Location = new System.Drawing.Point(386, 463);
            this.QuestionsData.Name = "QuestionsData";
            this.QuestionsData.Size = new System.Drawing.Size(278, 47);
            this.QuestionsData.TabIndex = 15;
            this.QuestionsData.Text = "3 / 30";
            this.QuestionsData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.QuestionsData.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // AllQuestions
            // 
            this.AllQuestions.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AllQuestions.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AllQuestions.FormattingEnabled = true;
            this.AllQuestions.Location = new System.Drawing.Point(44, 120);
            this.AllQuestions.Name = "AllQuestions";
            this.AllQuestions.Size = new System.Drawing.Size(336, 21);
            this.AllQuestions.TabIndex = 13;
            this.AllQuestions.SelectedIndexChanged += new System.EventHandler(this.AllQuestions_SelectedIndexChanged);
            // 
            // TestTimer
            // 
            this.TestTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TestTimer.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.TestTimer.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TestTimer.Location = new System.Drawing.Point(670, 97);
            this.TestTimer.Name = "TestTimer";
            this.TestTimer.Size = new System.Drawing.Size(339, 47);
            this.TestTimer.TabIndex = 16;
            this.TestTimer.Text = "40:00";
            this.TestTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TestTimer.Click += new System.EventHandler(this.TestTimer_Click);
            // 
            // Next
            // 
            this.Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Next.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Next.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Next.Location = new System.Drawing.Point(670, 429);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(159, 27);
            this.Next.TabIndex = 17;
            this.Next.Text = "<= שאלה הבאה";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Previous
            // 
            this.Previous.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Previous.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Previous.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Previous.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Previous.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Previous.Location = new System.Drawing.Point(850, 429);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(159, 27);
            this.Previous.TabIndex = 18;
            this.Previous.Text = "שאלה קודמת =>";
            this.Previous.UseVisualStyleBackColor = false;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // Countdown
            // 
            this.Countdown.Enabled = true;
            this.Countdown.Interval = 1000;
            this.Countdown.Tick += new System.EventHandler(this.Countdown_Tick);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1021, 564);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.NextQuestion);
            this.Controls.Add(this.TestTimer);
            this.Controls.Add(this.AllQuestions);
            this.Controls.Add(this.QuestionsData);
            this.Controls.Add(this.FinishTest);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.ans3);
            this.Controls.Add(this.ans2);
            this.Controls.Add(this.Photo);
            this.Controls.Add(this.ans1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ans4);
            this.Name = "TestForm";
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
        private System.Windows.Forms.Button NextQuestion;
        private System.Windows.Forms.PictureBox Photo;
        private System.Windows.Forms.RadioButton ans2;
        private System.Windows.Forms.RadioButton ans3;
        private System.Windows.Forms.RadioButton ans4;
        private System.Windows.Forms.Label test;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.ProgressBar Progress;
        private System.Windows.Forms.Button FinishTest;
        private System.Windows.Forms.Label QuestionsData;
        private System.Windows.Forms.ComboBox AllQuestions;
        private System.Windows.Forms.Label TestTimer;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.Timer Countdown;
    }
}

