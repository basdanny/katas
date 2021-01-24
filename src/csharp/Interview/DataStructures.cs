using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class DataStructures
    {
        public static void Play()
        {

            int[] array = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine($"array: {string.Join(",", array)}");
            var descArray = array.OrderByDescending(i => i).ToArray();
            Console.WriteLine($"desc array: {string.Join(",", descArray)}");


            var matrix = new int[,] {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };
            //Console.WriteLine($"matrix: {string.Join(",", matrix.Cast<int>())}");
            Console.WriteLine("matrix:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write("{0} ", matrix[i, j]);
                Console.WriteLine();
            }

            var list = new List<string>() { "a", "b", "c" };
            Console.WriteLine($"list: {string.Join(",", list)}");
            var descList = list.OrderByDescending(i => i).ToList();
            Console.WriteLine($"desc list: {string.Join(",", descList)}");

            var queue = new Queue<string>();
            queue.Enqueue("a");
            queue.Enqueue("b");
            Console.WriteLine($"queue: {string.Join(",", queue)}");


            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            Console.WriteLine($"stack: {string.Join(",", stack)}");


            var dic = new Dictionary<int, string>() { { 1, "a" }, { 2, "b" } };
            Console.WriteLine($"dic: {string.Join(",", dic)}");


            int numProcs = Environment.ProcessorCount;
            int concurrencyLevel = numProcs * 2;
            var concurrentDic = new ConcurrentDictionary<int, string>(numProcs, concurrencyLevel);
            concurrentDic[1] = "a";
            concurrentDic[2] = "b";
            Console.WriteLine($"concurrentDic: {string.Join(",", concurrentDic)}");


            var set = new HashSet<string>() { "a", "b", "c", "d" };       
            Console.WriteLine($"hashSet: {string.Join(",", set)}");

            Console.WriteLine(String.Format("{0:0.000000}", ((decimal)1/5)));
                      
        }


    }
}
