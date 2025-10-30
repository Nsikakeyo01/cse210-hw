// Entry.cs
// Models a single journal entry, including mood and a daily quote (creative additions).

using System;

public class Entry
{
    // Member variables use underscoreCamelCase
    private string _date;
    private string _prompt;
    private string _response;
    private string _mood;
    private string _quote; // creative: store inspirational quote with each entry

    // Constructor
    public Entry(string date, string prompt, string response, string mood = "Neutral", string quote = "")
    {
        _date = date;
        _prompt = prompt;
        _response = response;
        _mood = mood;
        _quote = quote;
    }

    // Read-only properties (TitleCase)
    public string Date => _date;
    public string Prompt => _prompt;
    public string Response => _response;
    public string Mood => _mood;
    public string Quote => _quote;

    // Display method encapsulates how an Entry prints itself
    public void Display()
    {
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine($"Date   : {_date}");
        Console.WriteLine($"Prompt : {_prompt}");
        Console.WriteLine($"Answer : {_response}");
        Console.WriteLine($"Mood   : {_mood}");
        if (!string.IsNullOrWhiteSpace(_quote))
        {
            Console.WriteLine($"Quote  : \"{_quote}\"");
        }
        Console.WriteLine("--------------------------------------------------");
    }

    // Serialize to a single line for text saving (using a safe separator)
    public string Serialize(string separator)
    {
        // Order: date | prompt | response | mood | quote
        return $"{_date}{separator}{_prompt}{separator}{_response}{separator}{_mood}{separator}{_quote}";
    }

    // Factory: create Entry from a serialized line
    public static Entry Deserialize(string serializedLine, string separator)
    {
        var parts = serializedLine.Split(new string[] { separator }, StringSplitOptions.None);

        string date = parts.Length > 0 ? parts[0] : "";
        string prompt = parts.Length > 1 ? parts[1] : "";
        string response = parts.Length > 2 ? parts[2] : "";
        string mood = parts.Length > 3 ? parts[3] : "Neutral";
        string quote = parts.Length > 4 ? parts[4] : "";

        return new Entry(date, prompt, response, mood, quote);
    }
}
