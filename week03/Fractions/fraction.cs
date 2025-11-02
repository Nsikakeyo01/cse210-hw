using System;

namespace NsikakEyo.FractionApp
{
    public class Fraction
    {
        // Private member variables (Encapsulation)
        private int _numerator;
        private int _denominator;

        // Default constructor: 1/1
        public Fraction()
        {
            _numerator = 1;
            _denominator = 1;
        }

        // Constructor with one parameter (numerator only)
        public Fraction(int numerator)
        {
            _numerator = numerator;
            _denominator = 1;
        }

        // Constructor with two parameters
        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be zero, Nsikak!");
            }

            _numerator = numerator;
            _denominator = denominator;
            Simplify(); // auto simplify fractions like 6/8 → 3/4
        }

        // Getters
        public int GetNumerator() => _numerator;
        public int GetDenominator() => _denominator;

        // Setters
        public void SetNumerator(int numerator)
        {
            _numerator = numerator;
            Simplify();
        }

        public void SetDenominator(int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be zero, Nsikak!");
            }

            _denominator = denominator;
            Simplify();
        }

        // Method: Returns fraction as a string (e.g., "3/4")
        public string GetFractionString()
        {
            return $"{_numerator}/{_denominator}";
        }

        // Method: Returns decimal value of the fraction
        public double GetDecimalValue()
        {
            return Math.Round((double)_numerator / _denominator, 6);
        }

        // Private helper: Simplify the fraction (unique feature)
        private void Simplify()
        {
            int gcd = GCD(Math.Abs(_numerator), Math.Abs(_denominator));
            _numerator /= gcd;
            _denominator /= gcd;
        }

        // Helper: Compute greatest common divisor (Euclidean Algorithm)
        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
