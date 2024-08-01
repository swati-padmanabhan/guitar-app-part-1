using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarOOADDemo.Models
{
    internal class Guitar
    {
        public string SerialNumber { get; set; }
        public double Price { get; set; }
        public string Builder { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public string BackWood { get; set; }
        public string TopWood { get; set; }

        public Guitar(string serialNumber, double price, string builder, string model, string type, string backWood, string topWood)
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
