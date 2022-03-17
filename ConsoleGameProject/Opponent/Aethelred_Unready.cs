using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleGameProject.Attack;

namespace ConsoleGameProject.Opponent
{
    public class Aethelred_Unready : IOpponent
    {
       public string Name => "Aethelred the Unready";
       public string Attack()
        {
                string[] attacks = new string[5] { "Club", "Club", "Club", "Sword", "Dagger" };
                Random rnd = new Random();
                int n = rnd.Next(0, 2);
                Console.WriteLine("Aethelred the Unready uses his " + attacks[n]);
            return attacks[n];
        }
    }
}
