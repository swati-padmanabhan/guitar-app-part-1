using GuitarOOADDemo.Models;

namespace GuitarOOADDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            // Add some guitars to the inventory
            inventory.AddGuitar("NO1", 25000, Builder.NATIONAL, "Electric", TypeGuitar.ELECTRIC, Wood.KOA, Wood.WALNUT);
            inventory.AddGuitar("NO2", 12000, Builder.TACOMA, "Bass", TypeGuitar.ARCHTOP, Wood.MAPLE, Wood.MAPLE);
            inventory.AddGuitar("NO3", 5000, Builder.PARKER, "Fender", TypeGuitar.FLAMENCO, Wood.ROSEWOOD, Wood.EBONY);

            // Display all guitars in the inventory
            Console.WriteLine("All Guitars in Inventory:");
            DisplayGuitarDetails(inventory.GetGuitar("NO1"));
            DisplayGuitarDetails(inventory.GetGuitar("NO2"));
            DisplayGuitarDetails(inventory.GetGuitar("NO3"));


            Guitar clientGuitar = new Guitar("NO2", 12000, Builder.TACOMA, "Bass", TypeGuitar.ARCHTOP, Wood.MAPLE, Wood.MAPLE);
            Guitar guitar = inventory.Search(clientGuitar);

            if (guitar != null)
            {
                Console.WriteLine("\nThe guitar the client wanted was found:");
                DisplayGuitarDetails(guitar);
            }
            else
                Console.WriteLine("\nThe guitar the client wanted was not found:");
        }

        static void DisplayGuitarDetails(Guitar guitar)
        {
            if (guitar != null)
            {
                Console.WriteLine($"Serial Number: {guitar.SerialNumber}");
                Console.WriteLine($"Price: ${guitar.Price}");
                Console.WriteLine($"Builder: {guitar.Builder}");
                Console.WriteLine($"Model: {guitar.Model}");
                Console.WriteLine($"Type: {guitar.Type}");
                Console.WriteLine($"Back Wood: {guitar.BackWood}");
                Console.WriteLine($"Top Wood: {guitar.TopWood}\n");
            }

        }
    }
}
