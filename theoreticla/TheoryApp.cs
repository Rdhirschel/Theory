using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Theory
{
    public partial class TheoryApp : Form
    {
        public TheoryApp()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            Forms.Display = Display;
            Display.Controls.Add(Forms.main);
            Forms.main.Dock = DockStyle.Fill;

            Display.Controls.Add(Forms.iQ);
            Forms.iQ.Dock = DockStyle.Fill;

            Display.Controls.Add(Forms.testForm);
            Forms.testForm.Dock = DockStyle.Fill;

            Display.Controls.Add(Forms.qL);
            Forms.qL.Dock = DockStyle.Fill;

            Display.Controls.Add(Forms.wQ);
            Forms.wQ.Dock = DockStyle.Fill;

            Display.Controls.Add(Forms.tF);
            Forms.tF.Dock = DockStyle.Fill;

            Forms.main.Show();

            //test.Closed += (s, args) => this.Close();

        }

        private void TheoryApp_SizeChanged(object sender, EventArgs e)
        {

        }

        private void TheoryApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!GlobalVariables.flag)
            {
                // Check if there are unsaved changes or perform any necessary actions
                DialogResult result = MessageBox.Show("Do you want to save your changes?", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    GlobalVariables.SaveDataToFile();
                    GlobalVariables.flag = true;
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true; // Cancel the form closing
                    GlobalVariables.flag = false;
                }
                else
                {
                    GlobalVariables.flag = true;
                }
            }
        }

        private void Display_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    public static class Forms
    {
        public static MainMenu main = new MainMenu() { TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None, Visible = false };
        public static InfQuestion iQ = new InfQuestion() { TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None, Visible = false };
        public static TestForm testForm = new TestForm() { TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None, Visible = false };
        public static QuestionList qL = new QuestionList() { TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None, Visible = false };
        public static WrongQuestions wQ = new WrongQuestions() { TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None, Visible = false };
        public static TestFinish tF = new TestFinish() { TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None, Visible = false };

        public static Panel Display;
    }

}
