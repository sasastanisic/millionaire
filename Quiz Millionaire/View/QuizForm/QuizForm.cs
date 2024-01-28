using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Quiz_Millionaire
{
    public partial class QuizForm : Form
    {
        private readonly QuizController quizController;
        private Question currentQuestion;
        private List<Answer> currentAnswers;
        private readonly List<RadioButton> radioButtons;

        public QuizForm()
        {
            InitializeComponent();
            quizController = new QuizController();
            radioButtons = new List<RadioButton> { answerOne, answerTwo, answerThree, answerFour };
        }

        private void QuizForm_Load(object sender, EventArgs e)
        {
            LoadNextQuestion();
        }

        private void LoadNextQuestion()
        {
            currentQuestion = quizController.GetRandomQuestion();
            currentAnswers = quizController.GetAnswersForQuestion(currentQuestion.Id);

            questionLabel.Text = currentQuestion.Text;

            for (int i = 0; i < currentAnswers.Count; i++)
            {
                radioButtons[i].Text = currentAnswers[i].Text;
                radioButtons[i].Tag = currentAnswers[i].CorrectAnswer;
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            bool answered = false;

            foreach (RadioButton radioButton in radioButtons)
            {
                if (radioButton.Checked)
                {
                    answered = true;

                    if ((bool)radioButton.Tag)
                    { }
                    else
                    {
                        MessageBox.Show("Answer isn't correct! You lost!");

                        StartForm startForm = new StartForm();
                        Hide();
                        startForm.ShowDialog();
                        Close();
                    }

                    LoadNextQuestion();
                    radioButton.Checked = false;

                    break;
                }
            }

            if (!answered)
            {
                MessageBox.Show("You must answer the question!");
            }
        }
    }
}
