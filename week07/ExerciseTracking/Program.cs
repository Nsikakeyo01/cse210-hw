using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> myActivities = new List<Activity>
        {
            new Running("11 Nov 2025", 30, 3.0),
            new Cycling("11 Nov 2025", 45, 12.0),
            new Swimming("11 Nov 2025", 60, 40)
        };

        foreach (var activity in myActivities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
