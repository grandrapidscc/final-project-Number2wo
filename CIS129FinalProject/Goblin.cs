using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    internal class Goblin : Enemy
    {
        public Goblin(
            string enemyName, 
            string enemyType, 
            int enemyHealth, 
            int enemyMana) : base(enemyName, enemyType, enemyHealth, enemyMana)
        {
        }

        public void attack()
        {
            Hero._heroHealth -= 2;
            if (Hero._heroHealth <= 0)
            {
                Console.WriteLine("The Wizert has been defeated. Game over.");
                Console.WriteLine("Would you like to play again? (Y/N)");
            }
            else
            {
                Console.WriteLine("The Goblin stabs the Wizert with his dagger!");
                Console.WriteLine("The Wizert has " + Hero._heroHealth + " health left.");
            }
        }

        public void takeFireball()
        {
            Goblin._enemyHealth -= 5;
            if (Goblin._enemyHealth <= 0)
            {
                Console.WriteLine("The Goblin has been defeated.");
                Console.WriteLine("The Wizert has " + Hero._heroHealth + " health left.");
                Console.WriteLine("The Wizert has " + Hero._heroMana + " mana left.");
            }
            else
            {
                Console.WriteLine("The Wizert casts a fireball at the Goblin, burning him to a crisp!");
                Console.WriteLine("The Goblin has " + Goblin._enemyHealth + " health left.");
                Console.WriteLine("The Wizert has " + Hero._heroHealth + " health left.");
                Console.WriteLine("The Wizert has " + Hero._heroMana + " mana left.");
            }
        }
    }
}
