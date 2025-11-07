using System;

public class BreathingAssignment : MindfulAssignment
{
    public BreathingAssignment(string studentName, int duration)
        : base(studentName, "Breathing Exercise", duration)
    { }

    public override void StartAssignment()
    {
        Console.WriteLine(GetSummary());
        Console.WriteLine("🌬️ Let's breathe deeply. Follow along!");
        AnimatePause(2);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            Countdown(4);
            Console.Write("Breathe out... ");
            Countdown(6);
        }

        Console.WriteLine("💖 Well done! You feel more relaxed.");
        AnimatePause(2);
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
