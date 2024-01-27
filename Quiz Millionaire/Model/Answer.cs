namespace Quiz_Millionaire
{
    class Answer
    {

        public int Id { get; set; }
        public string Text { get; set; }
        public bool CorrectAnswer { get; set; }
        public int QuestionId { get; set; }

    }
}
