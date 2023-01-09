using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIS129FinalProject;

namespace CIS129FinalProject
{
    public class Location
    {
        public static int[] startingLocation()
        {
            Random random = new Random();
            int x = random.Next(0, 5);
            int y = random.Next(0, 5);
            int[] startingLocation = { x, y };
            return startingLocation;
        }

        public static int[] exitLocation()
        {
            Random random = new Random();
            int x = random.Next(0, 5);
            int y = random.Next(0, 5);
            int[] exitLocation = { x, y };
            return exitLocation;
        }


        public static int[] wizertLocation(int row, int column)
        {
            int[] wizertLocation = { row, column };
            row = startingLocation()[0];
            column = startingLocation()[1];
            return wizertLocation;
        }

        public static int[] newWizertLocation = startingLocation();

        public static void setWizertLocation(int row, int column)
        {
            newWizertLocation[0] = row;
            newWizertLocation[1] = column;
        }

        public static void incrementNorth(int[] wizertLocation)
        {
            int row = wizertLocation[0];
            int column = wizertLocation[1];
            if (row > 0 && row < 4 && column > 0 && column < 4)
            {
                newWizertLocation[0] = wizertLocation[0] -= 1;
                //return wizertLocation;
                {
                    Console.WriteLine("The Wizert has moved North");
                }
            }
            else
            {
                Console.WriteLine("There is a wall that direction, you cannot move there.");
                Console.WriteLine("Please choose again.");
                Location.MoveWizert();
                //return wizertLocation;
            }
        }

        public static int[] incrementSouth(int[] wizertLocation)
        {
            int row = wizertLocation[0];
            int column = wizertLocation[1];
            if (row > 0 && row < 4 && column > 0 && column < 4)
            {
                wizertLocation[0] += 1;
                return wizertLocation;
            }
            else
            {
                Console.WriteLine("There is a wall that direction, you cannot move there.");
                Console.WriteLine("Please choose again.");
                Location.MoveWizert();
                return wizertLocation;
            }
        }

        public static int[] incrementEast(int[] wizertLocation)
        {
            int row = wizertLocation[0];
            int column = wizertLocation[1];
            if (row >= 0 && row <= 4 && column >= 0 && column <= 4)
            {
                wizertLocation[1] += 1;
                return wizertLocation;
            }
            else
            {
                Console.WriteLine("There is a wall that direction, you cannot move there.");
                Console.WriteLine("Please choose again.");
                Location.MoveWizert();
                return wizertLocation;
            }
        }

        public static int[] incrementWest(int[] wizertLocation)
        {
            int row = wizertLocation[0];
            int column = wizertLocation[1];
            if (row >= 0 && row <= 4 && column >= 0 && column <= 4)
            {
                wizertLocation[1] -= 1;
                return wizertLocation;
            }
            else
            {
                Console.WriteLine("There is a wall that direction, you cannot move there.");
                Console.WriteLine("Please choose again.");
                Location.MoveWizert();
                return wizertLocation;
            }
        }


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
                    Location.incrementNorth(wizertLocation(startingLocation()[0], startingLocation()[1]));
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
