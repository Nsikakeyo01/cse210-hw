using System;
using NsikakEyo.FractionApp;

namespace NsikakEyo.FractionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=============================================");
            Console.WriteLine("     Nsikak Eyo’s Fraction Encapsulation App  ");
            Console.WriteLine("=============================================\n");
            Console.ResetColor();

            try
            {
                // Demonstrate all constructors
                DisplayFraction(new Fraction());          // 1/1
                DisplayFraction(new Fraction(5));         // 5/1
                DisplayFraction(new Fraction(3, 4));      // 3/4
                DisplayFraction(new Fraction(6, 8));      // Simplifies to 3/4
                DisplayFraction(new Fraction(1, 3));      // 1/3

                // Demonstrate getters and setters
                Fraction custom = new Fraction(2, 5);
                Console.WriteLine("\nOriginal Fraction:");
                DisplayFraction(custom);

                custom.SetNumerator(10);
                custom.SetDenominator(25);
                Console.WriteLine("\nAfter Using Setters (Auto Simplified):");
                DisplayFraction(custom);

                // Intentional error test
                Console.WriteLine("\nTesting Exception Handling:");
                try
                {
                    Fraction invalid = new Fraction(2, 0);
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"⚠️ Error: {ex.Message}");
                    Console.ResetColor();
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n✅ Program completed successfully!");
                Console.ResetColor();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Unexpected error: {e.Message}");
                Console.ResetColor();
            }
        }

        // Helper to display fraction info
        static void DisplayFraction(Fraction f)
        {
            Console.WriteLine($"Fraction: {f.GetFractionString()}");
            Console.WriteLine($"Decimal : {f.GetDecimalValue()}");
            Console.WriteLine();
        }
    }
}
