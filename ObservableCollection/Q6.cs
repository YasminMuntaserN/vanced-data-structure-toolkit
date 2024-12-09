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
        Dynamic Weather Updates
        Problem: Display a dynamic list of weather updates for different cities.
     */

    public class Weather
    {
        public string CityName { get; set; }
        public int Degree { get; set; }

        public override string ToString()
        {
            return $"At this time: {DateTime.Now}, the weather in {CityName} is {Degree}°C.";
        }
    }

    public class Q6
    {
        public static void Question()
        {
            ObservableCollection<Weather> weatherUpdates = new ObservableCollection<Weather>();

            weatherUpdates.CollectionChanged += (sender, e) =>
            {
                if (e.Action == NotifyCollectionChangedAction.Add)
                {
                    foreach (Weather newWeather in e.NewItems)
                    {
                        Console.WriteLine(newWeather.ToString());
                    }
                }
                else if (e.Action == NotifyCollectionChangedAction.Replace)
                {
                    foreach (Weather updatedWeather in e.NewItems)
                    {
                        Console.WriteLine($"The Weather Updated: \n{updatedWeather.ToString()}");
                    }
                }
            };

            weatherUpdates.Add(new Weather { CityName = "Gaza", Degree = 21 });

            weatherUpdates[0] = new Weather { CityName = "Gaza", Degree = 25 };
        }
    }
}