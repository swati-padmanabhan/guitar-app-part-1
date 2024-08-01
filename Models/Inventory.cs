namespace GuitarOOADDemo.Models
{
    internal class Inventory
    {
        public List<Guitar> Guitars { get; set; } = new List<Guitar>();


        public void AddGuitar(string serialNumber, double price, Builder builder, string model, TypeGuitar type, Wood backWood, Wood topWood)
        {
            GuitarSpec spec = new GuitarSpec(builder, model, type, backWood, topWood);
            Guitar guitar = new Guitar(serialNumber, price, spec);
            Guitars.Add(guitar);
        }

        public Guitar GetGuitar(string serialNumber)
        {
            return Guitars.Find(guitar => guitar.SerialNumber.Equals(serialNumber));
        }

        public List<Guitar> Search(GuitarSpec searchSpec)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();
            return Guitars.FindAll(guitar =>
                (searchSpec.Builder == null || searchSpec.Builder.Equals(guitar.Spec.Builder)) &&
                (searchSpec.Model == null || searchSpec.Model.Equals(guitar.Spec.Model)) &&
                (searchSpec.Type == null || searchSpec.Type.Equals(guitar.Spec.Type)) &&
                (searchSpec.BackWood == null || searchSpec.BackWood.Equals(guitar.Spec.BackWood)) &&
                (searchSpec.TopWood == null || searchSpec.TopWood.Equals(guitar.Spec.TopWood))
            );
        }
    }
}
