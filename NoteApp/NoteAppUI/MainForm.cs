using NoteApp;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace NoteAppUI
{
    public partial class MainForm : Form
    {
        private Project _project;

        public MainForm()
        {
            InitializeComponent();
            InitializeFormElements();
        }

        private void InitializeFormElements()
        {
            _project = ProjectManager.LoadFromFile(ProjectManager.FilePath);

            if (_project.Notes.Count > 0)
            {
                for (int i = 0; i < _project.Notes.Count; i++)
                {
                    NotesListBox.Items.Add(_project.Notes[i].Name);
                }

                NotesListBox.SelectedIndex = 0;
            }
            else
            {
                ShowDefaultNote();
            }
            /*
            for (int i = 0; i < Enum.GetNames(typeof(NoteType)).Length; i++)
            {
                CategoryComboBox.Items.Add((NoteType)i);
            }*/
            CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            
            CreatedDateTimePicker.Enabled = false;
            ModifiedDateTimePicker.Enabled = false;
            NoteDescriptionBox.ReadOnly = true;
        }

        private void ShowDefaultNote()
        {
            NoteName.Text = "Это приложение NoteApp!";
            ChosenCategoryLabel.Text = "Спасибо, что выбрали нас!";
            NoteDescriptionBox.Text = "Для создания заметки нажмите на кнопку 'Add' в нижней левой части экрана. " +
                "Либо выберите уже существующую заметку и нажмите 'Edit' для ее редактирования или 'Delete' для ее удаления.";
        }

        private void BottomAddButton_Click(object sender, EventArgs e)
        {
            NoteForm noteForm = new NoteForm();
            noteForm.OnNoteCreated += AddNote;
            noteForm.IsNewNote = true;
            noteForm.Note = new();
            noteForm.ShowDialog();
        }

        private void AddNote(Note note)
        {
            _project.Notes.Add(note);
            NotesListBox.Items.Add(note.Name);
            NotesListBox.SetSelected(_project.Notes.Count - 1, true);

            ProjectManager.SaveToFile(_project, ProjectManager.FilePath);
        }

        private void BottomEditButton_Click(object sender, EventArgs e)
        {
            if (NotesListBox.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a note to edit.",
                    "No Note Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            NoteForm noteForm = new NoteForm();
            noteForm.OnNoteEdited += EditNote;
            noteForm.IsNewNote = false;
            noteForm.Note = _project.Notes[NotesListBox.SelectedIndex];
            noteForm.ShowDialog();
        }

        private void EditNote(Note note)
        {
            _project.Notes[NotesListBox.SelectedIndex] = note;
            NotesListBox.Items[NotesListBox.SelectedIndex] = note.Name;

            ProjectManager.SaveToFile(_project, ProjectManager.FilePath);
        }

        private void BottomDeleteButton_Click(object sender, EventArgs e)
        {
            int index = NotesListBox.SelectedIndex;

            if (index == -1)
            {
                MessageBox.Show(
                    "Please select a note to delete.", 
                    "No Note Selected", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult result = MessageBox.Show(
                string.Format("Do you really want to remove this note: {0}", NotesListBox.Items[index]),
                "Confirm Deletion",
                MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Question);
            
            if (result == DialogResult.OK)
            {
                _project.Notes.RemoveAt(index);
                NotesListBox.Items.RemoveAt(index);

                ProjectManager.SaveToFile(_project, ProjectManager.FilePath);
            }
        }

        private void NoteName_Click(object sender, EventArgs e)
        {

        }

        private void FileButton_Click(object sender, EventArgs e)
        {

        }

        private void EditButton_Click(object sender, EventArgs e)
        {

        }

        private void HelpButton_Click(object sender, EventArgs e)
        {

        }

        private void NotesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = NotesListBox.SelectedIndex;
            if (index == -1)
            {
                ShowDefaultNote();

                return;
            }

            Note note = _project.Notes[index];

            NoteName.Text = note.Name;
            ChosenCategoryLabel.Text = note.NoteType.ToString();
            CreatedDateTimePicker.Value = note.CreationDate;
            ModifiedDateTimePicker.Value = note.ModifiedDate;
            NoteDescriptionBox.Text = note.Description;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProjectManager.SaveToFile(_project, ProjectManager.FilePath);
        }
    }
}
