using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Theory
{
    public partial class TestFinish : Form
    {
        private List<int> Answered;
        private List<int> wrong;
        public TestFinish(List<int> Answered, List<int> wrong)
        {
            InitializeComponent();
            this.Answered = Answered.Distinct().ToList();
            this.wrong = wrong.Distinct().ToList();
            //DoubleBuffered = true;
            Example.Visible = false;
            unanswered.Visible = false;
            unanswered.SendToBack();
            if (this.wrong.Count <= 4)
            {
                Counter.ForeColor = Color.Green;
                Counter.Text = $"{this.Answered.Count - this.wrong.Count} / {this.Answered.Count}   -   עברת";
            }
            else
            {
                Counter.ForeColor = Color.Red;
                Counter.Text = $"{this.Answered.Count - this.wrong.Count} / {this.Answered.Count}   -   נכשלת";
            }

            for (int i = 0; i < this.Answered.Count; i++)
            {
                int offset = 15;
                if (i == 0)
                {
                    offset = 0;
                }
                QuestionDesign visableQuestion = new QuestionDesign(this.Answered[i])
                {
                    //Dock = DockStyle.Fill,
                    Location = new Point(Example.Location.X, Example.Location.Y + Example.Height * i + offset),
                    Size = new Size(Example.Width, Example.Height),
                    Name = Name + i,
                    Visible = true,
                    Anchor = AnchorStyles.Top,
                };

                Scroll_Panel.Controls.Add(visableQuestion);
                visableQuestion.Show();
                visableQuestion.BringToFront();
            }
        }
        public TestFinish()
        {
            InitializeComponent();
        }

        private void returnMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu curr = new MainMenu() { TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None, Visible = true };
            Forms.Display.Controls.Add(curr);
            curr.Dock = DockStyle.Fill;
            Forms.main = curr;
        }

        private void returnInf_Click(object sender, EventArgs e)
        {
            this.Hide();
            InfQuestion curr = new InfQuestion() { TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None, Visible = true };
            Forms.Display.Controls.Add(curr);
            curr.Dock = DockStyle.Fill;
            Forms.iQ = curr;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Question_Click(object sender, EventArgs e)
        {

        }

        private void Question_Show_Paint(object sender, PaintEventArgs e)
        {

        }


        private void AllQuestions_button_CheckedChanged(object sender, EventArgs e)
        {
            Control controlToKeep = Scroll_Panel.Controls["Example"];
            Control controlToKeep2 = unanswered;
            Scroll_Panel.Controls.Clear();
            Scroll_Panel.Controls.Add(controlToKeep);
            Controls.Add(controlToKeep2);

            if (AllQuestions_button.Checked)
            {
                unanswered.Visible = false;
                unanswered.SendToBack();

                for (int i = 0; i < this.Answered.Count; i++)
                {
                    int offset = 15;
                    if (i == 0)
                    {
                        offset = 0;
                    }
                    QuestionDesign visableQuestion = new QuestionDesign(this.Answered[i])
                    {
                        //Dock = DockStyle.Fill,
                        Location = new Point(Example.Location.X, Example.Location.Y + Example.Height * i + offset),
                        Size = new Size(Example.Width, Example.Height),
                        Name = Name + i,
                        Visible = true,
                        Anchor = AnchorStyles.Top,
                    };

                    Scroll_Panel.Controls.Add(visableQuestion);
                    visableQuestion.Show();
                    visableQuestion.BringToFront();
                }
            }
                Scroll_Panel.Refresh();
            }

        private void WrongQuestions_button_CheckedChanged(object sender, EventArgs e)
        {
            Control controlToKeep = Scroll_Panel.Controls["Example"];
            Control controlToKeep2 = unanswered;
            Scroll_Panel.Controls.Clear();
            Scroll_Panel.Controls.Add(controlToKeep);
            Controls.Add(controlToKeep2);

            if (WrongQuestions_button.Checked)
            {
                if (wrong.Count == 0)
                {
                    unanswered.Visible = true;
                    unanswered.Text = "לא טעית! כל הכבוד!";
                    unanswered.Dock = DockStyle.Fill;
                    unanswered.BringToFront();
                }
                else
                {
                    unanswered.Visible = false;
                    unanswered.SendToBack();

                    for (int i = 0; i < this.wrong.Count; i++)
                    {
                        int offset = 15;
                        if (i == 0)
                        {
                            offset = 0;
                        }
                        QuestionDesign visableQuestion = new QuestionDesign(this.wrong[i])
                        {
                            //Dock = DockStyle.Fill,
                            Location = new Point(Example.Location.X, Example.Location.Y + Example.Height * i + offset),
                            Size = new Size(Example.Width, Example.Height),
                            Name = Name + i,
                            Visible = true,
                            Anchor = AnchorStyles.Top,
                        };

                        Scroll_Panel.Controls.Add(visableQuestion);
                        visableQuestion.Show();
                        visableQuestion.BringToFront();
                    }
                }
                Scroll_Panel.Refresh();
            }
        }

        private void unanswered_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void QuestionList_FormClosing(object sender, FormClosingEventArgs e)
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

        private void GoQuestions_Click(object sender, EventArgs e)
        {
            this.Hide();
            WrongQuestions curr = new WrongQuestions() { TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None, Visible = true };
            Forms.Display.Controls.Add(curr);
            curr.Dock = DockStyle.Fill;
            Forms.wQ = curr;
        }

        private void Reset_Questions_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("זה יאתחל את כל השאלות. כלומר, יש שאלות שיחזרו על עצמן", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                GlobalVariables.numList = new CustomList<int>(Enumerable.Range(1, 1273).ToList());
                GlobalVariables.DoneQuestions = new CustomList<FullQuestion>(new List<FullQuestion>());
                GlobalVariables.WrongQuestions = new CustomList<FullQuestion>(new List<FullQuestion>());
                Control controlToKeep = Example;
                Control controlToKeep2 = Scroll_Panel.Controls["unanswered"];
                Scroll_Panel.Controls.Clear();
                Scroll_Panel.Controls.Add(controlToKeep);
                Controls.Add(controlToKeep2);

                unanswered.Dock = DockStyle.Fill;
                unanswered.Visible = true;
                unanswered.BringToFront();
                Refresh();
            }
            else
            {

            }
        }

        private void unanswered_Click_1(object sender, EventArgs e)
        {

        }

        private void Scroll_Panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
