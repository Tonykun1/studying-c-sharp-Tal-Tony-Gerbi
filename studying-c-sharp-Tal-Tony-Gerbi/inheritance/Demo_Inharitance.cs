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
           
            Part part = new Part(2000, "ram", 250);
            SystemOnPC sys = new SystemOnPC(2000, "Windows", "Avans", part);
            Console.WriteLine(sys.ToString());
        }
    }
}
