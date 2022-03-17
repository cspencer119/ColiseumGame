using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameProject
{
    public class Attack
    {
        public enum AttackRoll { Club, Sword, Dagger}
        public AttackRoll Combat;
        public int Damage;
        public readonly Random rand = new Random();

        public Attack(AttackRoll type, int damage)
        {
            Combat = type;
            Damage = damage;
        }

    }
}
