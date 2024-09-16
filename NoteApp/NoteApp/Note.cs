
namespace NoteApp
{
    /// <summary>
    /// Класс, хранящий информацию о заметке: название, категория заметки, 
    /// текст заметки, дата создания, дата последнего изменения.
    /// </summary>
    public class Note : ICloneable
    {
        /// <summary>
        /// Поле, хранящее информацию о названии заметки.
        /// </summary>
        private string _name;
        public string Name 
        { 
            get 
            { 
                return _name; 
            }
            set
            {
                if(value.Length <= 50)
                {
                    _name = value;
                    _lastChangeDate = DateTime.Now;
                }
                else
                {
                    throw new ArgumentException("Слишком длинное название!");
                }
            }
        }

        /// <summary>
        /// Поле, хранящее информацию о категории заметки.
        /// </summary>
        private NoteType _noteType;
        public NoteType NoteType
        {
            get
            {
                return _noteType;
            }
            set
            {
                _noteType = value;
                _lastChangeDate = DateTime.Now;
            }
        }

        /// <summary>
        /// Поле, хранящее информацию о тексте заметки.
        /// </summary>
        private string _description;
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                _lastChangeDate = DateTime.Now;
            }
        }

        /// <summary>
        /// Поле, хранящее информацию о дате создания заметки.
        /// </summary>
        private DateTime _creationDate;
        public DateTime CreationDate
        {
            get
            {
                return _creationDate;
            }
        }

        /// <summary>
        /// Поле, хранящее информацию о последнем изменении заметки.
        /// </summary>
        private DateTime _lastChangeDate;
        public DateTime LastChangeDate
        {
            get
            {
                return _lastChangeDate;
            }
        }

        public Note(NoteType noteType, string name = "Без названия", string description = "")
        {
            Name = name;
            NoteType = noteType;
            Description = description;
            _creationDate = DateTime.Now;
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
