using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Tal_Tony_Gerbi.Interface
{
    public  class PokemonDemo:Study_Interface
    {
        private string name;
        private int power;
        private int id;
        private int lvl;
        private string elementType;

        public PokemonDemo()
        {

        }

        public PokemonDemo(string name, int power, int id, int lvl, string elementType)
        {
            this.name = name;
            this.power = power;
            this.id = id;
            this.lvl = lvl;
            this.elementType = elementType;
        }

        public string Name { get => name; set => name = value; }
        public int Power { get => power; set => power = value; }
        public int Id { get => id; set => id = value; }
        public int Lvl { get => lvl; set => lvl = value; }
        public string ElementType { get => elementType; set => elementType = value; }


        public void DoSomething()
        {
            Console.WriteLine($"name {name}, Power {power}, id {id},  level {lvl}, elementType  {elementType}");
        }
        public void ShowLvl()
        {
            Console.WriteLine($"Pokemon lv, {lvl} Exp for next lv {lvl*5 }");
        }
    }
}
