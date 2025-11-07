using System;
using System.Threading;

public class Activity
{
    // Base attributes for all activities
    protected string _name;
    protected string _description;
    protected int _duration; // in seconds

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void SetDuration(int seconds)
    {
        _duration = seconds;
    }

    // Common starting message
    protected void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"🌟 Starting {_name} Activity 🌟");
        Console.WriteLine(_description);
        Console.WriteLine("Get ready...");
        PauseWithAnimation(3); // 3-second prep
    }

    // Common ending message
    protected void DisplayEndingMessage()
    {
        Console.WriteLine($"\n🎉 Well done! You completed {_name} for {_duration} seconds.");
        PauseWithAnimation(2);
    }

    // Simple spinner animation
    protected void PauseWithAnimation(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        for (int i = 0; i < seconds * 4; i++) // 4 steps per second
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(250);
            Console.Write("\b \b"); // erase previous character
        }
    }

    // Virtual Start method to override in derived classes
    public virtual void Start()
    {
        DisplayStartingMessage();
        DisplayEndingMessage();
    }
}
