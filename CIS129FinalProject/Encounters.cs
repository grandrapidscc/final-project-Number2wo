using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    public class Encounters
    {
        public static void encounterEnemy()
        {
            Console.WriteLine("The Wizert has encountered an enemy!");
            Console.WriteLine("The Wizert has " + Hero._heroHealth + " health left.");
            Console.WriteLine("The Wizert has " + Hero._heroMana + " mana left.");
            Console.WriteLine("The enemy has " + Enemy._enemyHealth + " health left.");
            Console.WriteLine("What will the Wizert do?");
            Console.WriteLine("1. Cast Fireball");
            Console.WriteLine("2. Cast Heal");
            Console.WriteLine("3. Flee");
            inputValidation.encounterEnemy();
            
            //var userChoice = Console.ReadLine();
            //switch (userChoice)
            //{
            //    case "1":
            //        WizertAbilities.Fireball();
            //        break;
            //    case "2":
            //        WizertAbilities.Heal();
            //        break;
            //    case "3":
            //        WizertAbilities.Flee();
            //        break;
            //    default:
            //        Console.WriteLine("Invalid choice.");
            //        break;
            //}  
        }
        
    }
}
