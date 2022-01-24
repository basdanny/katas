using System;
using System.Diagnostics;
using System.Linq;


namespace Interview
{
    public class Anagram : IRunTests
    {

        /// <summary>
        /// anagram is a word or phrase formed by rearranging the letters of a different word or phrase
        /// </summary>        
        public bool IsAnagram(string input1, string input2)
        {
            return (input1.Length == input2.Length &&
                string.Concat(input1.OrderBy(c => c)) == string.Concat(input2.OrderBy(c => c)));
        }

        public bool IsAnagram2(string input1, string input2)
        {
            var orderedChars1 = input1.ToArray().OrderBy(c => c);
            var orderedChars2 = input2.ToArray().OrderBy(c => c);            
            
            return orderedChars1.SequenceEqual(orderedChars2);
        }


        public void RunTests()
        {
            Debug.Assert(IsAnagram("cat", "tac"));
            Debug.Assert(!IsAnagram("cat", "taco"));
            Debug.Assert(!IsAnagram("annabelle", "aanabelee"));

            Debug.Assert(IsAnagram2("cat", "tac"));
            Debug.Assert(!IsAnagram2("cat", "taco"));
            Debug.Assert(!IsAnagram2("annabelle", "aanabelee"));
        }
    }
}
