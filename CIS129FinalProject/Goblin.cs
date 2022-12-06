using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    internal class Goblin : Enemy
    {
        public Goblin(string enemyName, string enemyType, int enemyHealth, int enemyMana) : base(enemyName, enemyType, enemyHealth, enemyMana)
        {
        }
    }
}
