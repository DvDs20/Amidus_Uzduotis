namespace Amidus_Uzduotis
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            languagesComboBox = new ComboBox();
            scoreTextBox = new TextBox();
            submitButton = new Button();
            languagesDataGridView = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Language = new DataGridViewTextBoxColumn();
            MinScore = new DataGridViewTextBoxColumn();
            MaxScore = new DataGridViewTextBoxColumn();
            AverageScore = new DataGridViewTextBoxColumn();
            NumberOfVotes = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)languagesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(414, 77);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 0;
            label1.Text = "Language:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 108);
            label2.Name = "label2";
            label2.Size = new Size(478, 21);
            label2.TabIndex = 1;
            label2.Text = "From 0 to 100 how much would you recommend it for your enemy:";
            // 
            // languagesComboBox
            // 
            languagesComboBox.FormattingEnabled = true;
            languagesComboBox.Location = new Point(501, 77);
            languagesComboBox.Name = "languagesComboBox";
            languagesComboBox.Size = new Size(158, 23);
            languagesComboBox.TabIndex = 2;
            // 
            // scoreTextBox
            // 
            scoreTextBox.Location = new Point(501, 110);
            scoreTextBox.Name = "scoreTextBox";
            scoreTextBox.PlaceholderText = "50";
            scoreTextBox.Size = new Size(158, 23);
            scoreTextBox.TabIndex = 3;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(665, 76);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(123, 57);
            submitButton.TabIndex = 4;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // languagesDataGridView
            // 
            languagesDataGridView.AllowUserToAddRows = false;
            languagesDataGridView.AllowUserToDeleteRows = false;
            languagesDataGridView.AllowUserToResizeColumns = false;
            languagesDataGridView.AllowUserToResizeRows = false;
            languagesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            languagesDataGridView.BackgroundColor = SystemColors.Control;
            languagesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            languagesDataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, Language, MinScore, MaxScore, AverageScore, NumberOfVotes });
            languagesDataGridView.Location = new Point(12, 158);
            languagesDataGridView.Name = "languagesDataGridView";
            languagesDataGridView.ReadOnly = true;
            languagesDataGridView.Size = new Size(776, 158);
            languagesDataGridView.TabIndex = 5;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Language
            // 
            Language.HeaderText = "Language";
            Language.Name = "Language";
            Language.ReadOnly = true;
            // 
            // MinScore
            // 
            MinScore.HeaderText = "Min Score";
            MinScore.Name = "MinScore";
            MinScore.ReadOnly = true;
            // 
            // MaxScore
            // 
            MaxScore.HeaderText = "Max Score";
            MaxScore.Name = "MaxScore";
            MaxScore.ReadOnly = true;
            // 
            // AverageScore
            // 
            AverageScore.HeaderText = "Average Score";
            AverageScore.Name = "AverageScore";
            AverageScore.ReadOnly = true;
            // 
            // NumberOfVotes
            // 
            NumberOfVotes.HeaderText = "Number Of Votes";
            NumberOfVotes.Name = "NumberOfVotes";
            NumberOfVotes.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 366);
            Controls.Add(languagesDataGridView);
            Controls.Add(submitButton);
            Controls.Add(scoreTextBox);
            Controls.Add(languagesComboBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Best app in the whole white world";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)languagesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox languagesComboBox;
        private TextBox scoreTextBox;
        private Button submitButton;
        private DataGridView languagesDataGridView;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Language;
        private DataGridViewTextBoxColumn MinScore;
        private DataGridViewTextBoxColumn MaxScore;
        private DataGridViewTextBoxColumn AverageScore;
        private DataGridViewTextBoxColumn NumberOfVotes;
    }
}
