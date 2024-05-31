using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Tal_Tony_Gerbi.basic_objects
{
    public  class CteateObj
    {
        public static void updatename(ThisObjects obj)
        {
            obj.Name = "chatshadi";
            obj.Description = "im 50 years old";
        }
        public static void demo()
        {
            ThisObjects obj = new ThisObjects("tony", "im 25 years old");
            obj.Display();
            ThisObjects obj2 = new ThisObjects();
            obj2.Display();
            obj.updateName();
            Console.WriteLine("name = " + obj.Name + " |Description = " + obj.Description);
        }
    }
    public class ThisObjects
    {
        public string Name;
        public string Description;

        public ThisObjects(string Name, string Description)
        {
            this.Name = Name;
            this.Description = Description;
        }
        public ThisObjects():this("nick", "im 28 years old")
        {

        }
        public void  updateName()
        {
            CteateObj.updatename(this);
        }
        public  void Display()
        {
            Console.WriteLine("name = "+ this.Name + " |Description = " + this.Description);
        }
    }
}
