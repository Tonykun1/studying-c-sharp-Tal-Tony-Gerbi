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
        public Part(double price, string part,double partPrice) : base(price)
        {
            this.part = part;
            this.partPrice = partPrice;
        }

        public override string ToString()
        {
            return $"the part is {part} and the price of ram is {partPrice}";
        }
    }
}
