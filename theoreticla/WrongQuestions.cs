using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Theory
{
    public partial class WrongQuestions : Form
    {
        int random;
        Random rnd = new Random();
        RadioButton correctAnswer = null;
        RadioButton selected = null;
        FullQuestion newQuestion;
        bool pass = false;
        public WrongQuestions()
        {
            InitializeComponent();
            allDone.Visible = false;
            if (GlobalVariables.WrongQuestions.list.Count == 0)
            {
                Control controlToKeep = allDone;
                Control controlToKeep2 = returnButton;
                Controls.Clear();
                Controls.Add(controlToKeep);
                Controls.Add(controlToKeep2);
                allDone.Dock = DockStyle.Fill;
                allDone.Visible = true;
                allDone.SendToBack();
            }
            else
            {
                random = rnd.Next(0, GlobalVariables.WrongQuestions.list.Count);
                int QuestionNum = GlobalVariables.WrongQuestions.list[random].question.QuestionNum;
                test.Text = QuestionNum.ToString();
                newQuestion = new FullQuestion(QuestionNum);
                ans1.Text = newQuestion.ans1.Text;
                ans2.Text = newQuestion.ans2.Text;
                ans3.Text = newQuestion.ans3.Text;
                ans4.Text = newQuestion.ans4.Text;
                if (newQuestion.ans1.IsCorrect)
                {
                    correctAnswer = ans1;
                }
                else if (newQuestion.ans2.IsCorrect)
                {
                    correctAnswer = ans2;
                }
                else if (newQuestion.ans3.IsCorrect)
                {
                    correctAnswer = ans3;
                }
                else
                {
                    correctAnswer = ans4;
                }


                Question.Text = newQuestion.question.Text;
                if (newQuestion.HasPicture)
                {
                    Photo.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + $"Image Cool Theory Cool Maybe Cool Theory Cool\\question_{QuestionNum}_img.png");
                }
                else
                {
                    Photo.Image = null;
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Test_Click(object sender, EventArgs e)
        {

        }
        private void Check_Or_Pass(object sender, EventArgs e)
        {
            if ((ans1.Checked || ans2.Checked || ans3.Checked || ans4.Checked) && !pass)
            {
                GlobalVariables.questions++;
                pass = true;

                if (newQuestion.ans1.IsCorrect)
                {
                    ans1.ForeColor = Color.Green;
                    correctAnswer = ans1;
                }
                else if (newQuestion.ans2.IsCorrect)
                {
                    ans2.ForeColor = Color.Green;
                    correctAnswer = ans2;
                }
                else if (newQuestion.ans3.IsCorrect)
                {
                    ans3.ForeColor = Color.Green;
                    correctAnswer = ans3;
                }
                else
                {
                    ans4.ForeColor = Color.Green;
                    correctAnswer = ans4;
                }

                if (selected == correctAnswer)
                {
                    GlobalVariables.correct++;
                    GlobalVariables.WrongQuestions.list.RemoveAt(random);
                }
                else
                {
                    selected.ForeColor = Color.Red;
                }

                Check_Pass.Text = "עבור שאלה";

            }
            else if (pass)
            {
                correctAnswer.ForeColor = Color.MidnightBlue;
                correctAnswer = null;

                selected.ForeColor = Color.MidnightBlue;
                selected.Checked = false;
                selected = null;

                if (GlobalVariables.WrongQuestions.list.Count == 0)
                {
                    Control controlToKeep = allDone;
                    Control controlToKeep2 = returnButton;
                    Controls.Clear();
                    Controls.Add(controlToKeep);
                    Controls.Add(controlToKeep2);
                    allDone.Dock = DockStyle.Fill;
                    allDone.Visible = true;
                    allDone.SendToBack();
                }
                Check_Pass.Text = "בדוק";
                if (GlobalVariables.WrongQuestions.list.Count > 0)
                {
                    random = rnd.Next(0, GlobalVariables.WrongQuestions.list.Count);

                    int QuestionNum = GlobalVariables.WrongQuestions.list[random].question.QuestionNum;

                    test.Text = QuestionNum.ToString();
                    newQuestion = new FullQuestion(QuestionNum);
                    ans1.Text = newQuestion.ans1.Text;
                    ans2.Text = newQuestion.ans2.Text;
                    ans3.Text = newQuestion.ans3.Text;
                    ans4.Text = newQuestion.ans4.Text;

                    if (newQuestion.ans1.IsCorrect)
                    {
                        correctAnswer = ans1;
                    }
                    else if (newQuestion.ans2.IsCorrect)
                    {
                        correctAnswer = ans2;
                    }
                    else if (newQuestion.ans3.IsCorrect)
                    {
                        correctAnswer = ans3;
                    }
                    else
                    {
                        correctAnswer = ans4;
                    }

                    Question.Text = newQuestion.question.Text;
                    GlobalVariables.numList.list.RemoveAt(random);
                    pass = false;
                    Check_Pass.Text = "בדוק";
                    if (newQuestion.HasPicture)
                    {
                        Photo.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + $"Image Cool Theory Cool Maybe Cool Theory Cool\\question_{QuestionNum}_img.png");
                    }
                    else
                    {
                        Photo.Image = null;
                    }
                }
            }
            else
            {
            }
            }

        private bool shouldHandleChange = true;
        private void Ans1_CheckedChanged(object sender, EventArgs e)
        {
            if (ans1.Checked && Check_Pass.Text == "עבור שאלה" && shouldHandleChange)
            {
                shouldHandleChange = false;
                ans1.Checked = false;
                selected.Checked = true;
                correctAnswer.ForeColor = Color.Green;
                if (selected != correctAnswer)
                {
                    selected.ForeColor = Color.Red;
                }
                shouldHandleChange = true;
            }
            else if (ans1.Checked)
            {
                selected = ans1;
            }
            shouldHandleChange = true;
        }
        private void ans2_CheckedChanged(object sender, EventArgs e)
        {
            if (ans2.Checked && Check_Pass.Text == "עבור שאלה" && shouldHandleChange)
            {
                shouldHandleChange = false;
                ans2.Checked = false;
                selected.Checked = true;
                correctAnswer.ForeColor = Color.Green;
                if (selected != correctAnswer)
                {
                    selected.ForeColor = Color.Red;
                }
                shouldHandleChange = true;
            }
            else if (ans2.Checked)
            {
                selected = ans2;
            }

        }
        private void ans3_CheckedChanged(object sender, EventArgs e)
        {
            if (ans3.Checked && Check_Pass.Text == "עבור שאלה" && shouldHandleChange)
            {
                shouldHandleChange = false;
                ans3.Checked = false;
                selected.Checked = true;
                correctAnswer.ForeColor = Color.Green;
                if (selected != correctAnswer)
                {
                    selected.ForeColor = Color.Red;
                }
                shouldHandleChange = true;
            }
            else if (ans3.Checked)
            {
                selected = ans3;
            }
        }
        private void ans4_CheckedChanged(object sender, EventArgs e)
        {
            if (ans4.Checked && Check_Pass.Text == "עבור שאלה" && shouldHandleChange)
            {
                shouldHandleChange = false;
                ans4.Checked = false;
                selected.Checked = true;
                correctAnswer.ForeColor = Color.Green;
                if (selected != correctAnswer)
                {
                    selected.ForeColor = Color.Red;
                }
                shouldHandleChange = true;
            }
            else if (ans4.Checked)
            {
                selected = ans4;
            }
        }
        private void ReturnButton(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu curr = new MainMenu() { TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None, Visible = true };
            Forms.Display.Controls.Add(curr);
            curr.Dock = DockStyle.Fill;
            Forms.main = curr;
        }
        private void WrongQuestions_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void ShowPrevQuestions(object sender, EventArgs e)
        {
            this.Hide();
            QuestionList curr = new QuestionList() { TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None, Visible = true };
            Forms.Display.Controls.Add(curr);
            curr.Dock = DockStyle.Fill;
            Forms.qL = curr;
        }

        private void WrongQuestions_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
