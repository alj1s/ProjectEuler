
using System;
using System.Collections.Generic;
using System.Linq;
using Common;

namespace Problems
{
    public class Problem33 : IProblem
    {
        public string Solve()
        {

            var range = Enumerable.Range(10, 89);

            var fractions = from denom in range
                            from num in range
                            where num < denom
                            select new Fraction(num, denom);

            var result = new Fraction(1, 1);

            foreach (var fraction in fractions)
            {
                if (CanCancelGigits(fraction))
                {
                    if (CancelDigits(fraction) == fraction)
                    {
                        result *= fraction;
                    }
                }
            }



            return result.InLowestTerms().Denominator.ToString();

        }

        private bool CanCancelGigits(Fraction fraction)
        {
            return fraction.Numerator % 10 != 0 && fraction.Denominator % 10 != 0 
                && (
                      fraction.Numerator.GetNthDigit(1) == fraction.Denominator.GetNthDigit(1)
                   || fraction.Numerator.GetNthDigit(1) == fraction.Denominator.GetNthDigit(2)
                   || fraction.Numerator.GetNthDigit(2) == fraction.Denominator.GetNthDigit(2)
                   || fraction.Numerator.GetNthDigit(2) == fraction.Denominator.GetNthDigit(1)
                   );

        }

        private Fraction CancelDigits(Fraction fraction)
        {

            if (fraction.Numerator.GetNthDigit(1) == fraction.Denominator.GetNthDigit(1))
                return new Fraction(fraction.Numerator.GetNthDigit(2), fraction.Denominator.GetNthDigit(2));

            if (fraction.Numerator.GetNthDigit(1) == fraction.Denominator.GetNthDigit(2))
                return new Fraction(fraction.Numerator.GetNthDigit(2), fraction.Denominator.GetNthDigit(1));

            if (fraction.Numerator.GetNthDigit(2) == fraction.Denominator.GetNthDigit(2))
                return new Fraction(fraction.Numerator.GetNthDigit(1), fraction.Denominator.GetNthDigit(1));

            return new Fraction(fraction.Numerator.GetNthDigit(1), fraction.Denominator.GetNthDigit(2));

        }

        class Fraction
        {
            public int Numerator { get; private set; }
            public int Denominator { get; private set; }

            public Fraction(int numerator, int dencminator)
            {
                Numerator = numerator;
                Denominator = dencminator;
            }

            public override string ToString()
            {
                return Numerator + "/" + Denominator;
            }

            public static bool operator ==(Fraction a, Fraction b)
            {
                return a.Numerator * b.Denominator == a.Denominator * b.Numerator;
            }

            public static bool operator !=(Fraction a, Fraction b)
            {
                return !(a == b);
            }

            public static Fraction operator *(Fraction a, Fraction b)
            {
                return new Fraction(a.Numerator * b.Numerator, a.Denominator * b.Denominator);
            }

            public Fraction InLowestTerms()
            {
                var gcd = Numerator.Gcd(Denominator);

                return new Fraction(Numerator/gcd, Denominator/gcd);
            }
        }
    }
}

