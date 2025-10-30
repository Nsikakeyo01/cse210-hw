// Journal.cs
// Manages a collection of Entry objects.

using System;
using System.Collections.Generic;

public class Journal
{
    // Member variable holds entries (encapsulation)
    private List<Entry> _entries = new List<Entry>();

    // AddEntry encapsulates how entries are stored
    public void AddEntry(Entry anEntry)
    {
        _entries.Add(anEntry);
    }

    // Return a shallow copy of entries to avoid exposing internal list
    public List<Entry> GetEntries()
    {
        return new List<Entry>(_entries);
    }

    // Display all entries by delegating to Entry.Display()
    public void DisplayEntries()
    {
        var entries = _entries;
        if (entries.Count == 0)
        {
            Console.WriteLine("\nJournal is empty.");
            return;
        }

        Console.WriteLine($"\nJournal contains {entries.Count} entries:\n");
        foreach (var entry in entries)
        {
            entry.Display();
        }
    }

    // Replace entries (used for loading from file)
    public void ReplaceEntries(List<Entry> entries)
    {
        _entries = new List<Entry>(entries);
    }
}
