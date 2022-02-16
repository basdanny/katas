using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


namespace Interview
{
    public class LRUCache : IRunTests
    {
        private int CACHE_SIZE = 4;
        private LinkedList<int> linkedList = new LinkedList<int>();
        private HashSet<int> cacheSet = new HashSet<int>();

        public void Get(int value)
        {
            if (!cacheSet.Contains(value))
            {
                cacheSet.Add(value);

                //remove last when the cache is full
                if (linkedList.Count >= CACHE_SIZE)
                {
                    var last = linkedList.Last();
                    cacheSet.Remove(last);
                    linkedList.RemoveLast();
                }
            }
            else
            {
                //removing cached item in some location as it will be added as first later-on                
                linkedList.Remove(value);
            }

            linkedList.AddFirst(value);
        }

        public void Print()
        {
            for (var node = linkedList.First; node != null; node = node.Next)
                Console.Write(node.Value + ",");
            Console.WriteLine();
        }

        public void RunTests()
        {
            this.Get(1);
            this.Get(2);
            this.Get(3);
            this.Get(4);
            this.Get(1);
            this.Get(4);            
            this.Get(3);
            this.Get(3);
            this.Print();
            
            Debug.Assert(Enumerable.SequenceEqual(new int[] { 3, 4, 1, 2 }, linkedList.ToArray()));
        }
    }
}
