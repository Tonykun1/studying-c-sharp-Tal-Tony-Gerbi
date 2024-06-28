using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Tal_Tony_Gerbi.inheritance.Inheritance_new
{
    public class Demo
    {
        public static void demo()
        {
            Vehicle tasla=new Vehicle(100,1,"no color","NA","NA");
            Plain myflykid=new Plain("flyX",1001,10000);
            Train taslaTrain = new Train("TrainXmax", 2001, 10);
            Vehicle[] arr = {tasla,myflykid, taslaTrain };
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].DisplayDetails();
                //arr[i].DoPlain(); not work
            }
            Vehicle newfly = new Plain("flyX", 1001, 10000);
            ((Plain)newfly).DoPlain();//work
           // ((Plain)taslaTrain).DoPlain();//not work
           if(myflykid is Vehicle)//work 
            {
                Console.WriteLine("true");
            }
           if(myflykid is Train)//not work
            {
                Console.WriteLine("true1");
            }
            Console.WriteLine(tasla.GetType() == myflykid.GetType());//false
            Console.WriteLine(tasla.GetType() == tasla.GetType());//true
        }
    }
}
