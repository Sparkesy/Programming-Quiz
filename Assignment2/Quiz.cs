using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Quiz : Form
    {
        private List<Question> questions;
        private int currentQuestion = 0;
        private int numCorrect = 0;
        public Quiz()
        {
            InitializeComponent();
            // Initialize questions
            questions = new List<Question>();
            questions.Add(new Question("What does the 'using' keyword do in C#?",
                new string[] { "Imports a namespace", "Declares a variable",
                "Defines a method", "Throws an exception" }, 0));
            questions.Add(new Question("What is a variable in programming?",
                new string[] { "A way to store and access data in a program", "A program that can run on different platforms",
                "A type of programming language", "A way to create new classes in C#" }, 0));
            questions.Add(new Question("What is a loop in programming?",
                new string[] { "A tool used to organize code into reusable modules",
                "A data structure used to store multiple pieces of data",
                "A type of programming language",
                "A structure used to repeat a section of code" }, 3));
            questions.Add(new Question("What is debugging in programming?",
                new string[] { "The process of finding and fixing errors in code",
                "The process of optimizing code for performance",
                "The process of creating new features for a program",
                "The process of compiling code into an executable files" }, 0));
            questions.Add(new Question("What is an algorithm in programming?",
                new string[] { "A step-by-step procedure for solving a problem",
                "A type of programming language",
                "A tool used to manipulate data in a program",
                "A program that automatically generates code" }, 0));

            // Display first question
            DisplayQuestion();
        }
        private void DisplayQuestion()
        {
            // Display the current question and answer choices
            Question question = questions[currentQuestion];
            QuestionBox.Text = question.Text;
            QuestionBox.MaximumSize = new Size(200, 0);
            QuestionBox.AutoSize = true;
            Answer1.Text = question.Choices[0];
            Answer2.Text = question.Choices[1];
            Answer3.Text = question.Choices[2];
            Answer4.Text = question.Choices[3];
        }
        private void CheckAnswer(int choiceIndex)
        {
            Question question = questions[currentQuestion];
            if (question.CorrectChoiceIndex == choiceIndex)
            {
                numCorrect++;
            }

            currentQuestion++;

            if (currentQuestion < questions.Count)
            {
                // Display next question
                DisplayQuestion();
            }
            else
            {
                // Quiz is complete, display results
                int score = (int)(((double)numCorrect / questions.Count) * 100);
                ResultsForm results = new ResultsForm(numCorrect, questions.Count, score);
                results.ShowDialog();
                Close();
            }
        }


        private void Answer1_Click(object sender, EventArgs e)
        {
            CheckAnswer(0);
        }

        private void Answer2_Click(object sender, EventArgs e)
        {
            CheckAnswer(1);
        }

        private void Answer3_Click(object sender, EventArgs e)
        {
            CheckAnswer(2);
        }

        private void Answer4_Click(object sender, EventArgs e)
        {
            CheckAnswer(3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new main().Show();
        }
    }
}
