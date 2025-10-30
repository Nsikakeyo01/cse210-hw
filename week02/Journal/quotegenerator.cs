// QuoteGenerator.cs
// Provides random inspirational quotes to motivate journaling (creative feature).

using System;
using System.Collections.Generic;

public class QuoteGenerator
{
    private List<string> _quotes;
    private Random _random = new Random();

    public QuoteGenerator()
    {
        _quotes = new List<string>()
        {
            "Start where you are. Use what you have. Do what you can.",
            "Small steps every day lead to big changes.",
            "Your story matters — write it down.",
            "Reflection turns experience into insight.",
            "Today’s thoughts are tomorrow’s memories.",
            "A grateful heart remembers the gifts of today.",
            "Write like no one will read it — then share with pride."
        };
    }

    public string GetRandomQuote()
    {
        int index = _random.Next(0, _quotes.Count);
        return _quotes[index];
    }
}
