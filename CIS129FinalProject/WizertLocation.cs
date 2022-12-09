using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIS129FinalProject;

namespace CIS129FinalProject
{
    public class WizertLocation
    {
        public static void startingLocation()
        {
            Random random = new Random();
            int x = random.Next(0, 5);
            int y = random.Next(0, 5);
            int[] startingLocation = { x, y };
            Console.WriteLine($"The Wizert is in location ({x}, {y})");
        }
    }
}
