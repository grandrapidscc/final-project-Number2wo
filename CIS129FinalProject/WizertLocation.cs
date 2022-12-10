using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIS129FinalProject;

namespace CIS129FinalProject
{
    public class Locations
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

    }
}
