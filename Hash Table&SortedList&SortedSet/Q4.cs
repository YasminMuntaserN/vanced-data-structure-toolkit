using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table_SortedList_SortedSet
{
    /*
       Track Unique Active Users by Login Time
       Description: Maintain a list of unique active users by their login times, and automatically sort them in chronological order.
     */
    class User
    {
        public string UserName { get; set; }
        public DateTime LoginTime { get; set; }

        public override string ToString()
        {
            return $"\n Name : {UserName} ,LoggingTime : {LoginTime}";
        }
    }
    class UserComparer : IComparer<User>
    {
        public int Compare(User x, User y)
        {
            if (x == null || y == null)
                throw new ArgumentNullException();

            // First, compare by UserName to ensure uniqueness
            int nameComparison = x.UserName.CompareTo(y.UserName);
            if (nameComparison == 0)
                return nameComparison;


            // If names are the same, compare by LoginTime to keep the most recent one
            var timeComparison = y.LoginTime.CompareTo(x.LoginTime);
            return timeComparison;
        }
    }


    public class Q4
    {

        public static void Question()
        {
            SortedSet<User> ActiveUsers = new SortedSet<User>(new UserComparer());

            Console.WriteLine($"User1 first logging At {DateTime.Now}.....");
            ActiveUsers.Add(new User() { UserName = "User1", LoginTime = DateTime.Now });


            Console.WriteLine($"User2 first logging At {DateTime.Now}.....");
            ActiveUsers.Add(new User() { UserName = "User2", LoginTime = DateTime.Now });


            Console.WriteLine($"User3 first logging At {DateTime.Now}.....");
            ActiveUsers.Add(new User() { UserName = "User3", LoginTime = DateTime.Now });

            Console.WriteLine($"User1 logged Again At {DateTime.Now.AddHours(5)}.....");
            ActiveUsers.Add(new User() { UserName = "User1", LoginTime = DateTime.Now.AddHours(5) });

            Console.WriteLine($"User3 logged Again At {DateTime.Now.AddDays(2)}.....");
            ActiveUsers.Add(new User() { UserName = "User3", LoginTime = DateTime.Now.AddDays(2) });

            Console.WriteLine($"\nAll Users Loging: {string.Join(", ", ActiveUsers)}");
        }
    }
}
