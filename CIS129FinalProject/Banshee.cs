using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    internal class Banshee : Enemy
    {
        public Banshee(
            string enemyName, 
            string enemyType, 
            int enemyHealth, 
            int enemyMana) : base(enemyName, enemyType, enemyHealth, enemyMana)
        {
        }

        public void attack()
        {
            Hero._heroHealth -= 5;
            if (Hero._heroHealth <= 0)
            {
                Console.WriteLine("The Wizert has been defeated. Game over.");
                Console.WriteLine("Would you like to play again? (Y/N)");
            }
            else
            {
                Console.WriteLine("The Banshee wails a piercing shriek, causing the Wizert to collapse in agony!");
                Console.WriteLine("The Wizert has " + Hero._heroHealth + " health left.");
            }
        }

        public void takeFireball()
        {
            Banshee._enemyHealth -= 5;
            if (Banshee._enemyHealth <= 0)
            {
                Console.WriteLine("The Banshee has been defeated.");
                Console.WriteLine("The Wizert has " + Hero._heroHealth + " health left.");
                Console.WriteLine("The Wizert has " + Hero._heroMana + " mana left.");
            }
            else
            {
                Console.WriteLine("The Wizert casts a fireball at the Banshee, burning her to a crisp!");
                Console.WriteLine("The Banshee has " + Banshee._enemyHealth + " health left.");
                Console.WriteLine("The Wizert has " + Hero._heroHealth + " health left.");
                Console.WriteLine("The Wizert has " + Hero._heroMana + " mana left.");
            }
        }
    }
}
