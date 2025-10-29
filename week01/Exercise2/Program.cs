using System;

class Program
{
    static void Main()
    {
        // Ask the user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();

        // Convert the input to an integer
        int gradePercentage = int.Parse(input);

        // Declare variables for the letter and sign
        string letter = "";
        string sign = "";

        // Determine the letter grade
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Stretch Challenge: determine the + or - sign
        int lastDigit = gradePercentage % 10;

        if (letter != "A" && letter != "F")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (letter == "A" && gradePercentage < 93)
        {
            sign = "-";
        }
        // F grades have no + or - sign

        // Display the final grade
        Console.WriteLine();
        Console.WriteLine($"Your grade is: {letter}{sign}");

        // Determine pass/fail message
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }
        else
        {
            Console.WriteLine("Keep trying—you’ll do better next time!");
        }
    }
}
