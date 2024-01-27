using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Millionaire
{
    public partial class QuizForm : Form
    {
        private readonly QuizController quizController;
        private Question currentQuestion;
        List<Answer> currentAnswers;

        public QuizForm()
        {
            InitializeComponent();
            quizController = new QuizController();
        }

        private void QuizForm_Load(object sender, EventArgs e)
        {
            LoadNextQuestion();
        }

        private void LoadNextQuestion()
        {
            // TO-DO: change radio button style using Material
            List<RadioButton> radioButtons = new List<RadioButton> { answerOne, answerTwo, answerThree, answerFour };
            currentQuestion = quizController.GetRandomQuestion();
            currentAnswers = quizController.GetAnswersForQuestion(currentQuestion.Id);

            questionLabel.Text = currentQuestion.Text;

            for (int i = 0; i < currentAnswers.Count; i++)
            {
                radioButtons[i].Text = currentAnswers[i].Text;
                radioButtons[i].Tag = currentAnswers[i].CorrectAnswer;
            }
        }
    }
}
