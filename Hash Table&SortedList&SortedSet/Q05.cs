using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table_SortedList_SortedSet
{
    /*
       Automatically Sort Event Timelines
      Description: Maintain a sorted timeline of events by their occurrence times to show the upcoming ones first.
     */
    class Event
    {
        public string EventName { get; set; }
        public DateTime EventTime { get; set; }

        public override string ToString()
         => $"\n Name : {EventName,-15} ,EventTime : {EventTime}";
    }
    public class Q05
    {

        public static void Question()
        {
            SortedSet<Event> eventTimeline = new SortedSet<Event>(
                Comparer<Event>.Create((x, y) => x.EventTime.CompareTo(y.EventTime)))
                {
                    new Event(){EventName ="Christmas",EventTime= new DateTime(2024, 12, 25) },
                    new Event(){EventName= "Thanksgiving",EventTime= new DateTime(2024, 11, 30) },
                    new Event(){EventName="New Year",EventTime= new DateTime(2025, 1, 1) }
                };

            Console.WriteLine($"Upcoming events: {string.Join("", eventTimeline)}");
        }
    }
}
