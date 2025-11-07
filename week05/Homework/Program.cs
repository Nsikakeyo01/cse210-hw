using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your name, mindful student: ");
        string studentName = Console.ReadLine();

        while (true)
        {
            Console.Clear();
            Console.WriteLine($"\nWelcome, {studentName}! 🌟\n");
            Console.WriteLine("Choose your mindful assignment:");
            Console.WriteLine("1. Breathing Exercise");
            Console.WriteLine("2. Reflection Exercise");
            Console.WriteLine("3. Listing Exercise");
            Console.WriteLine("4. Quit");
            Console.Write("Choice: ");

            string choice = Console.ReadLine();
            MindfulAssignment assignment = choice switch
            {
                "1" => new BreathingAssignment(studentName, 20),
                "2" => new ReflectionAssignment(studentName, 20),
                "3" => new ListingAssignment(studentName, 20),
                "4" => null,
                _ => null
            };

            if (assignment == null) break;

            assignment.StartAssignment();
            Console.WriteLine("\nPress any key to return to the menu...");
            Console.ReadKey();
        }

        Console.WriteLine($"\nThanks for practicing mindfulness today, {studentName}! 🌸");
    }
}
