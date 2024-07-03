using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Tal_Tony_Gerbi.inheritance
{
    public class Demo_Inharitance
    {
        public static void demo()
        {
            PC pc = new PC("Asus ROG");
            Part part = new Part("Asus ROG", "RAM", 250);
            SystemOnPC sys = new SystemOnPC("Asus ROG", "Windows", "Avast", part);
            Console.WriteLine(sys.ToString());
            Console.WriteLine("Test inharitance");
            ElectricProduct ep = new ElectricProduct("TV", 0, 26, 34, 3);
            Console.WriteLine("Electric Product");
            ep.SetWatt(151);
            ep.DisplayD();
            Console.WriteLine("Screen");
            Screen s = new Screen(45);
            s.DisplayScreen();
            Console.WriteLine("TV");
            Tv tv = new Tv(true);
            tv.DisplayTv();
            Console.WriteLine("Game Console");
            GameConsole gc = new GameConsole(23);
            gc.SetWatt(230);
            gc.DisplayGameConsole();
            Console.WriteLine("PlayStation");
            PlayStation ps = new PlayStation(1000, "black");
            ps.DisplayPlayStation();
        }
    }
}
