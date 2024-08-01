namespace GuitarOOADDemo.Models
{
    internal class Guitar
    {
        public string SerialNumber { get; set; }
        public double Price { get; set; }
        public Builder Builder { get; set; }
        public string Model { get; set; }
        public TypeGuitar Type { get; set; }
        public Wood BackWood { get; set; }
        public Wood TopWood { get; set; }

        public Guitar(string serialNumber, double price, Builder builder, string model, TypeGuitar type, Wood backWood, Wood topWood)
        {
            SerialNumber = serialNumber;
            Price = price;
            Builder = builder;
            Model = model;
            Type = type;
            BackWood = backWood;
            TopWood = topWood;
        }
    }
}
