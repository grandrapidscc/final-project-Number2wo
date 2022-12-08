
using CIS129FinalProject;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Wizert's Quest!");

        Enemy goblin = new Enemy("Goblin", "Goblin", 3, 0);
        Enemy Orc = new Enemy("Orc", "Orc", 5, 0);
        Enemy Banshee = new Enemy("Banshee", "Banshee", 8, 0);
        Hero Wizert = new Hero("Wizert", "Sorcerer", 100, 200);

        Encounters.encounterEnemy();



    }
}