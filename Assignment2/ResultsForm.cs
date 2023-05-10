using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApplication1
{
    public partial class ResultsForm : Form
    {
        private int numCorrect;
        private int numQuestions;
        private int score;

        public ResultsForm(int numCorrect, int numQuestions, int score)
        {
            InitializeComponent();

            // Display score information
            this.numCorrect = numCorrect;
            this.numQuestions = numQuestions;
            this.score = score;
            numCorrectLabel.Text = numCorrect.ToString();
            numQuestionsLabel.Text = numQuestions.ToString();
            ScoreBox.Text = score.ToString() + "%";

            // Save score to file
            SaveScore();
        }

        private void SaveScore()
        {

            // Get the user's name
            string name = GetUserName();

            // Create a new leaderboard entry with the user's name and score
            LeaderboardEntry entry = new LeaderboardEntry
            {
                Name = name,
                Score = score
            };

            // Serialize the leaderboard entry to an XML file
            XmlSerializer serializer = new XmlSerializer(typeof(List<LeaderboardEntry>));
            List<LeaderboardEntry> entries = new List<LeaderboardEntry>();

            try
            {
                using (FileStream fs = new FileStream("leaderboard.xml", FileMode.OpenOrCreate))
                {
                    if (fs.Length != 0)
                    {
                        entries = (List<LeaderboardEntry>)serializer.Deserialize(fs);
                    }

                    entries.Add(entry);

                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        serializer.Serialize(sw, entries);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



        private string GetUserName()
        {
            // Prompt the user to enter their name using a message box
            string name = null;
            while (string.IsNullOrEmpty(name))
            {
                name = Microsoft.VisualBasic.Interaction.InputBox("Enter your name:", "Quiz Results", "");
            }

            return name;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new main().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Quiz().Show();
        }
    }
}

