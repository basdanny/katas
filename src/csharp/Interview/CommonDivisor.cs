using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class CommonDivisor
    {        
        ///GCD - common greatest divisor of two numbers
        ///Time Complexity: O(min(number1, number2))
        public static int GetGreatestCommonDivisor(int number1, int number2)
        {
            int result = 1;
            for (int i = 2; i <= Math.Min(number1, number2); i++)
            {
                if (number1 % i == 0 && number2 % i == 0)
                    result = i;
            }
            return result;
        }


        ///GCD - common greatest divisor of two numbers
        ///Time Complexity: O(max(number1, number2))
        public static int GetGreatesCommonDivisorEuclidean(int number1, int number2)
        {
            while (number1 != number2)
            {
                if (number1 > number2)
                    number1 = number1 - number2;
                else
                    number2 = number2 - number1;
            }
            return number1;
        }

        ///LCM - the smallest positive integer that is divisible by both number1 and number2
        ///Time Complexity: O(min(number1, number2))
        public static int GetLeastCommonMultiple(int number1, int number2)
        {
            var lcm = (number1 * number2) / GetGreatestCommonDivisor(number1, number2);
            return lcm;
        }

        public static int GetLeastCommonMultiple2(int a, int b)
        {
            int num1, num2;
            if (a > b)
            {
                num1 = a; 
                num2 = b;
            }
            else
            {
                num1 = b; 
                num2 = a;
            }

            for (int i = 1; i < num2; i++)
            {
                int mult = num1 * i;
                if (mult % num2 == 0)
                {
                    return mult;
                }
            }
            return num1 * num2;
        }

    }
}
