using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class Fibonacci
    {
        public static BigInteger FibonacciElementRecursive(int n)
        {
            if (n <= 1)
                return n;

            return FibonacciElementRecursive(n - 1) + FibonacciElementRecursive(n - 2);
        }

        public static BigInteger FibonacciElementRecursive(int n, Dictionary<int, BigInteger> memo=null)
        {
            if (memo == null)
                memo = new Dictionary<int, BigInteger>();

            if (n <= 1)
                return n;

            if (!memo.ContainsKey(n))
                memo[n] = FibonacciElementRecursive(n - 1, memo) + FibonacciElementRecursive(n - 2, memo);

            return memo[n];
        }


        public static BigInteger FibonacciElementIterative(int n)
        {
            BigInteger prev = 0;
            BigInteger curr = 1;

            for (int i = 2; i <= n; i++)
            {
                BigInteger temp = curr;
                curr = prev + curr;
                prev = temp;
            }

            return curr;
        }
    }
}
