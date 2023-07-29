using MusicalNotes.Interfaces;
using MusicalNotes.Notes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalNotes
{
    class MusicalNotes
    {
        private static IDictionary<string, INote> musicalNotes = new Dictionary<string, INote>()
        {
            {"do", new Do() },
            {"re", new Re() },
            {"mi", new Mi() },
            {"fa", new Fa() },
            {"sol", new Sol() },
            {"la", new La() },
            {"si", new Si() }
        };

        public INote TakeNote(string nameNote)
        {
            return musicalNotes[nameNote];
        }
    }
}