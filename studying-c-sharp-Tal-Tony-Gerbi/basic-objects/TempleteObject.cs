using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Tal_Tony_Gerbi.basic_objects
{
    public class TempleteObject
    {

        public int age = 10;
        public string name = "something";

        public bool BoolProperty = true;

        public void ToggleBoolProperty()
        {
            BoolProperty = !BoolProperty;
        }
        public void ToggleintProperty(int num)
        {
            age=num;
        }
        public void TogglestringProperty(string str)
        {
            name = str;
        }

    }
    public class Ram
    {
        public int size;
        public int ran;
        public Ram(int size, int ran)
        {
            this.size = size;
            this.ran = ran;
        }
        public void RDisplay()
        {
            Console.WriteLine("size: {0} GB ran: {1} GHz", this.size, this.ran);
        }
    }
    public class GrapicCard
    {
        public int sizeOfGB;
        public double GPUClockSpeed;
        public double width;
        public double height;
        public string name;
        public GrapicCard(string name ,int sizeOfGB, double GPUClockSpeed, double width, double height)
        {
            this.name = name;
            this.sizeOfGB = sizeOfGB;
            this.GPUClockSpeed = GPUClockSpeed;
            this.width = width;
            this.height = height;
        }
        public void GDisplay()
        {
            Console.WriteLine("Name {0} sizeOfGB: {1} GB, GPUClockSpeed: {2} GHz ,Width: {3} ,Height {4}",this.name, this.sizeOfGB, this.GPUClockSpeed, this.width, this.height);
        }

    }
    public class Pc
    {
        public int age;
        public bool New;
        public Ram ram=null;
        public GrapicCard grapicCard =null;
        public Pc(int age, Ram ram, GrapicCard grapicCard)
        {
            this.age = age;
            if(this.age>3)
            this.New = false;
            else
             this.New = true;

            this.ram = ram;
            this.grapicCard = grapicCard;
        }
        public void Display()
        {
            Console.WriteLine("age: {0}, isNew {1}",this.age,this.New);
            ram.RDisplay();
            grapicCard.GDisplay();
        }
    }
    public class TestBasicObject
    {
        public static void Demo()
        {
            /*
            TempleteObject templete1 = new TempleteObject();
            Console.WriteLine("Template 1 = intProperty = {0} , string property = {1}, boolProperty ={2} "
    , templete1.age, templete1.name, templete1.BoolProperty);
            templete1.BoolProperty = true;
            templete1.name = "another string";
            templete1.age = 20;
            Console.WriteLine("Template 1 = intProperty = {0} , string property = {1}, boolProperty ={2} "
                , templete1.age, templete1.name, templete1.BoolProperty);
            templete1.ToggleBoolProperty();
            Console.WriteLine("please enter number");
            int num = int.Parse(Console.ReadLine());
            templete1.ToggleintProperty(num);
            Console.Write("please enter name: ");
            string str = Console.ReadLine();
            templete1.TogglestringProperty(str);
            Console.WriteLine("Template 1 = intProperty = {0} , string property = {1}, boolProperty ={2} "
    , templete1.age, templete1.name, templete1.BoolProperty);
            */

            Ram partRam = new Ram(4860,24);
            GrapicCard partCard = new GrapicCard("4080",24,2.52, 46.2, 34.5);
            if(partCard.name=="4090")
            {
                Console.WriteLine("wow dont touch my grapicCard");
            }    
            Pc pc = new Pc(4, partRam, partCard);
            pc.Display();
        }
    }
}
