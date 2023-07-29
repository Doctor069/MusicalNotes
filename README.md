# Musical Notes Player using Flyweight Pattern

This project implements a simple musical notes player in C# that can play musical notes using the `Console.Beep` method. The implementation follows the Flyweight pattern design, which allows efficient storage and playback of musical notes.

## Getting Started

To use this musical notes player, follow the steps below:

1. Clone the repository to your local machine or download the source code.

2. Open the C# solution in your preferred development environment (Visual Studio, Visual Studio Code, etc.).

3. Compile the code to generate the executable.

4. Run the executable to play your favorite musical notes.

## How it Works

The project uses the Flyweight pattern to optimize memory usage when playing musical notes. The Flyweight pattern is particularly useful when there are many similar objects to be instantiated, as is the case with musical notes.

### Flyweight Pattern

The Flyweight pattern is a structural design pattern that aims to reduce memory usage by sharing common state between multiple objects instead of keeping it in each object individually. In our case, the `INote` interface serves as the flyweight, representing a musical note, and the `MusicalNotes` class acts as the factory for creating these flyweights.

### Implementing the Notes

To implement the notes, we use a list of `INote` objects. To start, you need to create a list to store the musical notes:

```csharp
IList<INote> notes = new List<INote>();
```

Next, you can use the `MusicalNotes` class to take the notes and add them to the list:

```csharp
MusicalNotes musicalNotes = new MusicalNotes();
musicalNotes.TakeNote("re");
musicalNotes.TakeNote("mi");
// Add more notes as needed
```

### Playing the Notes

Once you have your list of notes, you can play them using the `PlayNotes` class. First, create an instance of `PlayNotes`:

```csharp
PlayNotes playNotes = new PlayNotes();
```

Then, use the `Play` method to play the notes from the list:

```csharp
playNotes.Play(notes);
```

The `Play` method will iterate through the list of notes and use `Console.Beep` to play each note.

## Example

Here's a simple example of how to use the musical notes player:

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        IList<INote> notes = new List<INote>();
        MusicalNotes musicalNotes = new MusicalNotes();

        musicalNotes.TakeNote("do");
        musicalNotes.TakeNote("re");
        musicalNotes.TakeNote("mi");
        musicalNotes.TakeNote("do");

        PlayNotes playNotes = new PlayNotes();
        playNotes.Play(notes);

        Console.WriteLine("Enjoy the music!");
    }
}
```

## Conclusion

With the implemented musical notes player and the Flyweight pattern, you can efficiently play various musical notes without consuming unnecessary memory. Feel free to expand the list of notes and create your own melodies!

Have fun playing your tunes! If you have any questions or feedback, don't hesitate to reach out.

Happy coding!
