using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Tal_Tony_Gerbi.Enum
{
    public class DemoEnum
    {
        public static void Demo()
        {
            printEnum(AddEnum.A);
            printEnum(AddEnum.B);
            printEnum(AddEnum.C);
        }

        public static void printEnum(AddEnum time)
        {
            switch(time)
            {
                case AddEnum.A:
                    Console.WriteLine("6:00");
                    return;
               case AddEnum.B:
                    Console.WriteLine("6:30");
                    return;
                case AddEnum.C:
                    Console.WriteLine("7:00");
                    return;
                case AddEnum.D:
                    Console.WriteLine("7:30");
                    return;
                    default:
                    Console.WriteLine("I DONT HAVE THIS TIME");
                    return;
                       
            }
        }
    }
}
