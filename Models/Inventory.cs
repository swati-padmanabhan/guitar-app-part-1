namespace GuitarOOADDemo.Models
{
    internal class Inventory
    {
        public List<Guitar> Guitars { get; set; } = new List<Guitar>();


        public void AddGuitar(string serialNumber, double price, Builder builder, string model, TypeGuitar type, Wood backWood, Wood topWood)
        {
            Guitar guitar = new Guitar(serialNumber, price, builder, model, type, backWood, topWood);
            Guitars.Add(guitar);
        }

        public Guitar GetGuitar(string serialNumber)
        {
            return Guitars.Find(guitar => guitar.SerialNumber.Equals(serialNumber));
        }

        public Guitar Search(Guitar searchGuitar)
        {
            return Guitars.Find(guitar =>
                (searchGuitar.Builder == null || searchGuitar.Builder.Equals(guitar.Builder)) &&
                (searchGuitar.Model == null || searchGuitar.Model.Equals(guitar.Model)) &&
                (searchGuitar.Type == null || searchGuitar.Type.Equals(guitar.Type)) &&
                (searchGuitar.BackWood == null || searchGuitar.BackWood.Equals(guitar.BackWood)) &&
                (searchGuitar.TopWood == null || searchGuitar.TopWood.Equals(guitar.TopWood))
            );
        }
    }
}
