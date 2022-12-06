using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    public static class WizertAbilities
    {
        public static void Fireball()    //does 5 dmg to enemy
        {
            if (_heroMana >= 3)
            {
                Console.WriteLine("The Wizert casts a black fireball that burns the enemy.");
                _heroMana -= 3;
                Console.WriteLine("The Wizert has " + _heroMana + " mana left.");

            }
            else
            {
                Console.WriteLine("Not enough mana!");
            }
        }

        public static void Heal()    //heals 5 hp to hero
        {
            if (_heroMana >= 5)
            {
                Console.WriteLine("The Wizert casts Holy Light to heal his wounds.");
                _heroMana -= 5;
                _heroHealth += 3;
                Console.WriteLine("The Wizert has " + _heroMana + " mana left.");
                Console.WriteLine("The Wizert has " + _heroHealth + " health left.");

            }
            else
            {
                Console.WriteLine("Not enough mana!");
            }
        }

        public static void Flee()    //has a chance of allowing the Wizert to escape.
        {
            Console.WriteLine("The Wizert attempts to flee from the battle.");
        }
    }
}
