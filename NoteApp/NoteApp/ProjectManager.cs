using Newtonsoft.Json;


namespace NoteApp
{
    /// <summary>
    /// Класс, отвечающий за сериализацию и десериализацию объекта типа Project.
    /// </summary>
    public static class ProjectManager
    {
        /// <summary>
        /// Поле, хранящее информацию о пути к файлу с названием NoteApp.notes, 
        /// в который будет сохраняться объект класса Project.
        /// </summary>
        public static readonly string FilePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "NoteApp.notes");

        /// <summary>
        /// Метод, отвечающий за сериализацию объекта класса Project в файл по пути filename.
        /// </summary>
        /// <param name="project">объект класса Project</param>
        /// <param name="fileName">путь к файлу</param>
        public static void SaveToFile(Project project, string fileName)
        {
            JsonSerializer serializer = new JsonSerializer();
            
            using (StreamWriter sw = new StreamWriter(fileName))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, project);
            }
        }

        /// <summary>
        /// Метод, отвечающий за десериализацию объекта класса Project из файла по пути filename.
        /// </summary>
        /// <param name="fileName">путь к файлу</param>
        /// <returns>Возвращает экземпляр класса ProjectЮ полученный из файла</returns>
        public static Project LoadFromFile(string fileName)
        {
            Project project = null;
            
            if (!File.Exists(fileName))
            {
                project = new Project();
                SaveToFile(project, fileName);
                return project;
            }
            
            JsonSerializer serializer = new JsonSerializer();

            using (StreamReader sr = new StreamReader(fileName))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                project = (Project)serializer.Deserialize<Project>(reader);
            }

            return project;
        }
    }
}
