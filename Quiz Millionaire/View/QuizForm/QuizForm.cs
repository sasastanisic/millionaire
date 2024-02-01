using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Quiz_Millionaire
{
    public partial class QuizForm : Form
    {
        private readonly string PlayerName;
        private readonly QuizController quizController;
        private Question currentQuestion;
        private int currentQuestionNumber;
        private List<Answer> currentAnswers;
        private int correctAnswersCount = 0;
        private readonly List<RadioButton> radioButtons;
        private readonly static int NUMBER_OF_QUESTIONS = 12;
        private readonly Dictionary<int, int> prizeMoneyValues;
        private int prizeMoney = 0;
        private int guaranteedPrizeMoney = 0;

        public QuizForm(string playerName)
        {
            InitializeComponent();
            PlayerName = playerName;
            quizController = new QuizController();
            currentQuestionNumber = 1;
            radioButtons = new List<RadioButton> { answerOne, answerTwo, answerThree, answerFour };
            questionNumberLabel.Text = $"Q {currentQuestionNumber} / {NUMBER_OF_QUESTIONS}";
            playerLabel.Text = $"{PlayerName}";
            prizeMoneyLabel.Text = "Prize: $0 ($0)";
            prizeMoneyValues = new Dictionary<int, int>
            {
                { 1, 500 },
                { 2, 1000 },
                { 3, 2000 },
                { 4, 5000 },
                { 5, 10000 },
                { 6, 20000 },
                { 7, 50000 },
                { 8, 75000 },
                { 9, 150000 },
                { 10, 250000 },
                { 11, 500000 },
                { 12, 1000000 }
            };
        }

        private void QuizForm_Load(object sender, EventArgs e)
        {
            LoadNextQuestion();
        }

        private void LoadNextQuestion()
        {
            currentQuestion = quizController.GetRandomQuestion(currentQuestionNumber);
            currentAnswers = quizController.GetAnswersForQuestion(currentQuestion.Id);

            questionLabel.Text = currentQuestion.Text;

            for (int i = 0; i < currentAnswers.Count; i++)
            {
                radioButtons[i].Text = currentAnswers[i].Text;
                radioButtons[i].Tag = currentAnswers[i].CorrectAnswer;
            }
        }

        private void FiftyFiftyButton_Click(object sender, EventArgs e)
        {
            List<Answer> remainingAnswers = currentAnswers.ToList();

            int correctAnswerIndex = remainingAnswers.FindIndex(answer => answer.CorrectAnswer);
            int firstIndexToHide;
            int secondIndexToHide;

            do
            {
                firstIndexToHide = new Random().Next(remainingAnswers.Count);
            } while (firstIndexToHide == correctAnswerIndex);

            radioButtons[firstIndexToHide].Visible = false;

            do
            {
                secondIndexToHide = new Random().Next(remainingAnswers.Count);
            } while (secondIndexToHide == correctAnswerIndex || !radioButtons[secondIndexToHide].Visible);

            radioButtons[secondIndexToHide].Visible = false;

            FiftyFiftyButton.Enabled = false;
        }

        private void FriendHelpButton_Click(object sender, EventArgs e)
        {
            double probabilityOfCorrectAnswer = 0.7;
            Random random = new Random();

            int randomRadioButtonIndex = random.Next(radioButtons.Count);

            if (random.NextDouble() > probabilityOfCorrectAnswer)
            {
                radioButtons[randomRadioButtonIndex].Checked = true;
            }
            else
            {
                radioButtons.ForEach(radioButton => radioButton.Checked = false);
                int correctAnswerIndex = currentAnswers.FindIndex(answer => answer.CorrectAnswer);

                if (correctAnswerIndex >= 0 && correctAnswerIndex < radioButtons.Count)
                {
                    radioButtons[correctAnswerIndex].Checked = true;
                }
            }

            FriendHelpButton.Enabled = false;
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
                    {
                        if (prizeMoneyValues.TryGetValue(currentQuestionNumber, out int currentQuestionValue))
                        {
                            prizeMoney = currentQuestionValue;
                            CheckGuaranteedPrizeMoney();
                            prizeMoneyLabel.Text = $"Prize: ${prizeMoney} (${guaranteedPrizeMoney})";
                        }

                        correctAnswersCount++;
                        currentQuestionNumber++;

                        UpdateProgressBar();
                        UpdateQuestionNumberLabel();

                        if (currentQuestionNumber <= NUMBER_OF_QUESTIONS)
                        {
                            LoadNextQuestion();
                        }
                        else
                        {
                            questionNumberLabel.Text = "";
                            prizeMoneyLabel.Text = "";
                            SubmitButton.Enabled = false;
                            FinishQuizButton.Enabled = false;
                            MessageBox.Show("You've become a millionaire!", "CONGRATULATIONS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            quizController.SaveQuizResults(PlayerName, correctAnswersCount, prizeMoney);
                            BackToStart();
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Answer isn't correct! You earned ${guaranteedPrizeMoney}!", "Incorrect answer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        quizController.SaveQuizResults(PlayerName, correctAnswersCount, guaranteedPrizeMoney);
                        BackToStart();
                    }

                    radioButton.Checked = false;
                    radioButtons.ForEach(rb => rb.Visible = true);

                    break;
                }
            }

            if (!answered)
            {
                MessageBox.Show("You must answer the question!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CheckGuaranteedPrizeMoney()
        {
            switch (currentQuestionNumber)
            {
                case 4:
                    guaranteedPrizeMoney = 5000;
                    break;
                case 7:
                    guaranteedPrizeMoney = 50000;
                    break;
                case 10:
                    guaranteedPrizeMoney = 250000;
                    break;
            }
        }

        private void UpdateProgressBar()
        {
            progressBar.Value = (correctAnswersCount * 100) / NUMBER_OF_QUESTIONS;
        }

        private void UpdateQuestionNumberLabel()
        {
            questionNumberLabel.Text = $"Q {currentQuestionNumber} / {NUMBER_OF_QUESTIONS}";
        }

        private void FinishQuizButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"You earned ${prizeMoney}!", "Quiz finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
            quizController.SaveQuizResults(PlayerName, correctAnswersCount, prizeMoney);
            BackToStart();
        }

        private void BackToStart()
        {
            StartForm startForm = new StartForm();
            Hide();
            startForm.ShowDialog();
            Close();
        }
    }
}
