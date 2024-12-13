using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples
{
    /*
        Track Player Stats in a Game
        Problem: Use tuples to store and display a player's name, health, and score in a game.
     */
    public class Q2
    {
        static (string Name, int Health, int Score) UpdatePlayerStats((string Name, int Health, int Score) player, int healthDelta, int scoreDelta)
            => (player.Name, player.Health + healthDelta, player.Score + scoreDelta);

        static void DisplayPlayerStats(List<(string Name, int Health, int Score)> players)
        {
            foreach (var player in players)
            {
                Console.WriteLine($"Name: {player.Name}, Health: {player.Health}, Score: {player.Score}");
            }
        }

        public static void Question()
        {
            List<(string Name, int Health, int Score)> players = new List<(string, int, int)>
            {
                ("jamal", 100, 50),
                ("Omar", 80, 30),
                ("Ali", 60, 40)
            };

            Console.WriteLine("Initial Player Stats:");
            DisplayPlayerStats(players);

            Console.WriteLine("\nUpdating stats...");
            players[1] = UpdatePlayerStats(players[1], healthDelta: -20, scoreDelta: 10); 
            players.Add(("Diana", 120, 60)); 

           
            Console.WriteLine("\nUpdated Player Stats:");
            DisplayPlayerStats(players);

        }
    }
}
