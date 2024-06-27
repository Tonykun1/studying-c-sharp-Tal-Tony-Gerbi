using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Tal_Tony_Gerbi.inheritance
{
    public class Part:PC
    {
        private string part;
        private double partPrice;

        public Part(string model, string part, double partPrice) : base(model)
        {
            this.part = part;
            this.partPrice = partPrice;
        }
        public string GetPart()
        {
            return part;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, the part is {part} and the price is {partPrice}";
        }
    }
}
