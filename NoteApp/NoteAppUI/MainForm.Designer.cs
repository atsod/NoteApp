using NoteApp;
using System.Security.AccessControl;

namespace NoteAppUI
{
    partial class MainForm
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
            BottomAddButton = new Button();
            NoteDescriptionBox = new TextBox();
            CategoryComboBox = new ComboBox();
            NoteName = new Label();
            NotesListBox = new ListBox();
            ShowCategoryLabel = new Label();
            EditButton = new Button();
            HelpButton = new Button();
            FileButton = new Button();
            CategoryLabel = new Label();
            CreatedLabel = new Label();
            ModifiedLabel = new Label();
            ChosenCategoryLabel = new Label();
            CreatedDateTimePicker = new DateTimePicker();
            ModifiedDateTimePicker = new DateTimePicker();
            BottomEditButton = new Button();
            BottomDeleteButton = new Button();
            SuspendLayout();
            // 
            // BottomAddButton
            // 
            BottomAddButton.Location = new Point(12, 399);
            BottomAddButton.Name = "BottomAddButton";
            BottomAddButton.Size = new Size(83, 39);
            BottomAddButton.TabIndex = 0;
            BottomAddButton.Text = "Add";
            BottomAddButton.UseVisualStyleBackColor = true;
            BottomAddButton.Click += BottomAddButton_Click;
            // 
            // NoteDescriptionBox
            // 
            NoteDescriptionBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            NoteDescriptionBox.Location = new Point(318, 149);
            NoteDescriptionBox.Multiline = true;
            NoteDescriptionBox.Name = "NoteDescriptionBox";
            NoteDescriptionBox.Size = new Size(471, 289);
            NoteDescriptionBox.TabIndex = 1;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(130, 50);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(164, 28);
            CategoryComboBox.TabIndex = 2;
            // 
            // NoteName
            // 
            NoteName.AutoSize = true;
            NoteName.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            NoteName.Location = new Point(317, 53);
            NoteName.Name = "NoteName";
            NoteName.Size = new Size(118, 25);
            NoteName.TabIndex = 3;
            NoteName.Text = "Note Name";
            NoteName.Click += NoteName_Click;
            // 
            // NotesListBox
            // 
            NotesListBox.FormattingEnabled = true;
            NotesListBox.Location = new Point(12, 83);
            NotesListBox.Name = "NotesListBox";
            NotesListBox.Size = new Size(282, 304);
            NotesListBox.TabIndex = 4;
            NotesListBox.SelectedIndexChanged += NotesListBox_SelectedIndexChanged;
            // 
            // ShowCategoryLabel
            // 
            ShowCategoryLabel.AutoSize = true;
            ShowCategoryLabel.Location = new Point(12, 50);
            ShowCategoryLabel.Name = "ShowCategoryLabel";
            ShowCategoryLabel.Size = new Size(112, 20);
            ShowCategoryLabel.TabIndex = 5;
            ShowCategoryLabel.Text = "Show Category:";
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.Transparent;
            EditButton.FlatAppearance.BorderSize = 0;
            EditButton.FlatStyle = FlatStyle.Flat;
            EditButton.Location = new Point(62, -4);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(56, 39);
            EditButton.TabIndex = 7;
            EditButton.TabStop = false;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // HelpButton
            // 
            HelpButton.BackColor = Color.Transparent;
            HelpButton.FlatAppearance.BorderSize = 0;
            HelpButton.FlatStyle = FlatStyle.Flat;
            HelpButton.Location = new Point(124, -4);
            HelpButton.Name = "HelpButton";
            HelpButton.Size = new Size(56, 39);
            HelpButton.TabIndex = 8;
            HelpButton.TabStop = false;
            HelpButton.Text = "Help";
            HelpButton.UseVisualStyleBackColor = false;
            HelpButton.Click += HelpButton_Click;
            // 
            // FileButton
            // 
            FileButton.BackColor = Color.Transparent;
            FileButton.FlatAppearance.BorderSize = 0;
            FileButton.FlatStyle = FlatStyle.Flat;
            FileButton.Location = new Point(0, -4);
            FileButton.Name = "FileButton";
            FileButton.Size = new Size(56, 39);
            FileButton.TabIndex = 6;
            FileButton.TabStop = false;
            FileButton.Text = "File";
            FileButton.UseVisualStyleBackColor = false;
            FileButton.Click += FileButton_Click;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(317, 84);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(72, 20);
            CategoryLabel.TabIndex = 9;
            CategoryLabel.Text = "Category:";
            // 
            // CreatedLabel
            // 
            CreatedLabel.AutoSize = true;
            CreatedLabel.Location = new Point(317, 115);
            CreatedLabel.Name = "CreatedLabel";
            CreatedLabel.Size = new Size(64, 20);
            CreatedLabel.TabIndex = 10;
            CreatedLabel.Text = "Created:";
            // 
            // ModifiedLabel
            // 
            ModifiedLabel.AutoSize = true;
            ModifiedLabel.Location = new Point(558, 115);
            ModifiedLabel.Name = "ModifiedLabel";
            ModifiedLabel.Size = new Size(73, 20);
            ModifiedLabel.TabIndex = 11;
            ModifiedLabel.Text = "Modified:";
            // 
            // ChosenCategoryLabel
            // 
            ChosenCategoryLabel.AutoSize = true;
            ChosenCategoryLabel.Location = new Point(395, 84);
            ChosenCategoryLabel.Name = "ChosenCategoryLabel";
            ChosenCategoryLabel.Size = new Size(67, 20);
            ChosenCategoryLabel.TabIndex = 12;
            ChosenCategoryLabel.Text = "category";
            // 
            // CreatedDateTimePicker
            // 
            CreatedDateTimePicker.Location = new Point(387, 110);
            CreatedDateTimePicker.Name = "CreatedDateTimePicker";
            CreatedDateTimePicker.Size = new Size(165, 27);
            CreatedDateTimePicker.TabIndex = 13;
            // 
            // ModifiedDateTimePicker
            // 
            ModifiedDateTimePicker.Location = new Point(637, 110);
            ModifiedDateTimePicker.Name = "ModifiedDateTimePicker";
            ModifiedDateTimePicker.Size = new Size(152, 27);
            ModifiedDateTimePicker.TabIndex = 14;
            // 
            // BottomEditButton
            // 
            BottomEditButton.Location = new Point(101, 399);
            BottomEditButton.Name = "BottomEditButton";
            BottomEditButton.Size = new Size(83, 39);
            BottomEditButton.TabIndex = 15;
            BottomEditButton.Text = "Edit";
            BottomEditButton.UseVisualStyleBackColor = true;
            BottomEditButton.Click += BottomEditButton_Click;
            // 
            // BottomDeleteButton
            // 
            BottomDeleteButton.Location = new Point(190, 399);
            BottomDeleteButton.Name = "BottomDeleteButton";
            BottomDeleteButton.Size = new Size(83, 39);
            BottomDeleteButton.TabIndex = 16;
            BottomDeleteButton.Text = "Delete";
            BottomDeleteButton.UseVisualStyleBackColor = true;
            BottomDeleteButton.Click += BottomDeleteButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BottomDeleteButton);
            Controls.Add(BottomEditButton);
            Controls.Add(ModifiedDateTimePicker);
            Controls.Add(CreatedDateTimePicker);
            Controls.Add(ChosenCategoryLabel);
            Controls.Add(ModifiedLabel);
            Controls.Add(CreatedLabel);
            Controls.Add(CategoryLabel);
            Controls.Add(HelpButton);
            Controls.Add(EditButton);
            Controls.Add(FileButton);
            Controls.Add(ShowCategoryLabel);
            Controls.Add(NotesListBox);
            Controls.Add(NoteName);
            Controls.Add(CategoryComboBox);
            Controls.Add(NoteDescriptionBox);
            Controls.Add(BottomAddButton);
            Name = "MainForm";
            Text = "NoteApp";
            FormClosing += MainForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BottomAddButton;
        private TextBox NoteDescriptionBox;
        private ComboBox CategoryComboBox;
        private Label NoteName;
        private ListBox NotesListBox;
        private Label ShowCategoryLabel;
        private Button EditButton;
        private Button HelpButton;
        private Button FileButton;
        private Label CategoryLabel;
        private Label CreatedLabel;
        private Label ModifiedLabel;
        private Label ChosenCategoryLabel;
        private DateTimePicker CreatedDateTimePicker;
        private DateTimePicker ModifiedDateTimePicker;
        private Button BottomEditButton;
        private Button BottomDeleteButton;
    }
}
