using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Quiz_Millionaire
{
    public partial class QuestionForm : Form
    {
        private readonly DatabaseManager dbManager;
        private int selectedQuestionId;

        public QuestionForm()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
        }

        private void QuestionForm_Load(object sender, EventArgs e)
        {
            List<Question> questions = dbManager.GetAll<Question>("question");
            QuestionsDataGridView.DataSource = questions;
        }

        private void CreateQuestionBtn_Click(object sender, EventArgs e)
        {
            List<MaterialTextBox2> textBoxes = new List<MaterialTextBox2> { textTextBox, difficultyTextBox, areaTextBox };

            if (AreFieldsEmpty(textBoxes))
            {
                MessageBox.Show("You must fill all inputs!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string difficultyInput = difficultyTextBox.Text;

                if (!ContainsOnlyDigits(difficultyInput))
                {
                    MessageBox.Show("Difficulty must contain only digits!", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!IsDifficultyInRange(difficultyInput))
                {
                    MessageBox.Show("Difficulty must be a number between 1 and 4!", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!IsAreaValid(areaTextBox.Text))
                {
                    return;
                }

                Question newQuestion = new Question
                {
                    Text = textTextBox.Text,
                    Difficulty = int.Parse(difficultyInput),
                    Area = areaTextBox.Text
                };

                dbManager.Create(newQuestion, "question");

                MessageBox.Show("Question is created!", "Question created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetFields(textBoxes);

                RefreshDataGridView(QuestionsDataGridView);
            }
        }

        private void QuestionsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = QuestionsDataGridView.Rows[e.RowIndex];
                int questionId = (int)selectedRow.Cells["Id"].Value;

                updateTextTextBox.Text = selectedRow.Cells["Text"].Value.ToString();
                updateDifficultyTextBox.Text = selectedRow.Cells["Difficulty"].Value.ToString();
                updateAreaTextBox.Text = selectedRow.Cells["Area"].Value.ToString();

                selectedQuestionId = questionId;
            }
        }

        private void UpdateQuestionButton_Click(object sender, EventArgs e)
        {
            List<MaterialTextBox2> textBoxes = new List<MaterialTextBox2> { updateTextTextBox, updateDifficultyTextBox, updateAreaTextBox };

            if (selectedQuestionId == 0)
            {
                MessageBox.Show("Select question to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (AreFieldsEmpty(textBoxes))
            {
                MessageBox.Show("You must fill all inputs!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string difficultyInput = updateDifficultyTextBox.Text;

                if (!ContainsOnlyDigits(difficultyInput))
                {
                    MessageBox.Show("Difficulty must contain only digits!", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!IsDifficultyInRange(difficultyInput))
                {
                    MessageBox.Show("Difficulty must be a number between 1 and 4!", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!IsAreaValid(updateAreaTextBox.Text))
                {
                    return;
                }

                Question updatedQuestion = new Question
                {
                    Id = selectedQuestionId,
                    Text = updateTextTextBox.Text,
                    Difficulty = int.Parse(difficultyInput),
                    Area = updateAreaTextBox.Text
                };

                dbManager.Update(updatedQuestion, "question", "Id", updatedQuestion.Id);

                MessageBox.Show("Question is updated!", "Question updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetFields(textBoxes);
                selectedQuestionId = 0;

                RefreshDataGridView(QuestionsDataGridView);
            }
        }

        private void DeleteQuestionButton_Click(object sender, EventArgs e)
        {
            if (selectedQuestionId == 0)
            {
                MessageBox.Show("Select question to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dbManager.Delete<Question>("question", "Id", selectedQuestionId);

            MessageBox.Show("Question is deleted!", "Question deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            updateTextTextBox.Text = "";
            updateDifficultyTextBox.Text = "";
            updateAreaTextBox.Text = "";
            selectedQuestionId = 0;

            RefreshDataGridView(QuestionsDataGridView);
        }

        private bool AreFieldsEmpty(List<MaterialTextBox2> textBoxes)
        {
            return textBoxes.Any(textBox => string.IsNullOrEmpty(textBox.Text));
        }

        private bool ContainsOnlyDigits(string str)
        {
            foreach (char ch in str)
            {
                if (!char.IsDigit(ch))
                {
                    return false;
                }
            }

            return true;
        }

        private bool IsDifficultyInRange(string difficulty)
        {
            if (int.TryParse(difficulty, out int difficultyValue))
            {
                return difficultyValue >= 1 && difficultyValue <= 4;
            }

            return false;
        }

        private bool IsAreaValid(string area)
        {
            List<string> validAreas = new List<string> { "Movies", "Sports", "Cars", "Health", "Geography" };

            if (validAreas.Contains(area))
            {
                return true;
            }
            else
            {
                string validAreasMessage = string.Join(", ", validAreas);
                MessageBox.Show($"Area isn't valid! Valid areas are: {validAreasMessage}.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void ResetFields(List<MaterialTextBox2> textBoxes)
        {
            textBoxes.ForEach(textBox => textBox.Text = "");
        }

        private void RefreshDataGridView(DataGridView dataGridView)
        {
            List<Question> questions = dbManager.GetAll<Question>("question");
            dataGridView.DataSource = null;
            dataGridView.DataSource = questions;
        }
    }
}
