
namespace NoteApp
{
    /// <summary>
    /// Класс, хранящий информацию о всех заметках в одном списке.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Поле, хранящее список всех заметок.
        /// </summary>
        public readonly List<Note> Notes;

        public Project()
        {
            Notes = new();
        }
    }
}
