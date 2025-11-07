using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private string[] _prompts = {
        "Think of a time you helped someone unexpectedly.",
        "Recall a moment when you overcame a personal challenge.",
        "Remember a time when you made someone smile.",
        "Think about a moment you learned something important."
    };

    private string[] _questions = {
        "Why was this experience meaningful to you?",
        "What did you learn about yourself?",
        "How can you apply this lesson elsewhere?",
        "What would you do differently next time?"
    };

    public ReflectionActivity() : base(
        "Reflection",
        "Reflect on moments in your life that reveal your strength and character.")
    { }

    public override void Start()
    {
        DisplayStartingMessage();
        Random rnd = new Random();
        string prompt = _prompts[rnd.Next(_prompts.Length)];
        Console.WriteLine($"\n💭 {prompt}\n");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string question = _questions[rnd.Next(_questions.Length)];
            Console.WriteLine($"🔹 {question}");
            PauseWithAnimation(5); // 5-second reflection pause
        }

        DisplayEndingMessage();
    }
}
