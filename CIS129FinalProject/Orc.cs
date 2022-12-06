using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    public class Orc : Enemy
    {
        public Orc(
            string enemyName, 
            string enemyType, 
            int enemyHealth, 
            int enemyMana) : base(enemyName, enemyType, enemyHealth, enemyMana)
        {
        }

        public void attack()
        {
            //attack

        }

        public void takeDmg()
        {

        }
    }
}
