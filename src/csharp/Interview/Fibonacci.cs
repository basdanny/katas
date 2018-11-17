using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class Fibonacci
    {
        public static int FibonacciElementRecursive(int n)
        {
            if (n <= 1)
                return n;

            return FibonacciElementRecursive(n - 1) + FibonacciElementRecursive(n - 2);
        }


        public static void PrintFibonacciIterative(int n)
        {            
            int prev = 1;            
            int curr = 1;

            Console.Write(prev + " ");
            Console.Write(curr + " ");

            for (int i = 3; i <= n; i++)
            {
                int temp = curr;
                curr = prev + curr;
                prev = temp;

                Console.Write(curr + " ");
            }
        }
    }
}
