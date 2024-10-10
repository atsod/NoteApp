namespace NoteAppUI
{
    partial class NoteForm
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
            TitleLabel = new Label();
            TitleTextBox = new TextBox();
            CategoryLabel = new Label();
            CreatedLabel = new Label();
            CreatedDateTimePicker = new DateTimePicker();
            ModifiedLabel = new Label();
            ModifiedDateTimePicker = new DateTimePicker();
            DescriptionTextBox = new TextBox();
            OkButton = new Button();
            CancelButton = new Button();
            CategoryComboBox = new ComboBox();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Location = new Point(12, 9);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(41, 20);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Title:";
            // 
            // TitleTextBox
            // 
            TitleTextBox.Location = new Point(90, 6);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(698, 27);
            TitleTextBox.TabIndex = 1;
            TitleTextBox.TextChanged += TitleTextBox_TextChanged;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(12, 47);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(72, 20);
            CategoryLabel.TabIndex = 2;
            CategoryLabel.Text = "Category:";
            // 
            // CreatedLabel
            // 
            CreatedLabel.AutoSize = true;
            CreatedLabel.Location = new Point(12, 88);
            CreatedLabel.Name = "CreatedLabel";
            CreatedLabel.Size = new Size(64, 20);
            CreatedLabel.TabIndex = 4;
            CreatedLabel.Text = "Created:";
            // 
            // CreatedDateTimePicker
            // 
            CreatedDateTimePicker.Location = new Point(91, 84);
            CreatedDateTimePicker.Name = "CreatedDateTimePicker";
            CreatedDateTimePicker.Size = new Size(181, 27);
            CreatedDateTimePicker.TabIndex = 5;
            // 
            // ModifiedLabel
            // 
            ModifiedLabel.AutoSize = true;
            ModifiedLabel.Location = new Point(289, 89);
            ModifiedLabel.Name = "ModifiedLabel";
            ModifiedLabel.Size = new Size(73, 20);
            ModifiedLabel.TabIndex = 6;
            ModifiedLabel.Text = "Modified:";
            // 
            // ModifiedDateTimePicker
            // 
            ModifiedDateTimePicker.Location = new Point(368, 84);
            ModifiedDateTimePicker.Name = "ModifiedDateTimePicker";
            ModifiedDateTimePicker.Size = new Size(181, 27);
            ModifiedDateTimePicker.TabIndex = 7;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(13, 128);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(776, 275);
            DescriptionTextBox.TabIndex = 8;
            DescriptionTextBox.TextChanged += DescriptionTextBox_TextChanged;
            // 
            // OkButton
            // 
            OkButton.Location = new Point(594, 409);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(94, 29);
            OkButton.TabIndex = 9;
            OkButton.Text = "OK";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(694, 409);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 29);
            CancelButton.TabIndex = 10;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(90, 44);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(151, 28);
            CategoryComboBox.TabIndex = 11;
            CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            // 
            // NoteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CategoryComboBox);
            Controls.Add(CancelButton);
            Controls.Add(OkButton);
            Controls.Add(DescriptionTextBox);
            Controls.Add(ModifiedDateTimePicker);
            Controls.Add(ModifiedLabel);
            Controls.Add(CreatedDateTimePicker);
            Controls.Add(CreatedLabel);
            Controls.Add(CategoryLabel);
            Controls.Add(TitleTextBox);
            Controls.Add(TitleLabel);
            Name = "NoteForm";
            Text = "Add/Edit Note";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLabel;
        private TextBox TitleTextBox;
        private Label CategoryLabel;
        private Label CreatedLabel;
        private DateTimePicker CreatedDateTimePicker;
        private Label ModifiedLabel;
        private DateTimePicker ModifiedDateTimePicker;
        private TextBox DescriptionTextBox;
        private Button OkButton;
        private Button CancelButton;
        private ComboBox CategoryComboBox;
    }
}