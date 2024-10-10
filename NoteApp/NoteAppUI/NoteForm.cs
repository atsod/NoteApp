using NoteApp;


namespace NoteAppUI
{
    public partial class NoteForm : Form
    {
        public event Action<Note> OnNoteCreated;
        public event Action<Note> OnNoteEdited;

        private bool _isNewNote;
        public bool IsNewNote
        {
            set
            {
                _isNewNote = value;
            }
        }

        private Note _temporaryNote;
        private Note _note;
        public Note Note
        {
            get
            {
                return _note;
            }
            set 
            {
                _note = value; 

                _temporaryNote = new Note();
                _temporaryNote.Copy(_note);

                TitleTextBox.Text = _note.Name;
                if (!_isNewNote) CategoryComboBox.SelectedIndex = (int)_note.NoteType;
                CreatedDateTimePicker.Value = _note.CreationDate;
                ModifiedDateTimePicker.Value = _note.ModifiedDate;
                DescriptionTextBox.Text = _note.Description;
            }
        }

        public NoteForm()
        {
            InitializeComponent();
            InitializeFormElements();
        }

        private void InitializeFormElements()
        {
            for (int i = 0; i < Enum.GetNames(typeof(NoteType)).Length; i++)
            {
                CategoryComboBox.Items.Add((NoteType)i);
            }
            CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            CreatedDateTimePicker.Enabled = false;
            ModifiedDateTimePicker.Enabled = false;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Note = _temporaryNote;

            if (_isNewNote)
            {
                OnNoteCreated?.Invoke(Note);
            }
            else
            {
                OnNoteEdited?.Invoke(Note);
            }

            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            _temporaryNote.Name = TitleTextBox.Text; // TODO подумать над обработкой максимальной длины названия заметки
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _temporaryNote.NoteType = (NoteType)CategoryComboBox.SelectedIndex;
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            _temporaryNote.Description = DescriptionTextBox.Text;
        }
    }
}
