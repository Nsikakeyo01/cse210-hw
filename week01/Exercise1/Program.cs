using System;

class Program
{
    static void Main()
    {
        // Prompt for the user's first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Prompt for the user's last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Display the output in the specified format
        Console.WriteLine();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}
