using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    // Given an array of meeting times intervals [[10, 20], [5, 12]...] find the minimum number of conference rooms required.
    class MeetingRooms : IRunTests
    {
        public class Interval
        {
            public int start;
            public int end;
            public Interval() { start = 0; end = 0; }
            public Interval(int s, int e) { start = s; end = e; }
        }

        public int MinMeetingRooms(Interval[] intervals)
        {
            int n = intervals.Count();
            if (intervals == null || n == 0)
                return 0;

            var orderedStarts = intervals.Select(i => i.start).OrderBy(s => s).ToArray();
            var orderedEnds = intervals.Select(i => i.end).OrderBy(s => s).ToArray();

            int i = 0;
            int j = 0;
            int rooms = 0;
            int totalRooms = 0;
            while (i < n && j < n)
            {
                if (orderedStarts[i] < orderedEnds[j])
                {
                    rooms++;
                    i++;
                }
                else
                {
                    rooms--;
                    j++;
                }
                
                totalRooms = Math.Max(totalRooms, rooms);
            }
            
            return totalRooms;
        }
        public void RunTests()
        {
            Interval[] intervals = new Interval[] { new Interval(0, 30), new Interval(5, 10), new Interval(15, 20) };
            var result = MinMeetingRooms(intervals);
            //Console.WriteLine("Min rooms: " + result);
            Debug.Assert(result == 2);

            Interval[] intervals2 = new Interval[] { new Interval(2, 4), new Interval(3, 50), new Interval(5, 40), new Interval(6, 45) };
            var result2 = MinMeetingRooms(intervals2);
            //Console.WriteLine("Min rooms: " + result2);
            Debug.Assert(result2 == 3);
        }
    }
}
