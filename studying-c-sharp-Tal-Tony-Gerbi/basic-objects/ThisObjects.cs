using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Tal_Tony_Gerbi.basic_objects
{
    public class CteateObj
    {
        public static void updatename(ThisObjects obj)
        {
            obj.Name = "oded";
            obj.Description = "im 30 years old";
            obj.SetID(3);
        }
        public static void demo()
        {
            ThisObjects obj = new ThisObjects("tony", "im 25 years old",1);
            obj.Display();
            ThisObjects obj2 = new ThisObjects();
            obj2.Display();
            obj.updateName();
            obj.Display();
            obj.SetID(10);
            obj.SetDescription("im 25 years old");
            obj.SetName("Tonykun");
            obj.Display();
        }
    }
    public class ThisObjects
    {
        public string Name;
        public string Description;
        private int id;
        public ThisObjects(string Name, string Description, int id)
        {
            this.Name = Name;
            this.Description = Description;
            this.id = id;
        }
        public ThisObjects() : this("nick", "im 28 years old",2)
        {

        }
        public string GetName()
        {
            return this.Name;
        }
        public void SetName(string Name)
        {
            this.Name = Name;
        }
        public string GetDescription()
        {
            return this.Description;
        }
        public void SetDescription(string Description)
        {
            this.Description = Description;
        }
        public int GetID()
        {
            return this.id;
        }
        public void SetID(int id)
        {
            this.id = id;
        }
        public void updateName()
        {
            CteateObj.updatename(this);
        }
        public void Display()
        {
            Console.WriteLine("name = " + this.Name + " |Description = " + this.Description + " |id = " + this.id);
        }
    }
}
