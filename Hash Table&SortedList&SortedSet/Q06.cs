using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table_SortedList_SortedSet
{
    /*
      Organize Movie Showtimes
      Description: Store and sort movie showtimes to display the next available slot.
     */
    class Movie
    {
        public string MovieName { get; set; }
        public DateTime MovieTime { get; set; }

        public override string ToString()
         => $"\n Name : {MovieName,-15} ,MovieTime : {MovieTime}";
    }
    public class Q06
    {

        public static void Question()
        {
            SortedSet<Movie> MovieTimeline = new SortedSet<Movie>(
                Comparer<Movie>.Create((x, y) => x.MovieTime.CompareTo(y.MovieTime)))
                {
                    new Movie(){MovieName ="Movie1",MovieTime= new DateTime(2024, 12, 25) },
                    new Movie(){MovieName= "Movie2",MovieTime= new DateTime(2024, 11, 30) },
                    new Movie(){MovieName="Movie3",MovieTime= new DateTime(2025, 1, 1) }
                };

            Console.WriteLine("Next showtime: " + MovieTimeline.Min);

            Console.WriteLine($"Next showtime:: {string.Join("", MovieTimeline)}");
        }
    }
}
