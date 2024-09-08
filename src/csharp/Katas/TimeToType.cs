using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Katas
{    
    /// <summary>
    /// Given a string keyboard that describe the keyboard layout and a string text, return an integer denoting the time taken to type string text.
    /// The time taken to move your finger from index i to index j is abs(j - i).
    /// </summary>
    class TimeToType : IRunTests
    {
        public int GetTimeToString(string keyboard, string text)
        {
            var dic = new Dictionary<char, int>();
            for (int i = 0; i < keyboard.Length; i++)
            {
                dic.Add(keyboard[i], i);
            }

            var currentPosition = 0;
            var timeTostring = 0;
            foreach (var c in text)
            {
                timeTostring += Math.Abs(dic[c] - currentPosition);
                currentPosition = dic[c];
            }

            return timeTostring;
        }

        public void RunTests()
        {
            Debug.Assert(GetTimeToString(keyboard: "abcdefghijklmnopqrstuvwxy", text: "cba") == 4, "GetTimeToString is incorrect!");
            Debug.Assert(GetTimeToString(keyboard: "abcdefghijklmnopqrstuvwxy", text: "y") == 24, "GetTimeToString is incorrect!");
        }
    }
}
