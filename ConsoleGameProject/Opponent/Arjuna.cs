using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameProject.Opponent
{
    public class Arjuna : IOpponent
    {
        public string Name => "Arjuna the Archer";

        public string Attack()
        {
            string[] attacks = new string[8] { "Dagger", "Bow", "Bow", "Bow", "Dagger", "Bow", "Dagger", "Shield" };
            Random rnd = new Random();
            int n = rnd.Next(0, 5);
            Console.WriteLine("Arjuna the Archer uses his " + attacks[n]);
            return attacks[n];
        }
    }
}
