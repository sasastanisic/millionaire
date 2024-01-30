using System;
using System.Windows.Forms;

namespace Quiz_Millionaire
{
    public partial class StartForm : Form
    {
        public string PlayerName { get; private set; }

        public StartForm()
        {
            InitializeComponent();
        }

        private void StartQuizBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(playerNameTextBox.Text))
            {
                PlayerName = playerNameTextBox.Text;

                QuizForm quizForm = new QuizForm(PlayerName);
                Hide();
                quizForm.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Please enter your name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
