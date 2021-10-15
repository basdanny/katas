using System.Diagnostics;
using System.Linq;


namespace Interview
{
    public class Anagram : IRunTests
    {

        public bool IsAnagram(string input1, string input2)
        {
            return (input1.Length == input2.Length &&
                new string(input1.OrderBy(c => c).ToArray()) == new string(input2.OrderBy(c => c).ToArray()));            
        }


        public void RunTests()
        {
            Debug.Assert(IsAnagram("cat", "tac"));
            Debug.Assert(!IsAnagram("cat", "taco"));
            Debug.Assert(!IsAnagram("annabelle", "aanabelee"));
        }
    }
}
