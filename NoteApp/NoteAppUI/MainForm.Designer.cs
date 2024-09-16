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
            TestObjectsInitialization(out string noteName);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = noteName; //"Form1";
        }

        private void TestObjectsInitialization(out string noteName)
        {
            Note note1 = new Note(NoteType.Work, name: "Заметка номер 1");
            Note note2 = new Note(NoteType.Home);

            Project project = new Project();
            project.Notes.Add(note1);
            project.Notes.Add(note2);

            ProjectManager.SaveToFile(project, ProjectManager.FilePath);

            Project project1 = ProjectManager.LoadFromFile(ProjectManager.FilePath);

            noteName = project1.Notes[0].Name;
        }

        #endregion
    }
}
