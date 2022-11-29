using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    internal class Encounters
    {
        public void Encounter()
        {
            Console.WriteLine("The Wizert has encountered an enemy!");
            Console.WriteLine("The Wizert has " + Hero._heroHealth + " health left.");
            Console.WriteLine("The Wizert has " + Hero._heroMana + " mana left.");
            Console.WriteLine("The enemy has " + Enemy._enemyHealth + " health left.");
            Console.WriteLine("The enemy has " + Enemy._enemyMana + " mana left.");
            Console.WriteLine("What will the Wizert do?");
            Console.WriteLine("1. Cast Fireball");
            Console.WriteLine("2. Cast Heal");
            Console.WriteLine("3. Flee");
            var userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    Hero.Fireball();
                    break;
                case "2":
                    Hero.Heal();
                    break;
                case "3":
                    Hero.Flee();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
