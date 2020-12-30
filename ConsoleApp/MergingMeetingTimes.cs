using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    public class Meeting
    {
        public int StartTime { get; set; }

        public int EndTime { get; set; }

        public Meeting(int startTime, int endTime)
        {
            // Number of 30 min blocks past 9:00 am
            StartTime = startTime;
            EndTime = endTime;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            if (ReferenceEquals(obj, this))
            {
                return true;
            }

            var meeting = (Meeting)obj;
            return StartTime == meeting.StartTime && EndTime == meeting.EndTime;
        }

        public override int GetHashCode()
        {
            var result = 17;
            result = result * 31 + StartTime;
            result = result * 31 + EndTime;
            return result;
        }

        public override string ToString()
        {
            return $"({StartTime}, {EndTime})";
        }
    }

    public static class MergingMeetingTimes {
    //Takes O(n log n) but beats double for loop usage that takes O(n^2)
    public static List<Meeting> MergeRanges(List<Meeting> meetings)
    {
        meetings.Sort((x, y) => x.StartTime.CompareTo(y.StartTime));
        int index = 0;
        
        while (index < meetings.Count-1) {
            var meeting = meetings[index];
            var compare = meetings[index+1];
            if (compare.StartTime >= meeting.StartTime 
                    && compare.StartTime <= meeting.EndTime) {
                        if (compare.EndTime > meeting.EndTime) {
                            meetings[index] = new Meeting(meeting.StartTime, compare.EndTime);
                            meetings.Remove(compare);
                        }
                        else if (compare.EndTime <= meeting.EndTime) {
                            meetings.Remove(compare);
                        }
            }
            else {
                index++;
            }
        }
        return meetings;
    }
}
}