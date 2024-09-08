using System;
using System.Diagnostics;

namespace Katas
{
    // Minimum difference between smallest and largest element when 3 substitutions allowed
    class Template : IRunTests
    {
        public int MethodUT(int param1)
        {
            return 0;
        }

        public void RunTests()
        {
            Debug.Assert(MethodUT(int.MaxValue) == 1, "Value is incorrect!");
        }
    }
}