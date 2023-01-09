using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
     public class Enemy
    {
        public static string _enemyName;
        public static string _enemyType;
        public static int _enemyHealth;

        public Enemy(string enemyName, string enemyType, int enemyHealth)
        {
            _enemyName = enemyName;
            _enemyType = enemyType;
            _enemyHealth = enemyHealth;
        }
    }
}
