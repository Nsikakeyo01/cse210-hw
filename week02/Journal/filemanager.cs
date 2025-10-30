// FileManager.cs
// Handles saving and loading journals to/from text and JSON files.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class FileManager
{
    // A separator unlikely to appear in normal text
    private readonly string _separator = "~|~";

    // Save to text file (simple serialized lines)
    public void SaveToTextFile(Journal journal, string filename)
    {
        if (string.IsNullOrWhiteSpace(filename))
            throw new ArgumentException("Filename must not be empty.");

        var lines = new List<string>();
        foreach (var entry in journal.GetEntries())
        {
            lines.Add(entry.Serialize(_separator));
        }

        File.WriteAllLines(filename, lines);
    }

    // Load from text file and return a Journal
    public Journal LoadFromTextFile(string filename)
    {
        if (!File.Exists(filename))
            throw new FileNotFoundException("File not found", filename);

        var lines = File.ReadAllLines(filename);
        var entries = new List<Entry>();
        foreach (var line in lines)
        {
            if (string.IsNullOrWhiteSpace(line))
                continue;

            entries.Add(Entry.Deserialize(line, _separator));
        }

        var journal = new Journal();
        journal.ReplaceEntries(entries);
        return journal;
    }

    // Save to JSON file (extra - structured)
    public void SaveToJsonFile(Journal journal, string filename)
    {
        if (string.IsNullOrWhiteSpace(filename))
            throw new ArgumentException("Filename must not be empty.");

        // Convert to DTO list for safe serialization
        var dtoList = new List<EntryDto>();
        foreach (var entry in journal.GetEntries())
        {
            dtoList.Add(new EntryDto
            {
                Date = entry.Date,
                Prompt = entry.Prompt,
                Response = entry.Response,
                Mood = entry.Mood,
                Quote = entry.Quote
            });
        }

        var options = new JsonSerializerOptions { WriteIndented = true };
        string json = JsonSerializer.Serialize(dtoList, options);
        File.WriteAllText(filename, json);
    }

    // Load from JSON file and return a Journal (extra)
    public Journal LoadFromJsonFile(string filename)
    {
        if (!File.Exists(filename))
            throw new FileNotFoundException("File not found", filename);

        string json = File.ReadAllText(filename);
        var dtoList = JsonSerializer.Deserialize<List<EntryDto>>(json);
        var entries = new List<Entry>();
        if (dtoList != null)
        {
            foreach (var dto in dtoList)
            {
                entries.Add(new Entry(dto.Date ?? "", dto.Prompt ?? "", dto.Response ?? "", dto.Mood ?? "Neutral", dto.Quote ?? ""));
            }
        }

        var journal = new Journal();
        journal.ReplaceEntries(entries);
        return journal;
    }

    // DTO used for JSON serialization/deserialization
    private class EntryDto
    {
        public string Date { get; set; } = "";
        public string Prompt { get; set; } = "";
        public string Response { get; set; } = "";
        public string Mood { get; set; } = "";
        public string Quote { get; set; } = "";
    }
}
