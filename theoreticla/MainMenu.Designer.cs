namespace Theory
{
    partial class MainMenu
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
            this.TestButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.QuestionsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(716, 92);
            this.label1.TabIndex = 0;
            this.label1.Text = "הכנה לתאוריה";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 92);
            this.panel1.TabIndex = 1;
            // 
            // TestButton
            // 
            this.TestButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TestButton.AutoSize = true;
            this.TestButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TestButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TestButton.Font = new System.Drawing.Font("Cascadia Mono", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TestButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TestButton.ImageKey = "(none)";
            this.TestButton.Location = new System.Drawing.Point(165, 196);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(411, 70);
            this.TestButton.TabIndex = 2;
            this.TestButton.Text = "מבחן דוגמה";
            this.TestButton.UseVisualStyleBackColor = false;
            this.TestButton.Click += new System.EventHandler(this.Test_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar1.Location = new System.Drawing.Point(165, 512);
            this.progressBar1.MarqueeAnimationSpeed = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(411, 23);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Value = 70;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // QuestionsButton
            // 
            this.QuestionsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuestionsButton.AutoSize = true;
            this.QuestionsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.QuestionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.QuestionsButton.Font = new System.Drawing.Font("Cascadia Mono", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionsButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.QuestionsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.QuestionsButton.ImageKey = "(none)";
            this.QuestionsButton.Location = new System.Drawing.Point(165, 285);
            this.QuestionsButton.Name = "QuestionsButton";
            this.QuestionsButton.Size = new System.Drawing.Size(411, 70);
            this.QuestionsButton.TabIndex = 4;
            this.QuestionsButton.Text = "שאלות אינסופיות";
            this.QuestionsButton.UseVisualStyleBackColor = false;
            this.QuestionsButton.Click += new System.EventHandler(this.QuestionsButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(162, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(414, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "שאלות: כדגכדגכ אחוז הצלחה: דגכדג";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(740, 551);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QuestionsButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.panel1);
            this.Name = "MainMenu";
            this.Text = "InfQuestion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button QuestionsButton;
        private System.Windows.Forms.Label label2;
    }
}

