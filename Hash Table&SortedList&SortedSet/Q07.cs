using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table_SortedList_SortedSet
{
    /*
        Manage Meeting Times for a Calendar
        Description: Automatically organize meeting times chronologically for a daily calendar.
     */
    class Meeting
    {
        public string MeetingName { get; set; }
        public string MeetingDay { get; set; }
        public TimeSpan MeetingTime { get; set; }

        public override string ToString()
            => $"\nMeetingName : {MeetingName} ,MeetingDay : {MeetingDay} ,MeetingTime : {MeetingTime}";
    }
    class MeetingComparer : IComparer<Meeting>
    {
        public int Compare(Meeting x, Meeting y)
        {
            if (x == null || y == null)
                throw new ArgumentNullException();

            int dayComparison = x.MeetingDay.CompareTo(y.MeetingDay);
            if (dayComparison != 0)
                return dayComparison;

            return x.MeetingTime.CompareTo(y.MeetingTime);
        }
    }

    public class Q07
    {
        public static void Question()
        {
            SortedSet<Meeting> MeetingTime = new SortedSet<Meeting>(new MeetingComparer())
        {
            new Meeting() { MeetingName = "Meeting1", MeetingDay = "Sat", MeetingTime = new TimeSpan(12, 0, 0) },
            new Meeting() { MeetingName = "Meeting2", MeetingDay = "Sun", MeetingTime = new TimeSpan(20, 30, 0) },
            new Meeting() { MeetingName = "Meeting3", MeetingDay = "Mon", MeetingTime = new TimeSpan(2, 0, 0) },
            new Meeting() { MeetingName = "Meeting4", MeetingDay = "Sat", MeetingTime = new TimeSpan(10, 0, 0) }
        };

            Console.WriteLine($"Next showtime::{string.Join("", MeetingTime)}");
        }
    }
}