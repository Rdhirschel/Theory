using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Theory.Properties;

namespace Theory
{
   
    public partial class MainMenu : Form
    {
        public string filePath = AppDomain.CurrentDomain.BaseDirectory + "Data.txt";
        public MainMenu()
        {
            InitializeComponent();
            GlobalVariables.LoadDataFromFile();

            if (GlobalVariables.questions == 0)
            {
                label2.Text = "עוד לא ענית על שאלות";
                progressBar1.Value = 0;
            }
            else
            {
                int percentage = GlobalVariables.correct * 100 / GlobalVariables.questions;
                label2.Text = $"Total questions answered: {GlobalVariables.questions}, Correct: {percentage}%";
                progressBar1.Value = percentage;
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
            this.Hide();
            TestForm curr = new TestForm() { TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None, Visible = true };
            Forms.Display.Controls.Add(curr);
            curr.Dock = DockStyle.Fill;
            Forms.testForm = curr;
        }

        private void QuestionsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            InfQuestion curr = new InfQuestion() { TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None, Visible = true };
            Forms.Display.Controls.Add(curr);
            curr.Dock = DockStyle.Fill;
            Forms.iQ = curr;
        }
        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
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

    public static class GlobalVariables
    {
        public static int questions = 0;
        public static int correct = 0;
        public static ProgressBar ProgressBar { get; }
        public static Label label { get; }
        public static CustomList<int> numList = new CustomList<int>(new List<int>());
        public static CustomList<FullQuestion> DoneQuestions = new CustomList<FullQuestion>(new List<FullQuestion>());
        public static CustomList<FullQuestion> WrongQuestions = new CustomList<FullQuestion>(new List<FullQuestion>());
        public static int count = 0;
        public static bool flag = false;

        public static void SaveDataToFile()
        {
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "Data.txt";
            try
            {
                string[] lines = { GlobalVariables.questions.ToString(), GlobalVariables.correct.ToString(), GlobalVariables.numList.ToString(), GlobalVariables.DoneQuestions.ToString(), GlobalVariables.WrongQuestions.ToString() };
                File.WriteAllLines(filePath, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
        }

        public static void LoadDataFromFile()
        {
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "Data.txt";
            try
            {
                string[] lines = File.ReadAllLines(filePath);

                if (lines.Length > 1)
                {
                    File.WriteAllText(filePath, String.Empty);

                    if (int.TryParse(lines[0], out int _questions))
                    {
                        questions = _questions;
                    }

                    if (int.TryParse(lines[1], out int _correct))
                    {
                        correct = _correct;
                    }
                    string[] data = lines[2].Split(',');
                    if (data.Length != 0)
                    {
                        foreach (string a in data)
                        {
                            if (int.TryParse(a, out int QuestionNum))
                            {
                                numList.list.Add(QuestionNum);
                            }
                        }
                    }

                    string[] typeAndDataArray = lines[3].Split(',');
                    if (typeAndDataArray.Length != 0)
                    {
                        foreach (string a in typeAndDataArray)
                        {
                            if (int.TryParse(a, out int questionNum))
                            {
                                DoneQuestions.list.Add(new FullQuestion(questionNum));
                            }
                        }
                    }
                    string[] typeAndDataArray2 = lines[4].Split(',');
                    if (typeAndDataArray2.Length != 0)
                    {
                        foreach (string a in typeAndDataArray2)
                        {
                            if (int.TryParse(a, out int questionNum))
                            {
                                WrongQuestions.list.Add(new FullQuestion(questionNum));
                            }
                        }
                    }
                }
                File.WriteAllLines(filePath, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
