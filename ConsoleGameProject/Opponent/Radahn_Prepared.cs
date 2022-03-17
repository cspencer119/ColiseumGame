using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameProject.Opponent
{
    public class Radahn_Prepared : IOpponent
    {
        public string Name => "Radahn the Powerful";

        public string Attack()
        {
            string[] attacks = new string[8] { "Club", "Club", "Sword", "Sword", "Bow", "Shield", "Shield", "Shield"};
            Random rnd = new Random();
            int n = rnd.Next(0, 4);
            Console.WriteLine("Radahn the Prepared uses his " + attacks[n]);
            return attacks[n];
        }
    }
}
