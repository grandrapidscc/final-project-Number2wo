using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    internal class Move
    {
        public static void MoveWizert()
        {
            //user enters 1 2 3 4 to move the wizert
            Console.WriteLine("Enter 1 to move the Wizert North.");
            Console.WriteLine("Enter 2 to move the Wizert South.");
            Console.WriteLine("Enter 3 to move the Wizert West.");
            Console.WriteLine("Enter 4 to move the Wizert East.");
            var userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("The Wizert has moved North.");      
                    break;
                case "2":
                    Console.WriteLine("The Wizert has moved South.");
                    break;
                case "3":
                    Console.WriteLine("The Wizert has moved West.");
                    break;
                case "4":
                    Console.WriteLine("The Wizert has moved East.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
