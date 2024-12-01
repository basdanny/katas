using System;
using System.Diagnostics;
using System.Numerics;

namespace Katas
{
    /// <summary>
    /// Calculate (1 / n!) * (1! + 2! + 3! + ... + n!) for a given n, where n is an integer greater or equal to 1.    
    /// </summary>

    class Factorial : IRunTests
    {
        /*
            Pattern using n=4

            (1 / 1*2*3*4) * (1 + 1*2 + 1*2*3 + 1*2*3*4)
            
             1 + 1*2 + 1*2*3 + 1*2*3*4
             -------------------------
                     1*2*3*4
            
                1        1*2      1*2*3    1*2*3*4
             ------- + ------- + ------- + -------
             1*2*3*4   1*2*3*4   1*2*3*4   1*2*3*4
            
               1      1    1   1
             ----- + --- + - + -
             2*3*4   3*4   4   1
            
                 1    1      1
             1 + - + --- + -----
                 4   4*3   4*3*2

        */

        public double GetSpecialFactorial(int n)
        {
            var precision = 0.000001;
            var result = 0d;
            var factor = 1d;
            for (int i = n; i > 0 && factor > precision; i--)
            {
                result += factor;
                factor /= i;
            }
            
            return result;
        }

        public void RunTests()
        {
            var precision = 0.000001;

            Debug.Assert(Math.Abs(GetSpecialFactorial(5) - 1.275) < precision, "GetSpecialFactorial is incorrect: " + GetSpecialFactorial(5));
            Debug.Assert(Math.Abs(GetSpecialFactorial(6) - 1.2125) < precision, "GetSpecialFactorial is incorrect: " + GetSpecialFactorial(6));
            Debug.Assert(Math.Abs(GetSpecialFactorial(7) - 1.173214) < precision, "GetSpecialFactorial is incorrect: " + GetSpecialFactorial(7));
            Debug.Assert(Math.Abs(GetSpecialFactorial(300) - 1.003344) < precision, "GetSpecialFactorial is incorrect: " + GetSpecialFactorial(300));
        }
    }
}