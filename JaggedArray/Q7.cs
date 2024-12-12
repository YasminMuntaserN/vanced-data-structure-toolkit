using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    /*
        City Temperature Data
        Problem: Store daily temperature readings for multiple cities, where each city has a different number of recorded days.
   */
    public class Q7
    {
        public static void Question()
        {
            string[] cityNames = { "Jerusalem", "Gaza", "Bethlehem", "Hebron", "Ramallah" };
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            Random random = new Random();

            int[][] temperatureData = new int[cityNames.Length][];

            PopulateTemperatureData(cityNames, daysOfWeek, temperatureData, random);
            DisplayAverageTemperatures(cityNames, temperatureData);
        }

        private static void PopulateTemperatureData(string[] cityNames, string[] daysOfWeek, int[][] temperatureData, Random random)
        {
            for (int i = 0; i < temperatureData.Length; i++)
            {
                int recordedDays = random.Next(1, daysOfWeek.Length + 1);
                temperatureData[i] = new int[recordedDays];

                Console.WriteLine($"\n{cityNames[i]} daily temperature readings:");
                for (int j = 0; j < recordedDays; j++)
                {
                    temperatureData[i][j] = random.Next(16, 32);
                    Console.WriteLine($" {daysOfWeek[j]}: {temperatureData[i][j]}°C");
                }
            }
        }

        private static void DisplayAverageTemperatures(string[] cityNames, int[][] temperatureData)
        {
            Console.WriteLine("\nAverage temperatures by city:");
            for (int i = 0; i < temperatureData.Length; i++)
            {
                Console.WriteLine($" {cityNames[i]}: {temperatureData[i].Average():F2}°C");
            }
        }
    }
}