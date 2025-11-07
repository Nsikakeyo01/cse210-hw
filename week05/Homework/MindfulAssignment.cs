using System;
using System.Threading;

public class MindfulAssignment
{
    protected string _studentName;
    protected string _topic;
    protected int _duration; // seconds

    public MindfulAssignment(string studentName, string topic, int duration)
    {
        _studentName = studentName;
        _topic = topic;
        _duration = duration;
    }

    // Get summary
    public string GetSummary()
    {
        return $"✨ {_studentName} - {_topic} ✨";
    }

    // Spinner animation
    protected void AnimatePause(int seconds)
    {
        string[] spinner = { "🌀", "🌪️", "💨", "💫" };
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }

    // Virtual method to override
    public virtual void StartAssignment()
    {
        Console.WriteLine(GetSummary());
        Console.WriteLine("Prepare to begin your mindful task...");
        AnimatePause(3);
        Console.WriteLine("Task complete!");
    }
}
