using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;

namespace Interview
{
    class Fibonacci : IRunTests
    {
        public BigInteger FibonacciElementRecursive(int n)
        {
            if (n <= 1)
                return n;

            return FibonacciElementRecursive(n - 1) + FibonacciElementRecursive(n - 2);
        }

        public BigInteger FibonacciElementRecursive(int n, Dictionary<int, BigInteger> memo = null)
        {
            if (memo == null)
                memo = new Dictionary<int, BigInteger>();

            if (n <= 1)
                return n;

            if (!memo.ContainsKey(n))
                memo[n] = FibonacciElementRecursive(n - 1, memo) + FibonacciElementRecursive(n - 2, memo);

            return memo[n];
        }


        public BigInteger FibonacciElementIterative(int n)
        {
            if (n <= 1)
                return n;

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


        public void RunTests()
        {
            Debug.Assert(0 == FibonacciElementRecursive(0));
            Debug.Assert(1 == FibonacciElementRecursive(1));
            Debug.Assert(8 == FibonacciElementRecursive(6));

            Debug.Assert(0 == FibonacciElementRecursive(0, null));
            Debug.Assert(1 == FibonacciElementRecursive(1, null));
            Debug.Assert(8 == FibonacciElementRecursive(6, null));

            Debug.Assert(0 == FibonacciElementIterative(0));
            Debug.Assert(1 == FibonacciElementIterative(1));
            Debug.Assert(8 == FibonacciElementIterative(6));


            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //BigInteger result = FibonacciElementRecursive(36);
            //sw.Stop();
            //Console.WriteLine("Fibonacci Element Recursive:\t" + result + "\t Elapsed time in milli: " + sw.ElapsedMilliseconds);

            //sw.Restart();
            //result = FibonacciElementRecursive(36, null);
            //sw.Stop();
            //Console.WriteLine("Recursive + Memoization:\t" + result + "\t Elapsed time in milli: " + sw.ElapsedMilliseconds);

            //sw.Restart();
            //result = FibonacciElementIterative(36);
            //sw.Stop();
            //Console.WriteLine("Fibonacci Element Iterative:\t" + result + "\t Elapsed time in milli: " + sw.ElapsedMilliseconds);
        }
    }
}
