using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Players = new List<int>();

            Console.WriteLine("Enter IDs of players and enter non-integral value to finish");

            string EnteredPlayer = Console.ReadLine();

            int enteredPlayerId = 0;

            while (int.TryParse(EnteredPlayer, out enteredPlayerId))
            {
                Players.Add(enteredPlayerId);
                EnteredPlayer = Console.ReadLine();
            }

            Console.WriteLine();

            Console.WriteLine("Matches");

            Random rnd = new Random();

            int TotalMatches = (int)Math.Floor((double)Players.Count / 2);
            for (int i = 0; i < TotalMatches; i++)
            {
                int playerIndex = rnd.Next(Players.Count);
                Console.Write(Players[playerIndex].ToString() + " vs ");
                Players.RemoveAt(playerIndex);
                int opponentIndex = rnd.Next(Players.Count);
                Console.WriteLine(Players[opponentIndex].ToString());
                Players.RemoveAt(opponentIndex);
            }

            if (Players.Count > 0)
                Console.WriteLine("Bye: " + Players[0]);

            Console.ReadKey();
        }
    }
}
