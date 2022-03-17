using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameProject.Opponent
{
    public class Jacob_Unstoppable : IOpponent
    {
        public string Name => "Jacob the Unstoppable";

        public string Attack()
        {
            string[] attacks = new string[11] { "Club", "Sword", "Dagger", "Stack Overflow", "Bow", "Shield", "Club", "Shield", "Sword", "Dagger", "Bow"};
            Random rnd = new Random();
            int n = rnd.Next(0, 10);
            Console.WriteLine("Jacob the Unstoppable uses his " + attacks[n]);
            return attacks[n];
        }
    }
}
