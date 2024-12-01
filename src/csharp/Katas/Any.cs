using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Katas
{
    public class Any : IRunTests
    {

        /// <summary>
        /// subtracts one list from another and returns the result.
        /// </summary>        
        public int[] ArrayDiff(int[] a, int[] b)
        {
            var uniqueDiffSet = new HashSet<int>(a.Except(b));
            var result = new List<int>();
            foreach (var item in a)
            {
                if (uniqueDiffSet.Contains(item))
                    result.Add(item);
            }

            return result.ToArray();
        }

        public int[] ArrayDiff2(int[] a, int[] b)
        {
            var bUniqueSet = b.ToHashSet();
            var result = new List<int>();
            foreach (var item in a)
            {
                if (!bUniqueSet.Contains(item))
                    result.Add(item);
            }

            return result.ToArray();
        }

        public string CapsWords(string phrase)
        {
            StringBuilder result = new StringBuilder(phrase);
            for (int i = 0; i < phrase.Length; i++)
            {
                if ((i == 0 || phrase[i - 1] == ' ') && !Char.IsUpper(phrase[i]))
                    result[i] = Char.ToUpper(phrase[i]);
            }

            return result.ToString();
        }

        public string CapsWords2(string phrase)
        {
            return String.Join(" ",
                phrase.Split().Select(i => Char.ToUpper(i[0]) + i.Substring(1)));
        }

        public int DigitalRoot(long n)
        {
            var result = n;
            while (result > 9)
            {
                long sum;
                for (sum = 0; result > 0; sum += result % 10, result /= 10) ;

                result = sum;
            }
            return (int)result;
        }

        /// <summary>
        /// A sentence using every letter of a given alphabet at least once
        /// </summary>                
        public static bool IsPangram(string str)
        {
            List<char> characters = new List<char>();
            for (char c = 'a'; c <= 'z'; c++)
                characters.Add(c);

            foreach (var letter in str)
            {
                characters.Remove(Char.ToLower(letter));
                if (characters.Count <= 0)
                    return true;
            }

            return false;
        }

        public static string StripComments(string text, string[] commentSymbols)
        {
            return string.Join("\n",
                text.Split("\n").Select(line => line.Split(commentSymbols, StringSplitOptions.None)[0].TrimEnd()));
        }

        public static string ToBase64(string s)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(s);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string FromBase64(string s)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(s);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public static int SumOfMultiplesOf3and5(int value)
        {
            if (value <= 2) return 0;

            var result = 0;
            for (int i = 1; i < value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    result += i;
            }
            return result;
        }


        public void RunTests()
        {
            //Array.ForEach(ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 1 }), Console.WriteLine);
            Debug.Assert(Enumerable.SequenceEqual(ArrayDiff(new int[] { 1, 2 }, new int[] { 1 }), new int[] { 2 }));
            Debug.Assert(Enumerable.SequenceEqual(new int[] { 2, 2 }, ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 1 })));
            Debug.Assert(Enumerable.SequenceEqual(new int[] { 1 }, ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 2 })));
            Debug.Assert(Enumerable.SequenceEqual(new int[] { 1, 2, 2 }, ArrayDiff(new int[] { 1, 2, 2 }, new int[] { })));
            Debug.Assert(Enumerable.SequenceEqual(new int[] { }, ArrayDiff(new int[] { }, new int[] { 1, 2 })));
            Debug.Assert(Enumerable.SequenceEqual(new int[] { 3 }, ArrayDiff(new int[] { 1, 2, 3 }, new int[] { 1, 2 })));

            Debug.Assert("A Cat Walked Funny A" == CapsWords("a cat walked funny a"));
            Debug.Assert("A Cat Walked Funny A" == CapsWords2("a cat walked funny a"));

            Debug.Assert(IsPangram("abra kadabra") == false);
            Debug.Assert(IsPangram("The quick brown fox jumps over the lazy dog"));

            Debug.Assert("a\nc\nd" == StripComments("a #b\nc\nd $e f g", new string[] { "#", "$" }));


            Debug.Assert(ToBase64("this is a string!!") == "dGhpcyBpcyBhIHN0cmluZyEh");
            Debug.Assert(FromBase64("dGhpcyBpcyBhIHN0cmluZyEh") == "this is a string!!");
        }
    }
}
