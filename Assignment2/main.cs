using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace WindowsFormsApplication1
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            // Check if the leaderboard file exists
            string filePath = @"leaderboard.xml";
            if (File.Exists(filePath))
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(LeaderboardEntry[]));
                    using (FileStream fs = new FileStream(filePath, FileMode.Open))
                    {
                        LeaderboardEntry[] entries = (LeaderboardEntry[])serializer.Deserialize(fs);

                        // Sort the leaderboard data by score in descending order
                        List<LeaderboardEntry> entryList = entries.ToList();
                        entryList.Sort((a, b) => b.Score.CompareTo(a.Score));

                        // Display the top scores in the DataGridView
                        dataGridView1.AutoGenerateColumns = false;
                        dataGridView1.DataSource = entryList.Take(10);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading leaderboard: " + ex.Message);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Quiz().Show();
        }

        
    }
}
