using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Theory
{
    public partial class InfQuestion : Form
    {
        Random rnd = new Random();
        RadioButton correctAnswer = null;
        RadioButton selected = null;
        FullQuestion newQuestion;
        bool pass = false;
        public InfQuestion()
        {
            InitializeComponent();
            if (GlobalVariables.numList.list.Count == 0)
            {
                GlobalVariables.numList = new CustomList<int>(Enumerable.Range(1, 1273).ToList());
                GlobalVariables.DoneQuestions = new CustomList<FullQuestion>(new List<FullQuestion>());
                GlobalVariables.WrongQuestions = new CustomList<FullQuestion>(new List<FullQuestion>());
            }
            int random = rnd.Next(0, GlobalVariables.numList.list.Count);
            int QuestionNum = GlobalVariables.numList.list[random];
            GlobalVariables.numList.list.RemoveAt(random);
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
                }
                else
                {
                    selected.ForeColor = Color.Red;
                }

                Check_Pass.Text = "עבור שאלה";
            }
            else if (pass)
            {
                GlobalVariables.DoneQuestions.list.Add(newQuestion);
                if (correctAnswer != selected)
                {
                    GlobalVariables.WrongQuestions.list.Add(newQuestion);
                }
                correctAnswer.ForeColor = Color.MidnightBlue;
                correctAnswer = null;

                selected.ForeColor = Color.MidnightBlue;
                selected.Checked = false;
                selected = null;

                if (GlobalVariables.numList.list.Count == 0)
                {
                    GlobalVariables.numList = new CustomList<int>(Enumerable.Range(1, 1273).ToList());
                    GlobalVariables.DoneQuestions = new CustomList<FullQuestion>(new List<FullQuestion>());
                    GlobalVariables.WrongQuestions = new CustomList<FullQuestion>(new List<FullQuestion>());
                }
                int random = rnd.Next(1, GlobalVariables.numList.list.Count);
                //Save into DoneQuestions:

                int QuestionNum = GlobalVariables.numList.list[random];

                test.Text = QuestionNum.ToString();
                newQuestion = new FullQuestion(QuestionNum);
                ans1.Text = newQuestion.ans1.Text;
                ans2.Text = newQuestion.ans2.Text;
                ans3.Text = newQuestion.ans3.Text;
                ans4.Text = newQuestion.ans4.Text;

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
        private void InfQuestion_FormClosed(object sender, FormClosedEventArgs e)
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

        private void InfQuestion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!GlobalVariables.flag)
            {
                DialogResult result = MessageBox.Show("Do you want to save your changes?", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    GlobalVariables.SaveDataToFile();
                    GlobalVariables.flag = true;
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true; 
                    GlobalVariables.flag = false;
                }
                else
                {
                    GlobalVariables.flag = true;
                }
            }
        }
    }
    public class FullQuestion
    {
        public Question question { set; get; }
        public Answer ans1 { set; get; }
        public Answer ans2 { set; get; }
        public Answer ans3 { set; get; }
        public Answer ans4 { set; get; }
        public bool HasPicture { set; get; }
        public string Picture { set; get; }
        public FullQuestion(int QuestionNum)
        {
            question = new Question(QuestionNum);
            ans1 = new Answer(1, QuestionNum);
            ans2 = new Answer(2, QuestionNum);
            ans3 = new Answer(3, QuestionNum);
            ans4 = new Answer(4, QuestionNum);

            //Search If Image Path Exists:
            string fullPath = AppDomain.CurrentDomain.BaseDirectory + $"Image Cool Theory Cool Maybe Cool Theory Cool\\question_{QuestionNum}_img.png";

            HasPicture = File.Exists(fullPath);
            if (HasPicture)
            {
                Picture = fullPath;
            }
        }
        public override string ToString()
        {
            return $"{question.QuestionNum}";
        }
        public static bool TryParse(string input, out FullQuestion fullQuestion)
        {
            fullQuestion = null;
            try
            {
                string[] typeAndData = input.Split(';');
                for (int i = 0; i < typeAndData.Length; i++)
                {
                    string[] data = typeAndData[i].Split(';');
                    if (data.Length == 2)
                    {
                        if (int.TryParse(data[1], out int QuestionNum))
                        {
                            fullQuestion = new FullQuestion(QuestionNum);
                            return true;
                        }
                    }
                }
            }
            catch
            {
            }
            return false;
        }
    }
    public class Answer
    {
        public string Text { set; get; }
        public bool IsCorrect { set; get; }
        public Answer(int AnsNum, int QuestionNum)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "questions_and_answers.txt");
            string line;
            int desiredLine = 2 + AnsNum + 7 * (QuestionNum - 1);
            int currentLine = 1;

            using (StreamReader sr = new StreamReader(filePath))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    if (currentLine == desiredLine)
                    {
                        Text = line;
                        if (Text[Text.Length - 1] == '*')
                        {
                            Text = Text.Substring(0, Text.Length - 1);
                            IsCorrect = true;
                        }
                        break;
                    }
                    currentLine++;
                }
                sr.Close();
            }
        }
        public override string ToString()
        {
            return $"";
        }
    }
    public class Question
    {
        public string Text { set; get; }
        public int QuestionNum { set; get; }
        public Question(int QuestionNum)
        {
            this.QuestionNum = QuestionNum;

            string filePath = AppDomain.CurrentDomain.BaseDirectory + "questions_and_answers.txt";
            string line;
            int desiredLine = 1 + 7 * (QuestionNum - 1);
            int currentLine = 1;

            using (StreamReader sr = new StreamReader(filePath))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    if (currentLine == desiredLine)
                    {
                        Text = line;
                        break;
                    }
                    currentLine++;
                }
                sr.Close();
            }
        }
        public override string ToString()
        {
            return $"{QuestionNum}";
        }
    }
    public class CustomList<T>
    {
        public List<T> list { set; get; }
        public CustomList(List<T> list)
        {
            this.list = list;
        }
        public override string ToString()
        {
            return string.Join(",", this.list);
        }
    }
}
