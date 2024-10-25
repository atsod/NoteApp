

namespace NoteApp
{
    /// <summary>
    /// Класс, хранящий информацию о заметке: название, категория заметки, 
    /// текст заметки, дата создания, дата последнего изменения.
    /// </summary>
    public class Note : ICloneable
    {
        private string _name;
        /// <summary>
        /// Поле, хранящее информацию о названии заметки.
        /// </summary>
        public string Name 
        { 
            get => _name; 
            set
            {
                _name = value;
                _modifiedDate = DateTime.Now;
            }
        }
        
        private NoteType _noteType;
        /// <summary>
        /// Поле, хранящее информацию о категории заметки.
        /// </summary>
        public NoteType NoteType
        {
            get => _noteType;
            set
            {
                _noteType = value;
                _modifiedDate = DateTime.Now;
            }
        }
        
        private string _description;
        /// <summary>
        /// Поле, хранящее информацию о тексте заметки.
        /// </summary>
        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                _modifiedDate = DateTime.Now;
            }
        }
        
        private DateTime _creationDate;
        /// <summary>
        /// Поле, хранящее информацию о дате создания заметки.
        /// </summary>
        public DateTime CreationDate
        {
            get => _creationDate;
            private set => _creationDate = value;
        }
        
        private DateTime _modifiedDate;
        /// <summary>
        /// Поле, хранящее информацию о последнем изменении заметки.
        /// </summary>
        public DateTime ModifiedDate
        {
            get => _modifiedDate;
            private set => _modifiedDate = value;
        }

        public Note(string name = "Без названия", string description = "")
        {
            Name = name;
            Description = description;
            _creationDate = DateTime.Now;
        }
        
        [Newtonsoft.Json.JsonConstructor]
        public Note(string name, string description, NoteType noteType, 
            DateTime creationDate, DateTime modifiedDate)
        {
            Name = name;
            Description = description;
            NoteType = noteType;
            CreationDate = creationDate;
            ModifiedDate = modifiedDate;
        }

        public void Copy(Note note)
        {
            _name = note.Name;
            _noteType = note.NoteType;
            _description = note.Description;
            _creationDate = note.CreationDate;
            _modifiedDate= note.ModifiedDate;
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
