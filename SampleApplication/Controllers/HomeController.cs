using Microsoft.AspNetCore.Mvc;
using SampleApplication.Models;

namespace SampleApplication.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Question> questionsList = new List<Question>
        {
            new Question { Id = 1, Title = "What is the capital of France?", QuestionNumber = 1, MaxMarks = 2 },
            new Question { Id = 2, Title = "How many legs does an octopus have?", QuestionNumber = 2, MaxMarks = 2 },
            new Question { Id = 3, Title = "What is the largest mammal?", QuestionNumber = 3, MaxMarks = 5 },
            new Question { Id = 4, Title = "Which chemical element has the symbol K?", QuestionNumber = 4, MaxMarks = 5 },
            new Question { Id = 5, Title = "What is the square root of 64?", QuestionNumber = 5, MaxMarks = 2 },
            new Question { Id = 6, Title = "What is the approximate speed of light in a vacuum (in km/s)?", QuestionNumber = 6, MaxMarks = 10 },
            new Question { Id = 7, Title = "What is the smallest prime number?", QuestionNumber = 7, MaxMarks = 2 },
            new Question { Id = 8, Title = "Which scientist formulated the theory of general relativity?", QuestionNumber = 8, MaxMarks = 5 },
            new Question { Id = 9, Title = "What is the chemical formula of water?", QuestionNumber = 9, MaxMarks = 2 },
            new Question { Id = 10, Title = "What is the longest river in the world?", QuestionNumber = 10, MaxMarks = 5 }
        };

            QuestionPaper questionPaper = new QuestionPaper
            {
                Id = 1,
                Questions = questionsList,
                MaxMarks = 40,
                FilePath = "/pdfs/sample.pdf"
            };

            return View(questionPaper);
        }
    }
}
