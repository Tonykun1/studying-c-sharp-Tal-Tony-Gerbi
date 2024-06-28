using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Tal_Tony_Gerbi.inheritance.Inheritance_new
{
    public class Vehicle
    {
        private int weight;
        protected int id;
        private string color;
        private string manufacture;
        private string model;
        protected int maxSpeed;
        public virtual void SetMaxSpeed(int maxSpeed)
        {
            if (maxSpeed > 40)
            {
                return;
            }
            this.maxSpeed = maxSpeed;
        }

        public Vehicle(int weight, int id, string color, string manufacture, string model)
        {
            this.weight = weight;
            this.id = id;
            this.color = color;
            this.manufacture = manufacture;
            this.model = model;
        }
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"weight = {weight}, id = {id}, manufacture = {manufacture}");
        }
    }

    public class Plain :Vehicle
    {
        private string type;
        private int maxAltitude;
        public Plain(string type, int id, int maxAltitude) : base(0, id, "no color", "NA", "NA")
        {
            this.type = type;
            this.maxAltitude = maxAltitude;
        }
        public override void SetMaxSpeed(int maxSpeed)
        {
            if (maxSpeed > 950)
            {
                return;
            }
            this.maxSpeed = maxSpeed;
        }
        public void DoPlain()
        {
            Console.WriteLine();
        }
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"type = {type}, maxAltitude = {maxAltitude}");
        }
    }

    public class Train:Vehicle
    {
        private string type;
        private int maxofCaraven;

        public Train(string type, int id, int maxofCaraven) : base(0, id, "no color", "NA", "NA")
        {
            this.type = type;
            this.maxofCaraven = maxofCaraven;
        }
        public override void SetMaxSpeed(int maxSpeed)
        {
            if (maxSpeed > 120)
            {
                return;
            }
            this.maxSpeed = maxSpeed;
        }
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"type = {type}, maxofCaraven = {maxofCaraven}");
        }
    }
}
