
namespace Quiz_Millionaire
{
    partial class QuestionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionForm));
            this.QuestionsDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.textTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.textLabel = new System.Windows.Forms.Label();
            this.createQuestionLabel = new System.Windows.Forms.Label();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.difficultyTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.areaLabel = new System.Windows.Forms.Label();
            this.areaTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.CreateQuestionBtn = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateQuestionButton = new Guna.UI2.WinForms.Guna2Button();
            this.updateAreaTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.updateAreaLabel = new System.Windows.Forms.Label();
            this.updateDifficultyTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.updateDifficultyLabel = new System.Windows.Forms.Label();
            this.updateQuestionLabel = new System.Windows.Forms.Label();
            this.updateTextLabel = new System.Windows.Forms.Label();
            this.updateTextTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.DeleteQuestionButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // QuestionsDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.QuestionsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.QuestionsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.QuestionsDataGridView.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.QuestionsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.QuestionsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.QuestionsDataGridView.Location = new System.Drawing.Point(21, 25);
            this.QuestionsDataGridView.Name = "QuestionsDataGridView";
            this.QuestionsDataGridView.RowHeadersVisible = false;
            this.QuestionsDataGridView.RowHeadersWidth = 51;
            this.QuestionsDataGridView.RowTemplate.Height = 24;
            this.QuestionsDataGridView.Size = new System.Drawing.Size(890, 286);
            this.QuestionsDataGridView.TabIndex = 1;
            this.QuestionsDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.QuestionsDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.QuestionsDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.QuestionsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.QuestionsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.QuestionsDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.QuestionsDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.QuestionsDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.QuestionsDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.QuestionsDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.QuestionsDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.QuestionsDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.QuestionsDataGridView.ThemeStyle.HeaderStyle.Height = 4;
            this.QuestionsDataGridView.ThemeStyle.ReadOnly = false;
            this.QuestionsDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.QuestionsDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.QuestionsDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.QuestionsDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.QuestionsDataGridView.ThemeStyle.RowsStyle.Height = 24;
            this.QuestionsDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.QuestionsDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.QuestionsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.QuestionsDataGridView_CellContentClick);
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
            this.textTextBox.Location = new System.Drawing.Point(310, 414);
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
            this.textTextBox.TabIndex = 5;
            this.textTextBox.TabStop = false;
            this.textTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textTextBox.TrailingIcon = null;
            this.textTextBox.UseSystemPasswordChar = false;
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textLabel.Location = new System.Drawing.Point(16, 431);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(94, 25);
            this.textLabel.TabIndex = 7;
            this.textLabel.Text = "Enter text";
            // 
            // createQuestionLabel
            // 
            this.createQuestionLabel.AutoSize = true;
            this.createQuestionLabel.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createQuestionLabel.Location = new System.Drawing.Point(304, 350);
            this.createQuestionLabel.Name = "createQuestionLabel";
            this.createQuestionLabel.Size = new System.Drawing.Size(226, 30);
            this.createQuestionLabel.TabIndex = 8;
            this.createQuestionLabel.Text = "Create new question";
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.difficultyLabel.Location = new System.Drawing.Point(16, 505);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(132, 25);
            this.difficultyLabel.TabIndex = 9;
            this.difficultyLabel.Text = "Enter difficulty";
            // 
            // difficultyTextBox
            // 
            this.difficultyTextBox.AnimateReadOnly = false;
            this.difficultyTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.difficultyTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.difficultyTextBox.Depth = 0;
            this.difficultyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.difficultyTextBox.HideSelection = true;
            this.difficultyTextBox.LeadingIcon = null;
            this.difficultyTextBox.Location = new System.Drawing.Point(310, 488);
            this.difficultyTextBox.MaxLength = 32767;
            this.difficultyTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.difficultyTextBox.Name = "difficultyTextBox";
            this.difficultyTextBox.PasswordChar = '\0';
            this.difficultyTextBox.PrefixSuffixText = null;
            this.difficultyTextBox.ReadOnly = false;
            this.difficultyTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.difficultyTextBox.SelectedText = "";
            this.difficultyTextBox.SelectionLength = 0;
            this.difficultyTextBox.SelectionStart = 0;
            this.difficultyTextBox.ShortcutsEnabled = true;
            this.difficultyTextBox.Size = new System.Drawing.Size(299, 48);
            this.difficultyTextBox.TabIndex = 10;
            this.difficultyTextBox.TabStop = false;
            this.difficultyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.difficultyTextBox.TrailingIcon = null;
            this.difficultyTextBox.UseSystemPasswordChar = false;
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.areaLabel.Location = new System.Drawing.Point(16, 582);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(181, 25);
            this.areaLabel.TabIndex = 11;
            this.areaLabel.Text = "Enter question area";
            // 
            // areaTextBox
            // 
            this.areaTextBox.AnimateReadOnly = false;
            this.areaTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.areaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.areaTextBox.Depth = 0;
            this.areaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.areaTextBox.HideSelection = true;
            this.areaTextBox.LeadingIcon = null;
            this.areaTextBox.Location = new System.Drawing.Point(310, 565);
            this.areaTextBox.MaxLength = 32767;
            this.areaTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.areaTextBox.Name = "areaTextBox";
            this.areaTextBox.PasswordChar = '\0';
            this.areaTextBox.PrefixSuffixText = null;
            this.areaTextBox.ReadOnly = false;
            this.areaTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.areaTextBox.SelectedText = "";
            this.areaTextBox.SelectionLength = 0;
            this.areaTextBox.SelectionStart = 0;
            this.areaTextBox.ShortcutsEnabled = true;
            this.areaTextBox.Size = new System.Drawing.Size(299, 48);
            this.areaTextBox.TabIndex = 12;
            this.areaTextBox.TabStop = false;
            this.areaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.areaTextBox.TrailingIcon = null;
            this.areaTextBox.UseSystemPasswordChar = false;
            // 
            // CreateQuestionBtn
            // 
            this.CreateQuestionBtn.BorderRadius = 10;
            this.CreateQuestionBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CreateQuestionBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CreateQuestionBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CreateQuestionBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CreateQuestionBtn.FillColor = System.Drawing.Color.RoyalBlue;
            this.CreateQuestionBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateQuestionBtn.ForeColor = System.Drawing.Color.White;
            this.CreateQuestionBtn.Location = new System.Drawing.Point(310, 667);
            this.CreateQuestionBtn.Name = "CreateQuestionBtn";
            this.CreateQuestionBtn.Size = new System.Drawing.Size(156, 61);
            this.CreateQuestionBtn.TabIndex = 13;
            this.CreateQuestionBtn.Text = "Create";
            this.CreateQuestionBtn.Click += new System.EventHandler(this.CreateQuestionBtn_Click);
            // 
            // UpdateQuestionButton
            // 
            this.UpdateQuestionButton.BorderRadius = 10;
            this.UpdateQuestionButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateQuestionButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateQuestionButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateQuestionButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateQuestionButton.FillColor = System.Drawing.Color.Goldenrod;
            this.UpdateQuestionButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpdateQuestionButton.ForeColor = System.Drawing.Color.White;
            this.UpdateQuestionButton.Location = new System.Drawing.Point(1306, 365);
            this.UpdateQuestionButton.Name = "UpdateQuestionButton";
            this.UpdateQuestionButton.Size = new System.Drawing.Size(156, 61);
            this.UpdateQuestionButton.TabIndex = 21;
            this.UpdateQuestionButton.Text = "Update";
            this.UpdateQuestionButton.Click += new System.EventHandler(this.UpdateQuestionButton_Click);
            // 
            // updateAreaTextBox
            // 
            this.updateAreaTextBox.AnimateReadOnly = false;
            this.updateAreaTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.updateAreaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.updateAreaTextBox.Depth = 0;
            this.updateAreaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.updateAreaTextBox.HideSelection = true;
            this.updateAreaTextBox.LeadingIcon = null;
            this.updateAreaTextBox.Location = new System.Drawing.Point(1306, 263);
            this.updateAreaTextBox.MaxLength = 32767;
            this.updateAreaTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.updateAreaTextBox.Name = "updateAreaTextBox";
            this.updateAreaTextBox.PasswordChar = '\0';
            this.updateAreaTextBox.PrefixSuffixText = null;
            this.updateAreaTextBox.ReadOnly = false;
            this.updateAreaTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.updateAreaTextBox.SelectedText = "";
            this.updateAreaTextBox.SelectionLength = 0;
            this.updateAreaTextBox.SelectionStart = 0;
            this.updateAreaTextBox.ShortcutsEnabled = true;
            this.updateAreaTextBox.Size = new System.Drawing.Size(299, 48);
            this.updateAreaTextBox.TabIndex = 20;
            this.updateAreaTextBox.TabStop = false;
            this.updateAreaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.updateAreaTextBox.TrailingIcon = null;
            this.updateAreaTextBox.UseSystemPasswordChar = false;
            // 
            // updateAreaLabel
            // 
            this.updateAreaLabel.AutoSize = true;
            this.updateAreaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.updateAreaLabel.Location = new System.Drawing.Point(1012, 280);
            this.updateAreaLabel.Name = "updateAreaLabel";
            this.updateAreaLabel.Size = new System.Drawing.Size(181, 25);
            this.updateAreaLabel.TabIndex = 19;
            this.updateAreaLabel.Text = "Enter question area";
            // 
            // updateDifficultyTextBox
            // 
            this.updateDifficultyTextBox.AnimateReadOnly = false;
            this.updateDifficultyTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.updateDifficultyTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.updateDifficultyTextBox.Depth = 0;
            this.updateDifficultyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.updateDifficultyTextBox.HideSelection = true;
            this.updateDifficultyTextBox.LeadingIcon = null;
            this.updateDifficultyTextBox.Location = new System.Drawing.Point(1306, 186);
            this.updateDifficultyTextBox.MaxLength = 32767;
            this.updateDifficultyTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.updateDifficultyTextBox.Name = "updateDifficultyTextBox";
            this.updateDifficultyTextBox.PasswordChar = '\0';
            this.updateDifficultyTextBox.PrefixSuffixText = null;
            this.updateDifficultyTextBox.ReadOnly = false;
            this.updateDifficultyTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.updateDifficultyTextBox.SelectedText = "";
            this.updateDifficultyTextBox.SelectionLength = 0;
            this.updateDifficultyTextBox.SelectionStart = 0;
            this.updateDifficultyTextBox.ShortcutsEnabled = true;
            this.updateDifficultyTextBox.Size = new System.Drawing.Size(299, 48);
            this.updateDifficultyTextBox.TabIndex = 18;
            this.updateDifficultyTextBox.TabStop = false;
            this.updateDifficultyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.updateDifficultyTextBox.TrailingIcon = null;
            this.updateDifficultyTextBox.UseSystemPasswordChar = false;
            // 
            // updateDifficultyLabel
            // 
            this.updateDifficultyLabel.AutoSize = true;
            this.updateDifficultyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.updateDifficultyLabel.Location = new System.Drawing.Point(1012, 203);
            this.updateDifficultyLabel.Name = "updateDifficultyLabel";
            this.updateDifficultyLabel.Size = new System.Drawing.Size(132, 25);
            this.updateDifficultyLabel.TabIndex = 17;
            this.updateDifficultyLabel.Text = "Enter difficulty";
            // 
            // updateQuestionLabel
            // 
            this.updateQuestionLabel.AutoSize = true;
            this.updateQuestionLabel.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.updateQuestionLabel.Location = new System.Drawing.Point(1300, 48);
            this.updateQuestionLabel.Name = "updateQuestionLabel";
            this.updateQuestionLabel.Size = new System.Drawing.Size(186, 30);
            this.updateQuestionLabel.TabIndex = 16;
            this.updateQuestionLabel.Text = "Update question";
            // 
            // updateTextLabel
            // 
            this.updateTextLabel.AutoSize = true;
            this.updateTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.updateTextLabel.Location = new System.Drawing.Point(1012, 129);
            this.updateTextLabel.Name = "updateTextLabel";
            this.updateTextLabel.Size = new System.Drawing.Size(94, 25);
            this.updateTextLabel.TabIndex = 15;
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
            this.updateTextTextBox.Location = new System.Drawing.Point(1306, 112);
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
            this.updateTextTextBox.TabIndex = 14;
            this.updateTextTextBox.TabStop = false;
            this.updateTextTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.updateTextTextBox.TrailingIcon = null;
            this.updateTextTextBox.UseSystemPasswordChar = false;
            // 
            // DeleteQuestionButton
            // 
            this.DeleteQuestionButton.BorderRadius = 10;
            this.DeleteQuestionButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteQuestionButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteQuestionButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteQuestionButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteQuestionButton.FillColor = System.Drawing.Color.IndianRed;
            this.DeleteQuestionButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteQuestionButton.ForeColor = System.Drawing.Color.White;
            this.DeleteQuestionButton.Location = new System.Drawing.Point(1306, 552);
            this.DeleteQuestionButton.Name = "DeleteQuestionButton";
            this.DeleteQuestionButton.Size = new System.Drawing.Size(156, 61);
            this.DeleteQuestionButton.TabIndex = 22;
            this.DeleteQuestionButton.Text = "Delete";
            this.DeleteQuestionButton.Click += new System.EventHandler(this.DeleteQuestionButton_Click);
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1945, 766);
            this.Controls.Add(this.DeleteQuestionButton);
            this.Controls.Add(this.UpdateQuestionButton);
            this.Controls.Add(this.updateAreaTextBox);
            this.Controls.Add(this.updateAreaLabel);
            this.Controls.Add(this.updateDifficultyTextBox);
            this.Controls.Add(this.updateDifficultyLabel);
            this.Controls.Add(this.updateQuestionLabel);
            this.Controls.Add(this.updateTextLabel);
            this.Controls.Add(this.updateTextTextBox);
            this.Controls.Add(this.CreateQuestionBtn);
            this.Controls.Add(this.areaTextBox);
            this.Controls.Add(this.areaLabel);
            this.Controls.Add(this.difficultyTextBox);
            this.Controls.Add(this.difficultyLabel);
            this.Controls.Add(this.createQuestionLabel);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.textTextBox);
            this.Controls.Add(this.QuestionsDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuestionForm";
            this.Text = "Questions";
            this.Load += new System.EventHandler(this.QuestionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuestionsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView QuestionsDataGridView;
        private MaterialSkin.Controls.MaterialTextBox2 textTextBox;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Label createQuestionLabel;
        private System.Windows.Forms.Label difficultyLabel;
        private MaterialSkin.Controls.MaterialTextBox2 difficultyTextBox;
        private System.Windows.Forms.Label areaLabel;
        private MaterialSkin.Controls.MaterialTextBox2 areaTextBox;
        private Guna.UI2.WinForms.Guna2Button CreateQuestionBtn;
        private Guna.UI2.WinForms.Guna2Button UpdateQuestionButton;
        private MaterialSkin.Controls.MaterialTextBox2 updateAreaTextBox;
        private System.Windows.Forms.Label updateAreaLabel;
        private MaterialSkin.Controls.MaterialTextBox2 updateDifficultyTextBox;
        private System.Windows.Forms.Label updateDifficultyLabel;
        private System.Windows.Forms.Label updateQuestionLabel;
        private System.Windows.Forms.Label updateTextLabel;
        private MaterialSkin.Controls.MaterialTextBox2 updateTextTextBox;
        private Guna.UI2.WinForms.Guna2Button DeleteQuestionButton;
    }
}