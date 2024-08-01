namespace GuitarOOADDemo.Models
{
    internal class GuitarSpec
    {
        public Builder Builder { get; set; }
        public string Model { get; set; }
        public TypeGuitar Type { get; set; }
        public Wood BackWood { get; set; }
        public Wood TopWood { get; set; }

        public GuitarSpec(Builder builder, string model, TypeGuitar type, Wood backWood, Wood topWood)
        {
            Builder = builder;
            Model = model;
            Type = type;
            BackWood = backWood;
            TopWood = topWood;
        }

    }
}
