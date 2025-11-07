using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing",
        "Relax your mind by slowly inhaling and exhaling. Focus only on your breath.")
    { }

    public override void Start()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            Countdown(4);
            Console.Write("Breathe out... ");
            Countdown(6);
        }

        DisplayEndingMessage();
    }

    private void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
