using GuitarOOADDemo.Models;

namespace GuitarOOADDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            // Add some guitars to the inventory
            inventory.AddGuitar("NO1", 25000, "Airline", "Electric", "Resonator", "Classical", "Cedar");
            inventory.AddGuitar("NO2", 12000, "Aria", "Bass", "Electric", "Lapsteel", "Maple");
            inventory.AddGuitar("NO3", 5000, "Avalon", "Fender", "Baritone", "Flamenco", "Ebony");

            // Display all guitars in the inventory
            Console.WriteLine("All Guitars in Inventory:");
            DisplayGuitarDetails(inventory.GetGuitar("NO1"));
            DisplayGuitarDetails(inventory.GetGuitar("NO2"));
            DisplayGuitarDetails(inventory.GetGuitar("NO3"));


            Guitar clientGuitar = new Guitar("SN123", 1500, "Fender", "Stratocaster", "Electric", "Alder", "Alder");
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
