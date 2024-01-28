
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
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.BackColor = System.Drawing.Color.Transparent;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.questionLabel.Location = new System.Drawing.Point(164, 59);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(26, 27);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "sa";
            // 
            // answerOne
            // 
            this.answerOne.AutoSize = true;
            this.answerOne.Depth = 0;
            this.answerOne.Location = new System.Drawing.Point(45, 147);
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
            this.answerTwo.Location = new System.Drawing.Point(45, 224);
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
            this.answerThree.Location = new System.Drawing.Point(524, 147);
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
            this.answerFour.Location = new System.Drawing.Point(524, 224);
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
            this.SubmitButton.Location = new System.Drawing.Point(354, 338);
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
            this.FiftyFiftyButton.Location = new System.Drawing.Point(137, 473);
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
            this.FriendHelpButton.Location = new System.Drawing.Point(561, 473);
            this.FriendHelpButton.Name = "FriendHelpButton";
            this.FriendHelpButton.Size = new System.Drawing.Size(124, 52);
            this.FriendHelpButton.TabIndex = 11;
            this.FriendHelpButton.Text = "BF";
            this.FriendHelpButton.Click += new System.EventHandler(this.FriendHelpButton_Click);
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 565);
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
    }
}