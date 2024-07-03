using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Tal_Tony_Gerbi.inheritance
{
    public class PlayStation:GameConsole
    {
        private int gb_playstation;
        private string color;
         
        public PlayStation(int gb_playstation, string color):base(0)
        {
            this.gb_playstation = gb_playstation;
            this.color = color;
        }

        public void DisplayPlayStation()
        {
            base.DisplayGameConsole();
            Console.WriteLine($"gb in PlayStatin is {gb_playstation} and the color is {color}");
        }
    }
}
