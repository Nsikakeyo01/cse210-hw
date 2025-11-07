using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("🧘 Mindfulness Program 🧘\n");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an activity: ");

            string choice = Console.ReadLine();
            Activity activity = choice switch
            {
                "1" => new BreathingActivity(),
                "2" => new ReflectionActivity(),
                "3" => new ListingActivity(),
                "4" => null,
                _ => null
            };

            if (activity == null) break;

            Console.Write("Enter duration in seconds: ");
            if (int.TryParse(Console.ReadLine(), out int duration))
            {
                activity.SetDuration(duration);
                activity.Start();
            }
            else
            {
                Console.WriteLine("Invalid input. Press any key to return to menu...");
                Console.ReadKey();
            }
        }

        Console.WriteLine("\nThank you for using the Mindfulness Program! 🌟");
    }
}
