using System;

public class ReflectionAssignment : MindfulAssignment
{
    private string[] _prompts = {
        "Recall a moment of personal victory.",
        "Think about someone you helped recently.",
        "Reflect on a challenge you overcame."
    };

    private string[] _questions = {
        "Why was this meaningful?",
        "What did you learn about yourself?",
        "How can you apply this lesson elsewhere?"
    };

    public ReflectionAssignment(string studentName, int duration)
        : base(studentName, "Reflection Exercise", duration)
    { }

    public override void StartAssignment()
    {
        Console.WriteLine(GetSummary());
        Random rnd = new Random();
        string prompt = _prompts[rnd.Next(_prompts.Length)];
        Console.WriteLine($"\n💭 Prompt: {prompt}");
        AnimatePause(2);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string question = _questions[rnd.Next(_questions.Length)];
            Console.WriteLine($"🔹 {question}");
            AnimatePause(5);
        }

        Console.WriteLine("🌈 Reflection complete! Feel enlightened.");
        AnimatePause(2);
    }
}
