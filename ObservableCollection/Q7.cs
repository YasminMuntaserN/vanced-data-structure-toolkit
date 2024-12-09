using ObservableCollection;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservableCollection
{
    /*
        Real-Time Notification System
        Problem: Display notifications about your order dynamically as they arrive.
     */

    public class Q7
    {
        public static void Question()
        {
            ObservableCollection<int> ob = new ObservableCollection<int>();

            ob.CollectionChanged += (sender, e) =>
            {
                if (e.Action == NotifyCollectionChangedAction.Add)
                {
                        Console.WriteLine($"The order with number {e.NewItems[0]} has finished. You can pick it up! :)");
                }
            };

            for (int i = 1; i <= 5; i++)
            {
                Task.Delay(1000).Wait();
                ob.Add(i);
            }
        }
    }
}