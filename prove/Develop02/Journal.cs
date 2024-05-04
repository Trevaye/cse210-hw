using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
       using (StreamWriter writer = new StreamWriter(file))
       {
        foreach (var entry in _entries)
        {
            writer.WriteLine(entry.Date);
            writer.WriteLine(entry.PromptText);
            writer.WriteLine(entry.EntryText);
        }
       } 
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();
        using (StreamReader reader = new StreamReader(file))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string date = line;
                string promptText = reader.ReadLine();
                string entryText = reader.ReadLine();
                AddEntry(new Entry(date, promptText, entryText));
            }
        }
    }
}