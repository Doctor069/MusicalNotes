using MusicalNotes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalNotes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MusicalNotes musicalNotes = new MusicalNotes();

            IList<INote> notes = new List<INote>()
            {
                musicalNotes.TakeNote("re"), musicalNotes.TakeNote("re"), musicalNotes.TakeNote("re"), musicalNotes.TakeNote("re"),
                musicalNotes.TakeNote("mi"), musicalNotes.TakeNote("mi"), musicalNotes.TakeNote("mi"), musicalNotes.TakeNote("mi"),
                musicalNotes.TakeNote("fa"), musicalNotes.TakeNote("fa"), musicalNotes.TakeNote("fa"), musicalNotes.TakeNote("fa"),
                musicalNotes.TakeNote("mi"), musicalNotes.TakeNote("mi"), musicalNotes.TakeNote("mi"), musicalNotes.TakeNote("mi"),

                musicalNotes.TakeNote("sol"), musicalNotes.TakeNote("sol"), musicalNotes.TakeNote("sol"), musicalNotes.TakeNote("sol"),
                musicalNotes.TakeNote("la"), musicalNotes.TakeNote("la"), musicalNotes.TakeNote("la"), musicalNotes.TakeNote("la"),
                musicalNotes.TakeNote("sol"), musicalNotes.TakeNote("sol"), musicalNotes.TakeNote("sol"), musicalNotes.TakeNote("sol"),
                musicalNotes.TakeNote("la"), musicalNotes.TakeNote("la"), musicalNotes.TakeNote("la"), musicalNotes.TakeNote("la"),

                musicalNotes.TakeNote("fa"), musicalNotes.TakeNote("fa"), musicalNotes.TakeNote("fa"), musicalNotes.TakeNote("fa"),
                musicalNotes.TakeNote("la"), musicalNotes.TakeNote("la"), musicalNotes.TakeNote("la"), musicalNotes.TakeNote("la"),
                musicalNotes.TakeNote("fa"), musicalNotes.TakeNote("fa"), musicalNotes.TakeNote("fa"), musicalNotes.TakeNote("fa")
            };

            PlayNotes playNotes = new PlayNotes();
            playNotes.Play(notes);
        }
    }
}
