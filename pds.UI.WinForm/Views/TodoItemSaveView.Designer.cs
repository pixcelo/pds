namespace pds.UI.WinForm.Views
{
    partial class TodoItemSaveView
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
            SaveButton = new Button();
            titleLabel = new Label();
            TitleTextBox = new TextBox();
            DescriptionTextBox = new TextBox();
            descriotionLabel = new Label();
            DueDateTextBox = new DateTimePicker();
            StatusComboBox = new ComboBox();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(45, 37);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 0;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(45, 82);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(29, 15);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Title";
            // 
            // TitleTextBox
            // 
            TitleTextBox.Location = new Point(45, 100);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(267, 23);
            TitleTextBox.TabIndex = 2;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(45, 151);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(267, 80);
            DescriptionTextBox.TabIndex = 3;
            // 
            // descriotionLabel
            // 
            descriotionLabel.AutoSize = true;
            descriotionLabel.Location = new Point(45, 133);
            descriotionLabel.Name = "descriotionLabel";
            descriotionLabel.Size = new Size(67, 15);
            descriotionLabel.TabIndex = 4;
            descriotionLabel.Text = "Description";
            // 
            // DueDateTextBox
            // 
            DueDateTextBox.Location = new Point(190, 68);
            DueDateTextBox.Name = "DueDateTextBox";
            DueDateTextBox.Size = new Size(122, 23);
            DueDateTextBox.TabIndex = 5;
            DueDateTextBox.Value = new DateTime(2024, 6, 23, 0, 0, 0, 0);
            // 
            // StatusComboBox
            // 
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(191, 37);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(121, 23);
            StatusComboBox.TabIndex = 6;
            // 
            // TodoItemSaveView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 248);
            Controls.Add(StatusComboBox);
            Controls.Add(DueDateTextBox);
            Controls.Add(descriotionLabel);
            Controls.Add(DescriptionTextBox);
            Controls.Add(TitleTextBox);
            Controls.Add(titleLabel);
            Controls.Add(SaveButton);
            Name = "TodoItemSaveView";
            Text = "TodoItemSaveView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveButton;
        private Label titleLabel;
        private TextBox TitleTextBox;
        private TextBox DescriptionTextBox;
        private Label descriotionLabel;
        private DateTimePicker DueDateTextBox;
        private ComboBox StatusComboBox;
    }
}