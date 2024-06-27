using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Tal_Tony_Gerbi.inheritance.Inheritance_new
{
    internal class Demo
    {
        public static void demo()
        {
            Vehicle tasla=new Vehicle(100,1,"no color","NA","NA");
            Plain myflykid=new Plain("flyX",1001,10000);
            Train taslaTrain = new Train("TrainXmax", 2001, 10);
            Vehicle[] arr = {tasla,myflykid, taslaTrain};
            for(int i=0; i<arr.Length; i++)
            {
                arr[i].DisplayDetails();
            }
        }
    }
}
