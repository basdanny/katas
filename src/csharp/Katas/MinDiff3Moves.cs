using System;
using System.Diagnostics;
using System.Linq;

namespace Katas
{
    // Minimum difference between smallest and largest element when 3 substitutions allowed
    class MinDiff3Moves : IRunTests
    {
        public int MinDifference(int[] nums)
        {
            var n = nums.Length;            
            if(n <= 3)
                return 0;

            Array.Sort(nums);
            
            var firstMin = nums[0];
            var secondMin = nums[1];
            var thirdMin = nums[2];
            var FourthMin = nums[3];

            var firstMax = nums[n - 1];
            var secondMax = nums[n - 2];
            var thirdMax = nums[n - 3];
            var FourthMax = nums[n - 4];
            
            var result = Math.Min(
                Math.Min(
                    firstMax - FourthMin, //replace 3 min
                    FourthMax - firstMin  //replace 3 max
                ),
                Math.Min(
                    secondMax - thirdMin,  //replace 2 min 1 max
                    thirdMax - secondMin  //replace 1 min 2 max
                )
            );

            return result;
        }

        public void RunTests()
        {
            Console.WriteLine("Min diff: " + MinDifference([5, 3, 2, 4]));

            Debug.Assert(MinDifference([5, 3, 2, 4]) == 0);
            Debug.Assert(MinDifference([1, 5, 0, 10, 14]) == 1);
            Debug.Assert(MinDifference([3, 100, 20]) == 0);
        }
    }
}