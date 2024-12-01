using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Dictionary_Hashset
{
    /*
        Track Unique Visitors to a Website
        Problem: Track unique visitors to a website using IP addresses.
     */
    public class Q06
    {
        private static string TrackVisitors(HashSet<string> Ips , string Ip)
        {
            return Ips.Add(Ip) ? $"New visitor : {Ip}" : $"Returning visitor: {Ip}";
        }

        public static void Question()
        {
            HashSet<string> Ips = new HashSet<string>();
            
            Console.WriteLine(TrackVisitors(Ips, "192.168.1.1"));
            Console.WriteLine(TrackVisitors(Ips, "192.168.1.2"));
            Console.WriteLine(TrackVisitors(Ips, "192.168.1.1"));

            Console.WriteLine("The Unique Visitors to a Website : ");
            foreach (var v in Ips)
            {
                Console.WriteLine(v);
            }
        }


    }
}
