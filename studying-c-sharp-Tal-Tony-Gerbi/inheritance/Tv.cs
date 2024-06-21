using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Tal_Tony_Gerbi.inheritance
{
    public class Tv:Screen
    {
        private bool onoff;

        public Tv(bool onoff) :base(0)
        {
            this.onoff = onoff;
        }
        public void DisplayTv()
        {
            base.DisplayScreen();
            Console.WriteLine($"on/off {onoff}");
        }
    }
}
