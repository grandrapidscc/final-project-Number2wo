using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    public class Hero
    {
        private string _heroName;
        private string _heroType;
        private int _heroHealth;
        private int _heroMana;

        
        public Hero(string heroName, string heroType, int heroHealth, int heroMana)
        {
            _heroName = heroName;
            _heroType = heroType;
            _heroHealth = heroHealth;
            _heroMana = heroMana;
        }


        public void Fireball()    //does 5 dmg to enemy
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

        public void Heal()    //heals 5 hp to hero
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

        public void Flee()    //has a chance of allowing the Wizert to escape.
        {
            Console.WriteLine("The Wizert attempts to flee from the battle.");
        }
        
        public void TakeBodySlamDmg()  //goblin attack hits Wizert
        {
            _heroHealth -= 2;
            if (_heroHealth <= 0)
            {
                Console.WriteLine("The Wizert has been defeated. Game over.");
                Console.WriteLine("Would you like to play again? (Y/N)");
            }
            else
            {
                Console.WriteLine("The Goblin picks the Wizert up high above his head and slams him on the ground!");
                Console.WriteLine("The Wizert has " + _heroHealth + " health left.");
            }
        }

        public void TakeCleaveDmg()  //orc attack hits Wizert
        {
            _heroHealth -= 3;
            if (_heroHealth <= 0)
            {
                Console.WriteLine("The Wizert has been defeated. Game over.");
                Console.WriteLine("Would you like to play again? (Y/N)");
            }
            else
            {
                Console.WriteLine("The Orc swings his axe in a wide arc, cleaving the Wizert in half!");
                Console.WriteLine("The Wizert has " + _heroHealth + " health left.");
            }
        }

        public void TakeScreechDmg()
        {
            _heroHealth -= 5;
            if (_heroHealth <= 0)
            {
                Console.WriteLine("The Wizert has been defeated. Game over.");
                Console.WriteLine("Would you like to play again? (Y/N)");
            }
            else
            {
                Console.WriteLine("The Banshee screeches in the Wizert's face, causing him to lose his concentration.");
                Console.WriteLine("The Wizert has " + _heroHealth + " health left.");
            }
        }

    }
}
