using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace maxsumof2nums
{
    class Program
    {
        static void Main(string[] args)
        {
           var meetings = new List<MergingMeetingTimes>();
           meetings.Add( new MergingMeetingTimes(){ startTime = 1, endTime = 3});
           meetings.Add( new MergingMeetingTimes(){ startTime = 4, endTime = 6});
           meetings.Add( new MergingMeetingTimes(){ startTime = 5, endTime = 7});
           var mergedMeetings = MergeMeetings(meetings);

           foreach (var meeting in mergedMeetings)
           {
               Console.WriteLine(meeting.startTime + ", " + meeting.endTime);
           }
        }


        static List<MergingMeetingTimes> MergeMeetings(List<MergingMeetingTimes> meetings) 
        {
            if (meetings.Count() <= 1)
              return meetings;
            
            //sort the ranges
            // this can be also like
            // meetings.Select(m => new Meeting(m.StartTime, m.EndTime)).OrderBy(m => m.StartTime).ToList();

            var sortedMeetings = meetings.OrderBy(m => m.startTime).ToList();
            var mergeMeetingsRanges = new List<MergingMeetingTimes>();

            // merge the ranges
            // initialize the list with the first meeting time so it can be the first time to look up to merge it
            mergeMeetingsRanges.Add(sortedMeetings[0]);

            foreach (var meeting in sortedMeetings)            
            {
                var lastMergedMeeting = mergeMeetingsRanges.Last();
                if (lastMergedMeeting.startTime <= meeting.startTime && lastMergedMeeting.endTime >= meeting.startTime)
                {
                    lastMergedMeeting.endTime = meeting.endTime;
                }
                else
                {
                    mergeMeetingsRanges.Add(meeting);
                }
            }
            return mergeMeetingsRanges;
        }

        static int MaxSumof2Nums()
        {
           
            int[] a = new int[]{51,71,17,42};            
            Dictionary <int, List<int>> sums = new Dictionary<int, List<int>>();

            foreach(int i in a)
            {
                int sum = SumDigits(i);
                if (sums.ContainsKey(sum))
                {
                   sums[sum].Add(i);
                }
                else
                {
                    sums.Add(sum, new List<int>(){i});
                }
            }

            if (sums.Count > 0)
            {
                int maxSum = 0;
                foreach (KeyValuePair<int, List<int>> item in sums)
                {
                    int sum = PairNumbers(item.Value);
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }
                }
               return maxSum;
            }    

             return -1;

        }

        static int PairNumbers(List<int> numbers)
        {
            if (numbers.Count < 2)
               return -1;

            if (numbers.Count == 2)            
                return numbers.ElementAt(0) + numbers.ElementAt(1);            
                       
            int n1 = numbers.Max();            
            numbers.Remove(n1);
            return n1 + numbers.Max();
        }

        static int SumDigits(int number)
        {
            var strNumber = number.ToString();
            int sum = 0;
            foreach(char c in strNumber)
            {
                sum += CharUnicodeInfo.GetDecimalDigitValue(c);
            }            
            return sum;
        }
    }
}
