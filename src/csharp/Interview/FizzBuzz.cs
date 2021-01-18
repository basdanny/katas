using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class FizzBuzz
    {
        public static void FizzBuzzPrint(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                bool fizzbuzz = false;
                if (i % 3 == 0)
                {
                    Console.Write("Fizz");
                    fizzbuzz = true;
                }
                if (i % 5 == 0)
                {
                    Console.Write("Buzz");
                    fizzbuzz = true;
                }

                if (fizzbuzz)
                    Console.WriteLine();
                else
                    Console.WriteLine(i);

            }
        }
    }
}
