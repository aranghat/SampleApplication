namespace SampleApplication.Models
{
    public class QuestionPaper
    {
        public int Id { get; set; }
        public List<Question> Questions { get; set;}
        public int MaxMarks { get; set; }
        public string FilePath { get; set; }
    }

    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int QuestionNumber { get; set; }
        public int MaxMarks { get; set; }

       
    }
}
