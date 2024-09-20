using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Tal_Tony_Gerbi.Design_patterns_Builder
{
    public class Product
    {
        private string name;
        private Package package;
        private double price;
        private Manufacturer manufacturer;

        public string Name { get => name; set => name = value; }
        public Package Package { get => package; set => package = value; }
        public double Price { get => price; set => price = value; }
        public Manufacturer Manufacturer { get => manufacturer; set => manufacturer = value; }

        public override string ToString()
        {
            return $"Product:[name = {Name}, price = {Price}";

        }
    }
}
