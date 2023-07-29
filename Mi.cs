using MusicalNotes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalNotes.Notes
{
    class Mi : INote
    {
        int hertz = 330;
        public int GradeFrequency { get { return hertz; } }
    }
}
