using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Tal_Tony_Gerbi.inheritance
{
    public class PC
    {

        private double price;

        public PC(double price)
        {
            this.price = price;
        }

        public override string ToString()
        {
            return $"price is {price}";
        }
        public  double GetPrice()
        {
            return price;
        }
    }
}
