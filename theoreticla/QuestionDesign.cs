using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Theory
{
    
    public partial class QuestionDesign : UserControl
    {
        //public int NumInOrder { get; set; }
        public int QuestionNum { get; set; }
        FullQuestion newQuestion;
        bool switch_ = false;
        public QuestionDesign(int _QuestionNum)
        {
            InitializeComponent();

            //DoubleBuffered = true;
            //ResizeRedraw = true;
            //this.SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer |
                          //ControlStyles.AllPaintingInWmPaint | ControlStyles.SupportsTransparentBackColor, true);
            Visible = true;

            BringToFront();

            QuestionNum = _QuestionNum;
            newQuestion = new FullQuestion(QuestionNum);

            ans_1.Text = newQuestion.ans1.Text;
            ans_2.Text = newQuestion.ans2.Text;
            ans_3.Text = newQuestion.ans3.Text;
            ans_4.Text = newQuestion.ans4.Text;

            Question.Text = newQuestion.question.Text;

            if (newQuestion.HasPicture)
            {
                question_Pic.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + $"Image Cool Theory Cool Maybe Cool Theory Cool\\question_{QuestionNum}_img.png");
            }
            else
            {
                question_Pic.Image = null;
            }
        }
        //public QuestionDesign()
        //{
        //    InitializeComponent();
        //    //Random rnd = new Random();
        //    QuestionNum = 10;
        //    newQuestion = new FullQuestion(QuestionNum);

        //    ans_1.Text = newQuestion.ans1.Text;
        //    ans_2.Text = newQuestion.ans2.Text;
        //    ans_3.Text = newQuestion.ans3.Text;
        //    ans_4.Text = newQuestion.ans4.Text;

        //    Question.Text = newQuestion.question.Text;

        //    if (newQuestion.HasPicture)
        //    {
        //        question_Pic.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + $"Image Cool Theory Cool Maybe Cool Theory Cool\\question_{QuestionNum}_img.png");
        //    }
        //    else
        //    {
        //        question_Pic.Image = null;
        //    }

        //}

        private void Testing_Load(object sender, EventArgs e)
        {

        }

        private void Show_Hide_Button_Click(object sender, EventArgs e)
        {
            if (!switch_)
            {
                if (newQuestion.ans1.IsCorrect)
                {
                    ans_1.ForeColor = Color.Green;
                }
                else if (newQuestion.ans2.IsCorrect)
                {
                    ans_2.ForeColor = Color.Green;
                }
                else if (newQuestion.ans3.IsCorrect)
                {
                    ans_3.ForeColor = Color.Green;
                }
                else
                {
                    ans_4.ForeColor = Color.Green;
                }
                Show_Hide_Button.Text = "הסתר תשובה";
                switch_ = true;
            }
            else
            {
                Show_Hide_Button.Text = "הראה תשובה";
                ans_1.ForeColor = Color.MidnightBlue;
                ans_2.ForeColor = Color.MidnightBlue;
                ans_3.ForeColor = Color.MidnightBlue;
                ans_4.ForeColor = Color.MidnightBlue;
                switch_ = false;
            }
        }

        private void question_Pic_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ans_1_Click(object sender, EventArgs e)
        {

        }
    }
}
