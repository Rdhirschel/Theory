namespace Theory
{
    partial class QuestionDesign
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Show_Hide_Button = new System.Windows.Forms.Button();
            this.ans_3 = new System.Windows.Forms.Label();
            this.ans_2 = new System.Windows.Forms.Label();
            this.ans_4 = new System.Windows.Forms.Label();
            this.ans_1 = new System.Windows.Forms.Label();
            this.Question = new System.Windows.Forms.Label();
            this.question_Pic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.question_Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.Show_Hide_Button);
            this.panel1.Controls.Add(this.ans_3);
            this.panel1.Controls.Add(this.ans_2);
            this.panel1.Controls.Add(this.ans_4);
            this.panel1.Controls.Add(this.ans_1);
            this.panel1.Controls.Add(this.Question);
            this.panel1.Controls.Add(this.question_Pic);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 268);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.Show_Hide_Button.Click += new System.EventHandler(this.Show_Hide_Button_Click);
            // 
            // ans_3
            // 
            this.ans_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ans_3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ans_3.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.ans_2.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.ans_4.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.ans_1.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ans_1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ans_1.Location = new System.Drawing.Point(532, 82);
            this.ans_1.Name = "ans_1";
            this.ans_1.Size = new System.Drawing.Size(265, 32);
            this.ans_1.TabIndex = 2;
            this.ans_1.Text = "תשובה1";
            this.ans_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ans_1.Click += new System.EventHandler(this.ans_1_Click);
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
            this.question_Pic.Click += new System.EventHandler(this.question_Pic_Click);
            // 
            // QuestionDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "QuestionDesign";
            this.Size = new System.Drawing.Size(800, 268);
            this.Load += new System.EventHandler(this.Testing_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.question_Pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Show_Hide_Button;
        private System.Windows.Forms.Label ans_3;
        private System.Windows.Forms.Label ans_2;
        private System.Windows.Forms.Label ans_4;
        private System.Windows.Forms.Label ans_1;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.PictureBox question_Pic;
    }
}
