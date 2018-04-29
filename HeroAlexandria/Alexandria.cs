using System;
using System.Collections.Generic;
using System.Text;

namespace HeroAlexandria
{
     
    public static class Alexandria
    {
        public const int LowerBound = 10;
        public const int UpperBound = 20000;

        private const double TOLERANCE = 1.0E-8;

        public static double FindRoot(double number)
        {
            double guess = 1;
            double error = Math.Abs(guess * guess - number);

            while (error > TOLERANCE)
            {
                guess = (number / guess + guess);
                error = Math.Abs(guess * guess - number);
            }
            return guess;
        }
    }
}
