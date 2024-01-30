
namespace Quiz_Millionaire
{
    partial class QuizForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizForm));
            this.questionLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.answerOne = new MaterialSkin.Controls.MaterialRadioButton();
            this.answerTwo = new MaterialSkin.Controls.MaterialRadioButton();
            this.answerThree = new MaterialSkin.Controls.MaterialRadioButton();
            this.answerFour = new MaterialSkin.Controls.MaterialRadioButton();
            this.SubmitButton = new Guna.UI2.WinForms.Guna2Button();
            this.FiftyFiftyButton = new Guna.UI2.WinForms.Guna2Button();
            this.FriendHelpButton = new Guna.UI2.WinForms.Guna2Button();
            this.FinishQuizButton = new Guna.UI2.WinForms.Guna2Button();
            this.progressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.questionNumberLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.prizeMoneyLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.playerLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.BackColor = System.Drawing.Color.Transparent;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.questionLabel.Location = new System.Drawing.Point(314, 92);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(90, 27);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "Question";
            // 
            // answerOne
            // 
            this.answerOne.AutoSize = true;
            this.answerOne.Depth = 0;
            this.answerOne.Location = new System.Drawing.Point(194, 179);
            this.answerOne.Margin = new System.Windows.Forms.Padding(0);
            this.answerOne.MouseLocation = new System.Drawing.Point(-1, -1);
            this.answerOne.MouseState = MaterialSkin.MouseState.HOVER;
            this.answerOne.Name = "answerOne";
            this.answerOne.Ripple = true;
            this.answerOne.Size = new System.Drawing.Size(44, 37);
            this.answerOne.TabIndex = 5;
            this.answerOne.TabStop = true;
            this.answerOne.Text = "1";
            this.answerOne.UseVisualStyleBackColor = true;
            // 
            // answerTwo
            // 
            this.answerTwo.AutoSize = true;
            this.answerTwo.Depth = 0;
            this.answerTwo.Location = new System.Drawing.Point(194, 256);
            this.answerTwo.Margin = new System.Windows.Forms.Padding(0);
            this.answerTwo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.answerTwo.MouseState = MaterialSkin.MouseState.HOVER;
            this.answerTwo.Name = "answerTwo";
            this.answerTwo.Ripple = true;
            this.answerTwo.Size = new System.Drawing.Size(44, 37);
            this.answerTwo.TabIndex = 6;
            this.answerTwo.TabStop = true;
            this.answerTwo.Text = "2";
            this.answerTwo.UseVisualStyleBackColor = true;
            // 
            // answerThree
            // 
            this.answerThree.AutoSize = true;
            this.answerThree.Depth = 0;
            this.answerThree.Location = new System.Drawing.Point(784, 179);
            this.answerThree.Margin = new System.Windows.Forms.Padding(0);
            this.answerThree.MouseLocation = new System.Drawing.Point(-1, -1);
            this.answerThree.MouseState = MaterialSkin.MouseState.HOVER;
            this.answerThree.Name = "answerThree";
            this.answerThree.Ripple = true;
            this.answerThree.Size = new System.Drawing.Size(44, 37);
            this.answerThree.TabIndex = 7;
            this.answerThree.TabStop = true;
            this.answerThree.Text = "3";
            this.answerThree.UseVisualStyleBackColor = true;
            // 
            // answerFour
            // 
            this.answerFour.AutoSize = true;
            this.answerFour.Depth = 0;
            this.answerFour.Location = new System.Drawing.Point(784, 256);
            this.answerFour.Margin = new System.Windows.Forms.Padding(0);
            this.answerFour.MouseLocation = new System.Drawing.Point(-1, -1);
            this.answerFour.MouseState = MaterialSkin.MouseState.HOVER;
            this.answerFour.Name = "answerFour";
            this.answerFour.Ripple = true;
            this.answerFour.Size = new System.Drawing.Size(44, 37);
            this.answerFour.TabIndex = 8;
            this.answerFour.TabStop = true;
            this.answerFour.Text = "4";
            this.answerFour.UseVisualStyleBackColor = true;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Animated = true;
            this.SubmitButton.AutoRoundedCorners = true;
            this.SubmitButton.BorderColor = System.Drawing.Color.Transparent;
            this.SubmitButton.BorderRadius = 31;
            this.SubmitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SubmitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SubmitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SubmitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SubmitButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SubmitButton.ForeColor = System.Drawing.Color.White;
            this.SubmitButton.Location = new System.Drawing.Point(483, 370);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(144, 65);
            this.SubmitButton.TabIndex = 9;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // FiftyFiftyButton
            // 
            this.FiftyFiftyButton.Animated = true;
            this.FiftyFiftyButton.BorderRadius = 10;
            this.FiftyFiftyButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FiftyFiftyButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FiftyFiftyButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FiftyFiftyButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FiftyFiftyButton.FillColor = System.Drawing.Color.Navy;
            this.FiftyFiftyButton.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FiftyFiftyButton.ForeColor = System.Drawing.Color.White;
            this.FiftyFiftyButton.Location = new System.Drawing.Point(280, 505);
            this.FiftyFiftyButton.Name = "FiftyFiftyButton";
            this.FiftyFiftyButton.Size = new System.Drawing.Size(124, 52);
            this.FiftyFiftyButton.TabIndex = 10;
            this.FiftyFiftyButton.Text = "50 - 50";
            this.FiftyFiftyButton.Click += new System.EventHandler(this.FiftyFiftyButton_Click);
            // 
            // FriendHelpButton
            // 
            this.FriendHelpButton.Animated = true;
            this.FriendHelpButton.BorderRadius = 10;
            this.FriendHelpButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FriendHelpButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FriendHelpButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FriendHelpButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FriendHelpButton.FillColor = System.Drawing.Color.Navy;
            this.FriendHelpButton.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FriendHelpButton.ForeColor = System.Drawing.Color.White;
            this.FriendHelpButton.Location = new System.Drawing.Point(704, 505);
            this.FriendHelpButton.Name = "FriendHelpButton";
            this.FriendHelpButton.Size = new System.Drawing.Size(124, 52);
            this.FriendHelpButton.TabIndex = 11;
            this.FriendHelpButton.Text = "BFF";
            this.FriendHelpButton.Click += new System.EventHandler(this.FriendHelpButton_Click);
            // 
            // FinishQuizButton
            // 
            this.FinishQuizButton.Animated = true;
            this.FinishQuizButton.BorderRadius = 10;
            this.FinishQuizButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FinishQuizButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FinishQuizButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FinishQuizButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FinishQuizButton.FillColor = System.Drawing.Color.Firebrick;
            this.FinishQuizButton.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FinishQuizButton.ForeColor = System.Drawing.Color.White;
            this.FinishQuizButton.Location = new System.Drawing.Point(1056, 694);
            this.FinishQuizButton.Name = "FinishQuizButton";
            this.FinishQuizButton.Size = new System.Drawing.Size(124, 52);
            this.FinishQuizButton.TabIndex = 12;
            this.FinishQuizButton.Text = "Finish";
            this.FinishQuizButton.Click += new System.EventHandler(this.FinishQuizButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(280, 624);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(548, 22);
            this.progressBar.TabIndex = 13;
            this.progressBar.Text = "guna2ProgressBar1";
            this.progressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // questionNumberLabel
            // 
            this.questionNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.questionNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.questionNumberLabel.Location = new System.Drawing.Point(112, 30);
            this.questionNumberLabel.Name = "questionNumberLabel";
            this.questionNumberLabel.Size = new System.Drawing.Size(81, 27);
            this.questionNumberLabel.TabIndex = 14;
            this.questionNumberLabel.Text = "Q 1 / 12";
            // 
            // prizeMoneyLabel
            // 
            this.prizeMoneyLabel.BackColor = System.Drawing.Color.Transparent;
            this.prizeMoneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prizeMoneyLabel.Location = new System.Drawing.Point(836, 30);
            this.prizeMoneyLabel.Name = "prizeMoneyLabel";
            this.prizeMoneyLabel.Size = new System.Drawing.Size(135, 27);
            this.prizeMoneyLabel.TabIndex = 15;
            this.prizeMoneyLabel.Text = "Prize: $0 ($0)";
            // 
            // playerLabel
            // 
            this.playerLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerLabel.Location = new System.Drawing.Point(520, 30);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(64, 27);
            this.playerLabel.TabIndex = 16;
            this.playerLabel.Text = "Player";
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 758);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.prizeMoneyLabel);
            this.Controls.Add(this.questionNumberLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.FinishQuizButton);
            this.Controls.Add(this.FriendHelpButton);
            this.Controls.Add(this.FiftyFiftyButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.answerFour);
            this.Controls.Add(this.answerThree);
            this.Controls.Add(this.answerTwo);
            this.Controls.Add(this.answerOne);
            this.Controls.Add(this.questionLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuizForm";
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.QuizForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel questionLabel;
        private MaterialSkin.Controls.MaterialRadioButton answerOne;
        private MaterialSkin.Controls.MaterialRadioButton answerTwo;
        private MaterialSkin.Controls.MaterialRadioButton answerThree;
        private MaterialSkin.Controls.MaterialRadioButton answerFour;
        private Guna.UI2.WinForms.Guna2Button SubmitButton;
        private Guna.UI2.WinForms.Guna2Button FiftyFiftyButton;
        private Guna.UI2.WinForms.Guna2Button FriendHelpButton;
        private Guna.UI2.WinForms.Guna2Button FinishQuizButton;
        private Guna.UI2.WinForms.Guna2ProgressBar progressBar;
        private Guna.UI2.WinForms.Guna2HtmlLabel questionNumberLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel prizeMoneyLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel playerLabel;
    }
}