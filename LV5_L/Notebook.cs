using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5_L
{
    public class Notebook
    {
        private List<Note> notes;
        private ITheme theme;
        public Notebook(ITheme theme)
        {
            this.notes = new List<Note>();
            this.theme = theme;
        }
        public void AddNote(Note note)
        {
            note.Theme = theme;
            this.notes.Add(note);
        }
        public void ChangeTheme(ITheme theme)
        {
            this.theme = theme;
            foreach (Note note in this.notes)
            {
                note.Theme = theme;
            }
        }
        public void Display()
        {
            foreach (Note note in this.notes)
            {
                note.Show();
                Console.WriteLine("\n");
            }
        }
    }
}
