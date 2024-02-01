using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Quiz_Millionaire
{
    public partial class AnswerForm : Form
    {
        private readonly DatabaseManager dbManager;
        private int selectedAnswerId;

        public AnswerForm()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
        }

        private void AnswerForm_Load(object sender, EventArgs e)
        {
            List<Answer> answers = dbManager.GetAll<Answer>("answer");
            AnswersDataGridView.DataSource = answers;
            LoadQuestionsIntoComboBox(questionsComboBox);
            LoadQuestionsIntoComboBox(updateQuestionsComboBox);
        }

        private void CreateAnswerButton_Click(object sender, EventArgs e)
        {
            if (textTextBox.Text == "" || questionsComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("You must fill all inputs!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Answer newAnswer = new Answer
                {
                    Text = textTextBox.Text,
                    CorrectAnswer = correctAnswerRadioButton.Checked,
                    QuestionId = (int)questionsComboBox.SelectedValue
                };

                dbManager.Create(newAnswer, "answer");

                MessageBox.Show("Answer is created!", "Answer created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textTextBox.Text = "";
                correctAnswerRadioButton.Checked = false;
                questionsComboBox.SelectedIndex = -1;

                RefreshDataGridView(AnswersDataGridView);
            }
        }

        private void AnswersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = AnswersDataGridView.Rows[e.RowIndex];
                int answerId = (int)selectedRow.Cells["Id"].Value;

                updateTextTextBox.Text = selectedRow.Cells["Text"].Value.ToString();
                updateCorrectAnswerRadioButton.Checked = Convert.ToBoolean(selectedRow.Cells["CorrectAnswer"].Value);
                updateQuestionsComboBox.SelectedValue = (int)selectedRow.Cells["QuestionId"].Value;

                selectedAnswerId = answerId;
            }
        }

        private void UpdateAnswerButton_Click(object sender, EventArgs e)
        {
            if (selectedAnswerId == 0)
            {
                MessageBox.Show("Select answer to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (updateTextTextBox.Text == "" || updateQuestionsComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("You must fill all inputs!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Answer updatedAnswer = new Answer
                {
                    Id = selectedAnswerId,
                    Text = updateTextTextBox.Text,
                    CorrectAnswer = updateCorrectAnswerRadioButton.Checked,
                    QuestionId = (int)updateQuestionsComboBox.SelectedValue
                };

                dbManager.Update(updatedAnswer, "answer", "Id", updatedAnswer.Id);

                MessageBox.Show("Answer is updated!", "Answer updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                updateTextTextBox.Text = "";
                updateCorrectAnswerRadioButton.Checked = false;
                updateQuestionsComboBox.SelectedIndex = -1;
                selectedAnswerId = 0;

                RefreshDataGridView(AnswersDataGridView);
            }
        }

        private void DeleteAnswerButton_Click(object sender, EventArgs e)
        {
            if (selectedAnswerId == 0)
            {
                MessageBox.Show("Select answer to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dbManager.Delete<Answer>("answer", "Id", selectedAnswerId);

            MessageBox.Show("Answer is deleted!", "Answer deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            selectedAnswerId = 0;

            RefreshDataGridView(AnswersDataGridView);
        }

        private void LoadQuestionsIntoComboBox(MaterialComboBox comboBox)
        {
            List<Question> questions = dbManager.GetAll<Question>("question");

            comboBox.DataSource = questions;
            comboBox.DisplayMember = "Text";
            comboBox.ValueMember = "Id";
            comboBox.SelectedIndex = -1;
        }

        private void RefreshDataGridView(DataGridView dataGridView)
        {
            List<Answer> answers = dbManager.GetAll<Answer>("answer");
            dataGridView.DataSource = null;
            dataGridView.DataSource = answers;
        }
    }
}
