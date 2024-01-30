
namespace Quiz_Millionaire
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.StartQuizBtn = new Guna.UI2.WinForms.Guna2Button();
            this.playerNameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.playerNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // StartQuizBtn
            // 
            this.StartQuizBtn.BorderRadius = 10;
            this.StartQuizBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.StartQuizBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.StartQuizBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StartQuizBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.StartQuizBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(2)))), ((int)(((byte)(182)))));
            this.StartQuizBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StartQuizBtn.ForeColor = System.Drawing.Color.White;
            this.StartQuizBtn.Location = new System.Drawing.Point(434, 238);
            this.StartQuizBtn.Name = "StartQuizBtn";
            this.StartQuizBtn.Size = new System.Drawing.Size(196, 61);
            this.StartQuizBtn.TabIndex = 2;
            this.StartQuizBtn.Text = "Start quiz";
            this.StartQuizBtn.Click += new System.EventHandler(this.StartQuizBtn_Click);
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.AnimateReadOnly = true;
            this.playerNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playerNameTextBox.Depth = 0;
            this.playerNameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.playerNameTextBox.LeadingIcon = null;
            this.playerNameTextBox.Location = new System.Drawing.Point(434, 108);
            this.playerNameTextBox.MaxLength = 50;
            this.playerNameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.playerNameTextBox.Multiline = false;
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(196, 50);
            this.playerNameTextBox.TabIndex = 3;
            this.playerNameTextBox.Text = "";
            this.playerNameTextBox.TrailingIcon = null;
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Depth = 0;
            this.playerNameLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.playerNameLabel.Location = new System.Drawing.Point(267, 139);
            this.playerNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(91, 19);
            this.playerNameLabel.TabIndex = 5;
            this.playerNameLabel.Text = "Player Name";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 393);
            this.Controls.Add(this.playerNameLabel);
            this.Controls.Add(this.playerNameTextBox);
            this.Controls.Add(this.StartQuizBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartForm";
            this.Text = "Become a Millionaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button StartQuizBtn;
        private MaterialSkin.Controls.MaterialTextBox playerNameTextBox;
        private MaterialSkin.Controls.MaterialLabel playerNameLabel;
    }
}
