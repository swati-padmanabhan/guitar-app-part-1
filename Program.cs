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


            GuitarSpec clientGuitarSpec = new GuitarSpec(Builder.TACOMA, "Bass", TypeGuitar.ARCHTOP, Wood.MAPLE, Wood.MAPLE);
            List<Guitar> guitars = inventory.Search(clientGuitarSpec);

            if (guitars.Count > 0)
            {
                Console.WriteLine("\nThe guitar the client wanted was found:");
                foreach (Guitar guitar in guitars)
                {
                    DisplayGuitarDetails(guitar);
                }
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
                Console.WriteLine($"Builder: {guitar.Spec.Builder}");
                Console.WriteLine($"Model: {guitar.Spec.Model}");
                Console.WriteLine($"Type: {guitar.Spec.Type}");
                Console.WriteLine($"Back Wood: {guitar.Spec.BackWood}");
                Console.WriteLine($"Top Wood: {guitar.Spec.TopWood}\n");
            }

        }
    }
}
