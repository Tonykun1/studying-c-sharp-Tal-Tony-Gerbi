using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Tal_Tony_Gerbi.inheritance
{
    public class Keyboard:ElectricProduct
    {
        private bool mechanit;

        public Keyboard(bool mechanit):base("name",0,0,0,0)
        {
            this.mechanit = mechanit;
        }

        public void DisplayKeyBoard()
        {
            base.DisplayD();
            Console.WriteLine($"mechanit {mechanit}");
        }
    }
}
