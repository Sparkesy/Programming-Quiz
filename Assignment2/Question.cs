namespace WindowsFormsApplication1
{
    public class Question
    {
        public string Text { get; set; }
        public string[] Choices { get; set; }
        public int CorrectChoiceIndex { get; set; }

        public Question(string text, string[] choices, int correctChoiceIndex)
        {
            Text = text;
            Choices = choices;
            CorrectChoiceIndex = correctChoiceIndex;
        }
    }

}