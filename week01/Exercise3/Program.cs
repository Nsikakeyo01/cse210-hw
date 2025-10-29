using System;

class Program
{
    static void Main()
    {
        // Create a random number generator
        Random randomGenerator = new Random();

        string playAgain = "yes";

        // Loop the whole game while the user wants to play again
        while (playAgain.ToLower() == "yes")
        {
            // Generate a random magic number between 1 and 100
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1; // initialize guess to something not equal to magic number
            int guessCount = 0; // track number of guesses

            Console.WriteLine("I have chosen a magic number between 1 and 100.");
            Console.WriteLine();

            // Repeat until user guesses the correct number
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string guessInput = Console.ReadLine();
                guess = int.Parse(guessInput);
                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it in {guessCount} tries!");
                }
            }

            Console.WriteLine();
            Console.Write("Do you want to play again (yes/no)? ");
            playAgain = Console.ReadLine();
            Console.WriteLine();
        }

        Console.WriteLine("Thanks for playing! Goodbye!");
    }
}
