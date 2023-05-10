namespace WindowsFormsApplication1
{
    partial class Quiz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.QuestionBox = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Answer3 = new System.Windows.Forms.Button();
            this.Answer4 = new System.Windows.Forms.Button();
            this.Answer2 = new System.Windows.Forms.Button();
            this.Answer1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.QuestionBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Question";
            // 
            // QuestionBox
            // 
            this.QuestionBox.AllowDrop = true;
            this.QuestionBox.AutoSize = true;
            this.QuestionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionBox.Location = new System.Drawing.Point(113, 16);
            this.QuestionBox.Name = "QuestionBox";
            this.QuestionBox.Size = new System.Drawing.Size(66, 24);
            this.QuestionBox.TabIndex = 0;
            this.QuestionBox.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Answer3);
            this.groupBox2.Controls.Add(this.Answer4);
            this.groupBox2.Controls.Add(this.Answer2);
            this.groupBox2.Controls.Add(this.Answer1);
            this.groupBox2.Location = new System.Drawing.Point(12, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 137);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Possible Answers";
            // 
            // Answer3
            // 
            this.Answer3.Location = new System.Drawing.Point(6, 78);
            this.Answer3.Name = "Answer3";
            this.Answer3.Size = new System.Drawing.Size(173, 53);
            this.Answer3.TabIndex = 3;
            this.Answer3.Text = "button6";
            this.Answer3.UseVisualStyleBackColor = true;
            this.Answer3.Click += new System.EventHandler(this.Answer3_Click);
            // 
            // Answer4
            // 
            this.Answer4.Location = new System.Drawing.Point(237, 78);
            this.Answer4.Name = "Answer4";
            this.Answer4.Size = new System.Drawing.Size(173, 53);
            this.Answer4.TabIndex = 2;
            this.Answer4.Text = "button5";
            this.Answer4.UseVisualStyleBackColor = true;
            this.Answer4.Click += new System.EventHandler(this.Answer4_Click);
            // 
            // Answer2
            // 
            this.Answer2.Location = new System.Drawing.Point(237, 19);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(173, 53);
            this.Answer2.TabIndex = 1;
            this.Answer2.Text = "button4";
            this.Answer2.UseVisualStyleBackColor = true;
            this.Answer2.Click += new System.EventHandler(this.Answer2_Click);
            // 
            // Answer1
            // 
            this.Answer1.Location = new System.Drawing.Point(6, 19);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(173, 53);
            this.Answer1.TabIndex = 0;
            this.Answer1.Text = "button3";
            this.Answer1.UseVisualStyleBackColor = true;
            this.Answer1.Click += new System.EventHandler(this.Answer1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(338, 162);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(90, 26);
            this.button7.TabIndex = 4;
            this.button7.Text = "Phone A Friend";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(440, 367);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Quiz";
            this.Text = "Quiz";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Answer3;
        private System.Windows.Forms.Button Answer4;
        private System.Windows.Forms.Button Answer2;
        private System.Windows.Forms.Button Answer1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label QuestionBox;
    }
}