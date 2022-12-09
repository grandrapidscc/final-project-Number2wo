using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    public class Map
    {
        
        public static int[,] map = new int[5, 5];
        public Map()
        {
            map[0, 0] = 1;
            map[0, 1] = 2;
            map[0, 2] = 3;
            map[0, 3] = 4;
            map[0, 4] = 5;
            map[1, 0] = 6;
            map[1, 1] = 7;
            map[1, 2] = 8;
            map[1, 3] = 9;
            map[1, 4] = 10;
            map[2, 0] = 11;
            map[2, 1] = 12;
            map[2, 2] = 13; 
            map[2, 3] = 14;
            map[2, 4] = 15;
            map[3, 0] = 16;
            map[3, 1] = 17;
            map[3, 2] = 18;
            map[3, 3] = 19;
            map[3, 4] = 20;
            map[4, 0] = 21;
            map[4, 1] = 22;
            map[4, 2] = 23;
            map[4, 3] = 24;
            map[4, 4] = 25;
        }
    }
}
