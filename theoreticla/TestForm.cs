using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Theory
{
    public partial class TestForm : Form
    {
        bool hasntPoppedUp = true;
        Random rnd = new Random();
        RadioButton correctAnswer = null;
        RadioButton selected = null;
        FullQuestion newQuestion;
        int pass = 0;
        List<int> allPossibleQuestions = new List<int>(Enumerable.Range(1, 1273).ToList());
        List<int> questions = new List<int>();
        List<int> answeredQuestions_ = new List<int>();
        List<int> Selected = new List<int>();
        List<int> wrong = new List<int>();
        int counter = 0;

        int seconds = 0;
        public TestForm()
        {
            InitializeComponent();
            for (int i = 0; i < 30; i++)
            {
                int ind = rnd.Next(0, allPossibleQuestions.Count);
                questions.Add(allPossibleQuestions[ind]);
                allPossibleQuestions.RemoveAt(ind);
                AllQuestions.Items.Add(i + 1);
                Selected.Add(0);
            }

            AllQuestions.SelectedIndex = 0;
            int QuestionNum = questions[counter];
            test.Text = QuestionNum.ToString();
            newQuestion = new FullQuestion(QuestionNum);
            ans1.Text = newQuestion.ans1.Text;
            ans2.Text = newQuestion.ans2.Text;
            ans3.Text = newQuestion.ans3.Text;
            ans4.Text = newQuestion.ans4.Text;
            Question.Text = newQuestion.question.Text;
            if (newQuestion.HasPicture)
            {
                Photo.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + $"Image Cool Theory Cool Maybe Cool Theory Cool\\question_{QuestionNum}_img.png");
            }
            else
            {
                Photo.Image = null;
            }
            counter++;
            QuestionsData.Text = $"{counter - 1} / 30";
            Progress.Value = (int)(((counter-1) * 100) / 30);

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
        private void Pass(object sender, EventArgs e)
        {
            if ((ans1.Checked || ans2.Checked || ans3.Checked || ans4.Checked) && counter != 31)
            {
                int index = AllQuestions.SelectedIndex;
                int QuestionNum = questions[index];
                bool cond = !answeredQuestions_.Contains(QuestionNum);

                ans1.Checked = false;
                ans2.Checked = false;
                ans3.Checked = false;
                ans4.Checked = false;

                if (cond)
                {
                    answeredQuestions_.Add(QuestionNum);
                    counter++;
                }

                else
                {
                    foreach (int ans in answeredQuestions_)
                    {
                        if (QuestionNum == ans)
                        {
                            ans1.Checked = false;
                            ans2.Checked = false;
                            ans3.Checked = false;
                            ans4.Checked = false;

                            if (Selected[index] != 0)
                            {
                                SelectedButton(index).Checked = true;
                            }
                        }
                    }
                }
                if (index == 29 || !cond)
                {

                    for (int i = 0; i < questions.Count; i++)
                    {
                        if (!answeredQuestions_.Contains(questions[i]))
                        {
                            QuestionNum = questions[i];
                            AllQuestions.SelectedIndex = i;
                            break;
                        }
                    }
                }

                test.Text = QuestionNum.ToString();
                newQuestion = new FullQuestion(QuestionNum);
                ans1.Text = newQuestion.ans1.Text;
                ans2.Text = newQuestion.ans2.Text;
                ans3.Text = newQuestion.ans3.Text;
                ans4.Text = newQuestion.ans4.Text;
                Question.Text = newQuestion.question.Text;
                if (newQuestion.HasPicture)
                {
                    Photo.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + $"Image Cool Theory Cool Maybe Cool Theory Cool\\question_{QuestionNum}_img.png");
                }
                else
                {
                    Photo.Image = null;
                }
                if (index != 29 && cond)
                {
                    AllQuestions.SelectedIndex = ++index;
                }

                QuestionsData.Text = $"{counter - 1} / 30";
                Progress.Value = (int)(((counter - 1) * 100) / 30);
            }
            if (answeredQuestions_.Distinct().ToList().Count == 30)
            {
                if (hasntPoppedUp)
                {
                    MessageBox.Show("סיימת את השאלון! כל מה שנותר הוא ללחוץ על כפתור הסיום");
                    hasntPoppedUp = false;
                }
                //answeredQuestions_.Add(questions[AllQuestions.SelectedIndex]);
            }

        }
        private void Ans1_CheckedChanged(object sender, EventArgs e)
        {
            if (ans1.Checked)
            {
                selected = ans1;
                Selected[AllQuestions.SelectedIndex] = 1;
            }
        }
        private void ans2_CheckedChanged(object sender, EventArgs e)
        {
            if (ans2.Checked)
            {
                selected = ans2;
                Selected[AllQuestions.SelectedIndex] = 2;
            }
        }
        private void ans3_CheckedChanged(object sender, EventArgs e)
        {
            if (ans3.Checked)
            {
                selected = ans3;
                Selected[AllQuestions.SelectedIndex] = 3;
            }
        }
        private void ans4_CheckedChanged(object sender, EventArgs e)
        {
            if (ans4.Checked)
            {
                selected = ans4;
                Selected[AllQuestions.SelectedIndex] = 4;
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
        private void InfQuestion_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void ShowPrevQuestions(object sender, EventArgs e)
        {
            this.Hide();
            QuestionList question = new QuestionList()
            {
                Size = this.Size,
                Location = this.Location,
                WindowState = this.WindowState,

            };
            question.Closed += (s, args) => this.Close();
            question.Show();
        }

        private void InfQuestion_FormClosing(object sender, FormClosingEventArgs e)
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void FinishTest_Click(object sender, EventArgs e)
        {
            if (answeredQuestions_.Distinct().ToList().Count == 30)
            {
                answeredQuestions_ = answeredQuestions_.Distinct().ToList();
                for (int i = 0; i < answeredQuestions_.Count; i++)
                {
                    int ans = answeredQuestions_[i];
                    FullQuestion curr_ = new FullQuestion(ans);
                    int buttonSelected = Selected[i];
                    int correct = 0;
                    if (curr_.ans1.IsCorrect)
                    {
                        correct = 1;
                    }
                    else if (curr_.ans2.IsCorrect)
                    {
                        correct = 2;
                    }
                    else if (curr_.ans3.IsCorrect)
                    {
                        correct = 3;
                    }
                    else
                    {
                        correct = 4;
                    }

                    if (buttonSelected == correct)
                    {
                        pass++;
                    }
                    else
                    {
                        wrong.Add(ans);
                    }



                }

                this.Hide();
                TestFinish curr = new TestFinish(answeredQuestions_, wrong) { TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None, Visible = true };
                Forms.Display.Controls.Add(curr);
                curr.Dock = DockStyle.Fill;
                Forms.tF = curr;
            }
            else
            {
                MessageBox.Show("קודם יש לסיים את כל שאלות המבחן");
            }
        }

        private void AllQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            int theIndex = AllQuestions.SelectedIndex;
            int QuestionNum = questions[theIndex];
            test.Text = QuestionNum.ToString();
            newQuestion = new FullQuestion(QuestionNum);
            ans1.Text = newQuestion.ans1.Text;
            ans2.Text = newQuestion.ans2.Text;
            ans3.Text = newQuestion.ans3.Text;
            ans4.Text = newQuestion.ans4.Text;
            Question.Text = newQuestion.question.Text;
            if (newQuestion.HasPicture)
            {
                Photo.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + $"Image Cool Theory Cool Maybe Cool Theory Cool\\question_{QuestionNum}_img.png");
            }
            else
            {
                Photo.Image = null;
            }

            ans1.Checked = false;
            ans2.Checked = false;
            ans3.Checked = false;
            ans4.Checked = false;

            if (Selected[theIndex] != 0)
            {
                SelectedButton(theIndex).Checked = true;
            }
        }


        public RadioButton SelectedButton(int i)
        {
            if (Selected[i] == 1)
            {
                return ans1;
            }
            else if (Selected[i] == 2)
            {
                return ans2;
            }
            else if (Selected[i] == 3)
            {
                return ans3;
            }
            return ans4;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (AllQuestions.SelectedIndex != 29)
            {
                int QuestionNum = questions[AllQuestions.SelectedIndex];
                if ((ans1.Checked || ans2.Checked || ans3.Checked || ans4.Checked) && !answeredQuestions_.Contains(QuestionNum))
                {
                    answeredQuestions_.Add(QuestionNum);
                    counter++;

                    QuestionsData.Text = $"{counter - 1} / 30";
                    Progress.Value = (int)(((counter - 1) * 100) / 30);
                }
                AllQuestions.SelectedIndex++;
            }
            if (answeredQuestions_.Distinct().ToList().Count == 30)
            {
                if (hasntPoppedUp)
                {
                    MessageBox.Show("סיימת את השאלון! כל מה שנותר הוא ללחוץ על כפתור הסיום");
                    hasntPoppedUp = false;
                }
                //answeredQuestions_.Add(questions[AllQuestions.SelectedIndex]);
            }
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            if (AllQuestions.SelectedIndex != 0)
            {
                int QuestionNum = questions[AllQuestions.SelectedIndex];
                if ((ans1.Checked || ans2.Checked || ans3.Checked || ans4.Checked) && !answeredQuestions_.Contains(QuestionNum))
                {
                    answeredQuestions_.Add(QuestionNum);
                    counter++;

                    QuestionsData.Text = $"{counter - 1} / 30";
                    Progress.Value = (int)(((counter - 1) * 100) / 30);
                }
                AllQuestions.SelectedIndex--;
            }
            if (answeredQuestions_.Distinct().ToList().Count == 30)
            {
                if (hasntPoppedUp)
                {
                    MessageBox.Show("סיימת את השאלון! כל מה שנותר הוא ללחוץ על כפתור הסיום");
                    hasntPoppedUp = false;
                }
                //answeredQuestions_.Add(questions[AllQuestions.SelectedIndex]);
            }
        }

        private void TestTimer_Click(object sender, EventArgs e)
        {

        }

        private void Countdown_Tick(object sender, EventArgs e)
        {
            if (Visible)
            {
                seconds++;
                int mins = 40 - (seconds / 60);
                int secs = (40 * 60 - seconds) % 60;
                if (secs > 0)
                {
                    mins--;
                }
                if (mins * 60 + secs == 0)
                {
                    MessageBox.Show("חרגת ממגבלת הזמן");
                    this.Hide();
                    MainMenu curr = new MainMenu() { TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None, Visible = true };
                    Forms.Display.Controls.Add(curr);
                    curr.Dock = DockStyle.Fill;
                    Forms.main = curr;
                }
                if (secs.ToString().Length == 1)
                {
                    TestTimer.Text = $"{mins}:0{secs}";
                }
                else
                {
                    TestTimer.Text = $"{mins}:{secs}";
                }
            }
        }
    }
}
