using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    public class inputValidation
    {
        public static bool encounterEnemy()
        {
            var userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    WizertAbilities.Fireball();
                    return true;
                case "2":
                    WizertAbilities.Heal();
                    return true;
                case "3":
                    WizertAbilities.Flee();
                    return true;
                default:
                    Console.WriteLine("Invalid choice. Please choose 1, 2, or 3.");
                    return false;
            }
        }
        
        
    }
}
