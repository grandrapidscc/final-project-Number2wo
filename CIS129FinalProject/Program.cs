
using CIS129FinalProject;
using System.Security.Cryptography.X509Certificates;

int[] startingLocation = Location.startingLocation(); //new start location
int[] exitLocation = Location.exitLocation(); //new exit location
int[] wizertLocation = Location.wizertLocation(startingLocation[0], startingLocation[1]); //new wizert location

Console.WriteLine("Welcome to the Wizert's Quest!");


Enemy Orc = new Enemy("Orc", "Orc", 5);
Enemy Banshee = new Enemy("Banshee", "Banshee", 8);
Hero Wizert = new Hero("Wizert", "Sorcerer", 100, 200);

//Console.WriteLine(startingLocation[0]);
//Console.WriteLine(startingLocation[1]);
//Console.WriteLine(exitLocation[0]);
//Console.WriteLine(exitLocation[1]);
//Console.WriteLine(wizertLocation[0]);
//Console.WriteLine(wizertLocation[1]);
//Console.WriteLine(Location.incrementNorth(wizertLocation));
//Console.WriteLine(wizertLocation[0]);
//Console.WriteLine(wizertLocation[1]);
//Console.WriteLine(Location.incrementNorth(wizertLocation));
Console.WriteLine(wizertLocation[0]);
Console.WriteLine(wizertLocation[1]);
Location.MoveWizert();
Console.WriteLine(Location.newWizertLocation[0]);
Console.WriteLine(Location.newWizertLocation[1]);


