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
        public static int _enemyMana;

        public Enemy(string _enemyName, string _enemyType, int _enemyHealth, int _enemyMana)
        {
            _enemyName = _enemyName;
            _enemyType = _enemyType;
            _enemyHealth = _enemyHealth;
            _enemyMana = _enemyMana;
        }
    }
}
