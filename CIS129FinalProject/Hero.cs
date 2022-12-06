using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    public class Hero
    {
<<<<<<< Updated upstream
        public static string _heroName;
        public static string _heroType;
        public static int _heroHealth;
        public static int _heroMana;
=======
        public string _heroName;
        public string _heroType;
        public int _heroHealth;
        public int _heroMana;


>>>>>>> Stashed changes

        
        public Hero(string _heroName, string _heroType, int _heroHealth, int _heroMana)
        {
<<<<<<< Updated upstream
            _heroName = _heroName;
            _heroType = _heroType;
            _heroHealth = _heroHealth;
            _heroMana = _heroMana;
        } 
=======
            _heroName = heroName;
            _heroType = heroType;
            _heroHealth = heroHealth;
            _heroMana = heroMana;
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

        public void TakeScreechDmg() //banshee attack hits Wizert
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

>>>>>>> Stashed changes
    }
}
