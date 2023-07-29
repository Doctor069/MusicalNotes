using MusicalNotes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalNotes
{
    class PlayNotes
    {
        public void Play(IList<INote> notes)
        {
            int playTimeInMilliseconds = 300;
            foreach (var note in notes)
            {
                Console.Beep(note.GradeFrequency, playTimeInMilliseconds);
            }
        }
    }
}
