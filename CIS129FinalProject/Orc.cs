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
            int enemyHealth) : base(enemyName, enemyType, enemyHealth)
        {
        }

        public void attack()
        {
            Hero._heroHealth -= 3;
            if (Hero._heroHealth <= 0)
            {
                Console.WriteLine("The Wizert has been defeated. Game over.");
                Console.WriteLine("Would you like to play again? (Y/N)");
            }
            else
            {
                Console.WriteLine("The Orc swings his axe in a wide arc, cleaving the Wizert in half!");
                Console.WriteLine("The Wizert has " + Hero._heroHealth + " health left.");
            }

        }

        public void takeFireball()
        {
            Orc._enemyHealth -= 5;
            if (Orc._enemyHealth <= 0)
            {
                Console.WriteLine("The Orc has been defeated.");
                Console.WriteLine("The Wizert has " + Hero._heroHealth + " health left.");
                Console.WriteLine("The Wizert has " + Hero._heroMana + " mana left.");
            }
            else
            {
                Console.WriteLine("The Wizert casts a fireball at the Orc, burning him to a crisp!");
                Console.WriteLine("The Orc has " + Orc._enemyHealth + " health left.");
                Console.WriteLine("The Wizert has " + Hero._heroHealth + " health left.");
                Console.WriteLine("The Wizert has " + Hero._heroMana + " mana left.");
            }
        }
    }
}
