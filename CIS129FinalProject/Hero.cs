using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    public class Hero
    {
        public static string _heroName;
        public static string _heroType;
        public static int _heroHealth;
        public static int _heroMana;



        
        public Hero(string heroName, string heroType, int heroHealth, int heroMana)
        {
            _heroName = _heroName;
            _heroType = _heroType;
            _heroHealth = _heroHealth;
            _heroMana = _heroMana;
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

    }
}
