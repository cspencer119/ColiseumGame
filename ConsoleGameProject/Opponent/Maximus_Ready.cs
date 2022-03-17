using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameProject.Opponent
{
    public class Maximus_Ready : IOpponent
    {
        public string Name => "Maximus the Ready";

        public string Attack()
        {
            string[] attacks = new string[8] { "Club", "Sword", "Sword", "Sword", "Dagger", "Bow", "Shield", "Shield" };
            Random rnd = new Random();
            int n = rnd.Next(0, 5);
            Console.WriteLine("Maximus the Ready uses his " + attacks[n]);
            return attacks[n];
        }
    }
}
