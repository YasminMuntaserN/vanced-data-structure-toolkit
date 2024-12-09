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
       Live Chat Application
       Problem: Display live chat messages in a chat application as they are received..
     */

    public class Message
    {
        public string SenderName { get; set; }
        public string MessageContent { get; set; }

        public override string ToString()
        {
            return $"{SenderName} sent you a message at {DateTime.Now} \nContent: {MessageContent}";
        }
    }

    public class Q5
    {
        public static void Question()
        {
            ObservableCollection<Message> ob = new ObservableCollection<Message>();

            ob.CollectionChanged += (sender, e) =>
            {
                if (e.Action == NotifyCollectionChangedAction.Add)
                {
                    // foreach (Message newMessage in e.NewItems)
                    //{
                    Console.WriteLine(e.NewItems[0].ToString());
                   // }
                }
            };

            ob.Add(new Message { SenderName = "Yasmin Muntaser", MessageContent = "Gooood Morning :)" });

        }
    }
}
