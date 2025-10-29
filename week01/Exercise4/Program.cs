using System;
using System.Collections.Generic;  // Needed to use Lists

class Program
{
    static void Main()
    {
        // Create a new list to store the numbers
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Step 1: Collect numbers from the user
        while (true)
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);

            if (number == 0)
            {
                break; // Stop input when the user enters 0
            }

            numbers.Add(number);
        }

        // Step 2: Compute the sum
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        // Step 3: Compute the average
        float average = ((float)sum) / numbers.Count;

        // Step 4: Find the largest number
        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        // -------------------------------
        // STRETCH CHALLENGES
        // -------------------------------

        // Step 5: Find the smallest positive number
        int smallestPositive = int.MaxValue;
        bool hasPositive = false;

        foreach (int num in numbers)
        {
            if (num > 0 && num < smallestPositive)
            {
                smallestPositive = num;
                hasPositive = true;
            }
        }

        if (hasPositive)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("There are no positive numbers.");
        }

        // Step 6: Sort the list and display it
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
