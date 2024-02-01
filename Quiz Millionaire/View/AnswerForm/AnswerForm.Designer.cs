
namespace Quiz_Millionaire
{
    partial class AnswerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnswerForm));
            this.DeleteAnswerButton = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateAnswerButton = new Guna.UI2.WinForms.Guna2Button();
            this.updateQuestionIDLabel = new System.Windows.Forms.Label();
            this.updateCorrectAnswerLabel = new System.Windows.Forms.Label();
            this.updateAnswerLabel = new System.Windows.Forms.Label();
            this.updateTextLabel = new System.Windows.Forms.Label();
            this.updateTextTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.CreateAnswerButton = new Guna.UI2.WinForms.Guna2Button();
            this.questionIDLabel = new System.Windows.Forms.Label();
            this.correctAnswerLabel = new System.Windows.Forms.Label();
            this.createAnswerLabel = new System.Windows.Forms.Label();
            this.textLabel = new System.Windows.Forms.Label();
            this.textTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.AnswersDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.correctAnswerRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.questionsComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.updateCorrectAnswerRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.updateQuestionsComboBox = new MaterialSkin.Controls.MaterialComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.AnswersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteAnswerButton
            // 
            this.DeleteAnswerButton.BorderRadius = 10;
            this.DeleteAnswerButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteAnswerButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteAnswerButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteAnswerButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteAnswerButton.FillColor = System.Drawing.Color.IndianRed;
            this.DeleteAnswerButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteAnswerButton.ForeColor = System.Drawing.Color.White;
            this.DeleteAnswerButton.Location = new System.Drawing.Point(1297, 539);
            this.DeleteAnswerButton.Name = "DeleteAnswerButton";
            this.DeleteAnswerButton.Size = new System.Drawing.Size(156, 61);
            this.DeleteAnswerButton.TabIndex = 41;
            this.DeleteAnswerButton.Text = "Delete";
            this.DeleteAnswerButton.Click += new System.EventHandler(this.DeleteAnswerButton_Click);
            // 
            // UpdateAnswerButton
            // 
            this.UpdateAnswerButton.BorderRadius = 10;
            this.UpdateAnswerButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateAnswerButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateAnswerButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateAnswerButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateAnswerButton.FillColor = System.Drawing.Color.Goldenrod;
            this.UpdateAnswerButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpdateAnswerButton.ForeColor = System.Drawing.Color.White;
            this.UpdateAnswerButton.Location = new System.Drawing.Point(1297, 352);
            this.UpdateAnswerButton.Name = "UpdateAnswerButton";
            this.UpdateAnswerButton.Size = new System.Drawing.Size(156, 61);
            this.UpdateAnswerButton.TabIndex = 40;
            this.UpdateAnswerButton.Text = "Update";
            this.UpdateAnswerButton.Click += new System.EventHandler(this.UpdateAnswerButton_Click);
            // 
            // updateQuestionIDLabel
            // 
            this.updateQuestionIDLabel.AutoSize = true;
            this.updateQuestionIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.updateQuestionIDLabel.Location = new System.Drawing.Point(1003, 267);
            this.updateQuestionIDLabel.Name = "updateQuestionIDLabel";
            this.updateQuestionIDLabel.Size = new System.Drawing.Size(200, 31);
            this.updateQuestionIDLabel.TabIndex = 38;
            this.updateQuestionIDLabel.Text = "Choose question";
            // 
            // updateCorrectAnswerLabel
            // 
            this.updateCorrectAnswerLabel.AutoSize = true;
            this.updateCorrectAnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.updateCorrectAnswerLabel.Location = new System.Drawing.Point(1003, 190);
            this.updateCorrectAnswerLabel.Name = "updateCorrectAnswerLabel";
            this.updateCorrectAnswerLabel.Size = new System.Drawing.Size(213, 31);
            this.updateCorrectAnswerLabel.TabIndex = 36;
            this.updateCorrectAnswerLabel.Text = "Is answer correct?";
            // 
            // updateAnswerLabel
            // 
            this.updateAnswerLabel.AutoSize = true;
            this.updateAnswerLabel.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.updateAnswerLabel.Location = new System.Drawing.Point(1292, 34);
            this.updateAnswerLabel.Name = "updateAnswerLabel";
            this.updateAnswerLabel.Size = new System.Drawing.Size(170, 30);
            this.updateAnswerLabel.TabIndex = 35;
            this.updateAnswerLabel.Text = "Update answer";
            // 
            // updateTextLabel
            // 
            this.updateTextLabel.AutoSize = true;
            this.updateTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.updateTextLabel.Location = new System.Drawing.Point(1003, 116);
            this.updateTextLabel.Name = "updateTextLabel";
            this.updateTextLabel.Size = new System.Drawing.Size(94, 25);
            this.updateTextLabel.TabIndex = 34;
            this.updateTextLabel.Text = "Enter text";
            // 
            // updateTextTextBox
            // 
            this.updateTextTextBox.AnimateReadOnly = false;
            this.updateTextTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.updateTextTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.updateTextTextBox.Depth = 0;
            this.updateTextTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.updateTextTextBox.HideSelection = true;
            this.updateTextTextBox.LeadingIcon = null;
            this.updateTextTextBox.Location = new System.Drawing.Point(1297, 99);
            this.updateTextTextBox.MaxLength = 32767;
            this.updateTextTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.updateTextTextBox.Name = "updateTextTextBox";
            this.updateTextTextBox.PasswordChar = '\0';
            this.updateTextTextBox.PrefixSuffixText = null;
            this.updateTextTextBox.ReadOnly = false;
            this.updateTextTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.updateTextTextBox.SelectedText = "";
            this.updateTextTextBox.SelectionLength = 0;
            this.updateTextTextBox.SelectionStart = 0;
            this.updateTextTextBox.ShortcutsEnabled = true;
            this.updateTextTextBox.Size = new System.Drawing.Size(601, 48);
            this.updateTextTextBox.TabIndex = 33;
            this.updateTextTextBox.TabStop = false;
            this.updateTextTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.updateTextTextBox.TrailingIcon = null;
            this.updateTextTextBox.UseSystemPasswordChar = false;
            // 
            // CreateAnswerButton
            // 
            this.CreateAnswerButton.BorderRadius = 10;
            this.CreateAnswerButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CreateAnswerButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CreateAnswerButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CreateAnswerButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CreateAnswerButton.FillColor = System.Drawing.Color.RoyalBlue;
            this.CreateAnswerButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateAnswerButton.ForeColor = System.Drawing.Color.White;
            this.CreateAnswerButton.Location = new System.Drawing.Point(301, 654);
            this.CreateAnswerButton.Name = "CreateAnswerButton";
            this.CreateAnswerButton.Size = new System.Drawing.Size(156, 61);
            this.CreateAnswerButton.TabIndex = 32;
            this.CreateAnswerButton.Text = "Create";
            this.CreateAnswerButton.Click += new System.EventHandler(this.CreateAnswerButton_Click);
            // 
            // questionIDLabel
            // 
            this.questionIDLabel.AutoSize = true;
            this.questionIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.questionIDLabel.Location = new System.Drawing.Point(7, 569);
            this.questionIDLabel.Name = "questionIDLabel";
            this.questionIDLabel.Size = new System.Drawing.Size(160, 25);
            this.questionIDLabel.TabIndex = 30;
            this.questionIDLabel.Text = "Choose question";
            // 
            // correctAnswerLabel
            // 
            this.correctAnswerLabel.AutoSize = true;
            this.correctAnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.correctAnswerLabel.Location = new System.Drawing.Point(7, 492);
            this.correctAnswerLabel.Name = "correctAnswerLabel";
            this.correctAnswerLabel.Size = new System.Drawing.Size(170, 25);
            this.correctAnswerLabel.TabIndex = 28;
            this.correctAnswerLabel.Text = "Is answer correct?";
            // 
            // createAnswerLabel
            // 
            this.createAnswerLabel.AutoSize = true;
            this.createAnswerLabel.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createAnswerLabel.Location = new System.Drawing.Point(295, 337);
            this.createAnswerLabel.Name = "createAnswerLabel";
            this.createAnswerLabel.Size = new System.Drawing.Size(210, 30);
            this.createAnswerLabel.TabIndex = 27;
            this.createAnswerLabel.Text = "Create new answer";
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textLabel.Location = new System.Drawing.Point(7, 418);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(94, 25);
            this.textLabel.TabIndex = 26;
            this.textLabel.Text = "Enter text";
            // 
            // textTextBox
            // 
            this.textTextBox.AnimateReadOnly = false;
            this.textTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textTextBox.Depth = 0;
            this.textTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textTextBox.HideSelection = true;
            this.textTextBox.LeadingIcon = null;
            this.textTextBox.Location = new System.Drawing.Point(301, 401);
            this.textTextBox.MaxLength = 32767;
            this.textTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.textTextBox.Name = "textTextBox";
            this.textTextBox.PasswordChar = '\0';
            this.textTextBox.PrefixSuffixText = null;
            this.textTextBox.ReadOnly = false;
            this.textTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textTextBox.SelectedText = "";
            this.textTextBox.SelectionLength = 0;
            this.textTextBox.SelectionStart = 0;
            this.textTextBox.ShortcutsEnabled = true;
            this.textTextBox.Size = new System.Drawing.Size(601, 48);
            this.textTextBox.TabIndex = 25;
            this.textTextBox.TabStop = false;
            this.textTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textTextBox.TrailingIcon = null;
            this.textTextBox.UseSystemPasswordChar = false;
            // 
            // AnswersDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.AnswersDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AnswersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AnswersDataGridView.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AnswersDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.AnswersDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AnswersDataGridView.Location = new System.Drawing.Point(12, 12);
            this.AnswersDataGridView.Name = "AnswersDataGridView";
            this.AnswersDataGridView.RowHeadersVisible = false;
            this.AnswersDataGridView.RowHeadersWidth = 51;
            this.AnswersDataGridView.RowTemplate.Height = 24;
            this.AnswersDataGridView.Size = new System.Drawing.Size(890, 286);
            this.AnswersDataGridView.TabIndex = 24;
            this.AnswersDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.AnswersDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.AnswersDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.AnswersDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.AnswersDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.AnswersDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.AnswersDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AnswersDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AnswersDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AnswersDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AnswersDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.AnswersDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.AnswersDataGridView.ThemeStyle.HeaderStyle.Height = 4;
            this.AnswersDataGridView.ThemeStyle.ReadOnly = false;
            this.AnswersDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.AnswersDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AnswersDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AnswersDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AnswersDataGridView.ThemeStyle.RowsStyle.Height = 24;
            this.AnswersDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AnswersDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AnswersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AnswersDataGridView_CellContentClick);
            // 
            // correctAnswerRadioButton
            // 
            this.correctAnswerRadioButton.AutoSize = true;
            this.correctAnswerRadioButton.Depth = 0;
            this.correctAnswerRadioButton.Location = new System.Drawing.Point(301, 486);
            this.correctAnswerRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.correctAnswerRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.correctAnswerRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.correctAnswerRadioButton.Name = "correctAnswerRadioButton";
            this.correctAnswerRadioButton.Ripple = true;
            this.correctAnswerRadioButton.Size = new System.Drawing.Size(35, 37);
            this.correctAnswerRadioButton.TabIndex = 42;
            this.correctAnswerRadioButton.TabStop = true;
            this.correctAnswerRadioButton.UseVisualStyleBackColor = true;
            // 
            // questionsComboBox
            // 
            this.questionsComboBox.AutoResize = false;
            this.questionsComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.questionsComboBox.Depth = 0;
            this.questionsComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.questionsComboBox.DropDownHeight = 174;
            this.questionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.questionsComboBox.DropDownWidth = 121;
            this.questionsComboBox.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.questionsComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.questionsComboBox.FormattingEnabled = true;
            this.questionsComboBox.IntegralHeight = false;
            this.questionsComboBox.ItemHeight = 43;
            this.questionsComboBox.Location = new System.Drawing.Point(301, 545);
            this.questionsComboBox.MaxDropDownItems = 4;
            this.questionsComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.questionsComboBox.Name = "questionsComboBox";
            this.questionsComboBox.Size = new System.Drawing.Size(601, 49);
            this.questionsComboBox.StartIndex = 0;
            this.questionsComboBox.TabIndex = 43;
            // 
            // updateCorrectAnswerRadioButton
            // 
            this.updateCorrectAnswerRadioButton.AutoSize = true;
            this.updateCorrectAnswerRadioButton.Depth = 0;
            this.updateCorrectAnswerRadioButton.Location = new System.Drawing.Point(1297, 184);
            this.updateCorrectAnswerRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.updateCorrectAnswerRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.updateCorrectAnswerRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.updateCorrectAnswerRadioButton.Name = "updateCorrectAnswerRadioButton";
            this.updateCorrectAnswerRadioButton.Ripple = true;
            this.updateCorrectAnswerRadioButton.Size = new System.Drawing.Size(35, 37);
            this.updateCorrectAnswerRadioButton.TabIndex = 44;
            this.updateCorrectAnswerRadioButton.TabStop = true;
            this.updateCorrectAnswerRadioButton.UseVisualStyleBackColor = true;
            // 
            // updateQuestionsComboBox
            // 
            this.updateQuestionsComboBox.AutoResize = false;
            this.updateQuestionsComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.updateQuestionsComboBox.Depth = 0;
            this.updateQuestionsComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.updateQuestionsComboBox.DropDownHeight = 174;
            this.updateQuestionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.updateQuestionsComboBox.DropDownWidth = 121;
            this.updateQuestionsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.updateQuestionsComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.updateQuestionsComboBox.FormattingEnabled = true;
            this.updateQuestionsComboBox.IntegralHeight = false;
            this.updateQuestionsComboBox.ItemHeight = 43;
            this.updateQuestionsComboBox.Location = new System.Drawing.Point(1297, 249);
            this.updateQuestionsComboBox.MaxDropDownItems = 4;
            this.updateQuestionsComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.updateQuestionsComboBox.Name = "updateQuestionsComboBox";
            this.updateQuestionsComboBox.Size = new System.Drawing.Size(601, 49);
            this.updateQuestionsComboBox.StartIndex = 0;
            this.updateQuestionsComboBox.TabIndex = 45;
            // 
            // AnswerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1946, 767);
            this.Controls.Add(this.updateQuestionsComboBox);
            this.Controls.Add(this.updateCorrectAnswerRadioButton);
            this.Controls.Add(this.questionsComboBox);
            this.Controls.Add(this.correctAnswerRadioButton);
            this.Controls.Add(this.DeleteAnswerButton);
            this.Controls.Add(this.UpdateAnswerButton);
            this.Controls.Add(this.updateQuestionIDLabel);
            this.Controls.Add(this.updateCorrectAnswerLabel);
            this.Controls.Add(this.updateAnswerLabel);
            this.Controls.Add(this.updateTextLabel);
            this.Controls.Add(this.updateTextTextBox);
            this.Controls.Add(this.CreateAnswerButton);
            this.Controls.Add(this.questionIDLabel);
            this.Controls.Add(this.correctAnswerLabel);
            this.Controls.Add(this.createAnswerLabel);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.textTextBox);
            this.Controls.Add(this.AnswersDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnswerForm";
            this.Text = "Answers";
            this.Load += new System.EventHandler(this.AnswerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AnswersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button DeleteAnswerButton;
        private Guna.UI2.WinForms.Guna2Button UpdateAnswerButton;
        private System.Windows.Forms.Label updateQuestionIDLabel;
        private System.Windows.Forms.Label updateCorrectAnswerLabel;
        private System.Windows.Forms.Label updateAnswerLabel;
        private System.Windows.Forms.Label updateTextLabel;
        private MaterialSkin.Controls.MaterialTextBox2 updateTextTextBox;
        private Guna.UI2.WinForms.Guna2Button CreateAnswerButton;
        private System.Windows.Forms.Label questionIDLabel;
        private System.Windows.Forms.Label correctAnswerLabel;
        private System.Windows.Forms.Label createAnswerLabel;
        private System.Windows.Forms.Label textLabel;
        private MaterialSkin.Controls.MaterialTextBox2 textTextBox;
        private Guna.UI2.WinForms.Guna2DataGridView AnswersDataGridView;
        private MaterialSkin.Controls.MaterialRadioButton correctAnswerRadioButton;
        private MaterialSkin.Controls.MaterialComboBox questionsComboBox;
        private MaterialSkin.Controls.MaterialRadioButton updateCorrectAnswerRadioButton;
        private MaterialSkin.Controls.MaterialComboBox updateQuestionsComboBox;
    }
}