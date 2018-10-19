using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ddsolo;

namespace ddsolo
{
    class Program
    {
        static void Main(string[] args)
        {
            var player1 = new Player("Playername", 0, 0, 1, 10, 10);
            Console.WriteLine("What's your Name?");
            player1.PlayerName = Console.ReadLine();
            Console.WriteLine("Welcome " + player1.PlayerName + " to Dungeons and D");
            Location location = new Location(1, "SpawPoint", "This is your spawnpoint");
            Console.ReadKey();
        }
    }
}
