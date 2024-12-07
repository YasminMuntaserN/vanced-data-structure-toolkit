using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservableCollection
{
    public class MyObservableCollection<T> : ObservableCollection<T>
    {
        public Action<object, NotifyCollectionChangedEventArgs>? CustomAction { get; set; }

        public MyObservableCollection()
        {
            this.CollectionChanged += Items_CollectionChanged;
        }

        private void Items_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (CustomAction != null)
            {
                CustomAction(sender, e);
                return;
            }

            Console.WriteLine("\nCollection Changed:");
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Console.WriteLine("Added:");
                    foreach (var newItem in e.NewItems)
                    {
                        Console.WriteLine("- " + newItem.ToString());
                    }

                    break;

                case NotifyCollectionChangedAction.Remove:
                    Console.WriteLine("Removed:");
                    foreach (var oldItem in e.OldItems)
                    {
                        Console.WriteLine("- " + oldItem.ToString());
                    }

                    break;

                case NotifyCollectionChangedAction.Replace:
                    Console.WriteLine("Replaced:");
                    foreach (var oldItem in e.OldItems)
                    {
                        Console.WriteLine("- " + oldItem.ToString());
                    }

                    Console.WriteLine("With:");
                    foreach (var newItem in e.NewItems)
                    {
                        Console.WriteLine("- " + newItem.ToString());
                    }

                    break;

                case NotifyCollectionChangedAction.Move:
                    Console.WriteLine("Moved:");
                    Console.WriteLine($"- From index {e.OldStartingIndex} to index {e.NewStartingIndex}");
                    break;

                case NotifyCollectionChangedAction.Reset:
                    Console.WriteLine("Collection Reset.");
                    break;
            }
        }
    }
}
