using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5_L
{
    public class GroupNote : Note
    {
        private List<string> notes;
        public GroupNote(string message, ITheme theme) : base(message, theme) 
        { 
            notes = new List<string>();
        }
        public override void Show()
        {
            this.ChangeColor();
            Console.WriteLine("Group: ");
            string framedMessage = this.GetFramedMessage();
            Console.WriteLine(framedMessage);
            this.PrintNames();
            Console.ResetColor();
        }

        public void AddName(string name)
        {
            notes.Add(name);
        }

        public void RemoveName(string name)
        {
            notes.Remove(name);
        }

        public void PrintNames()
        {
            foreach (string name in notes)
            {
                Console.WriteLine(name);
            }
        }
    }
}
