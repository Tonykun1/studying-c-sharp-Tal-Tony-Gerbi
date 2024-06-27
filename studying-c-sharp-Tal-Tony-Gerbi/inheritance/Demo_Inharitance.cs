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
        }
    }
}
