
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
            this.startQuizBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // startQuizBtn
            // 
            this.startQuizBtn.BorderRadius = 10;
            this.startQuizBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.startQuizBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.startQuizBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.startQuizBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.startQuizBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(2)))), ((int)(((byte)(182)))));
            this.startQuizBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startQuizBtn.ForeColor = System.Drawing.Color.White;
            this.startQuizBtn.Location = new System.Drawing.Point(563, 168);
            this.startQuizBtn.Name = "startQuizBtn";
            this.startQuizBtn.Size = new System.Drawing.Size(196, 61);
            this.startQuizBtn.TabIndex = 2;
            this.startQuizBtn.Text = "Start quiz";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 670);
            this.Controls.Add(this.startQuizBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartForm";
            this.Text = "Become a Millionaire";
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button startQuizBtn;
    }
}
