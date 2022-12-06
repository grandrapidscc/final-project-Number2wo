using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    public class inputValidation
    {
        public bool encounterChoice()
        {
            {
                var userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    case "1":
                        Hero.Fireball();
                        return true;
                    case "2":
                        Hero.Heal();
                        return true;
                    case "3":
                        Hero.Flee();
                        return true;
                    default:
                        Console.WriteLine("Invalid choice.");
                        return false;
                }
            }
        }
    }
}
