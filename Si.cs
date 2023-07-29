using MusicalNotes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalNotes.Notes
{
    class Si : INote
    {
        int hertz = 490;
        public int GradeFrequency { get { return hertz; } }
    }
}
