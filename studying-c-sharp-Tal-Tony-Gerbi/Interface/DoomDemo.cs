using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Tal_Tony_Gerbi.Interface
{
    public class DoomDemo:Study_Interface
    {
        private string name;
        private int id;
        private int lvl;
        private string weaponType;
        private int hp;

        public DoomDemo()
        {

        }

        public DoomDemo(string name, int id, int lvl, string weaponType, int hp)
        {
            this.name = name;
            this.id = id;
            this.lvl = lvl;
            this.weaponType = weaponType;
            this.hp = hp;
        }

        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        public int Lvl { get => lvl; set => lvl = value; }
        public string WeaponType { get => weaponType; set => weaponType = value; }
        public int Hp { get => hp; set => hp = value; }
        public void DoSomething()
        {
            Console.WriteLine($"name {name}, id {id},  level {lvl}, WeaponType  {weaponType}, hp {hp}");
        }
        public void ShowLvl()
        {
            Console.WriteLine($"DoomPlayer lv, {lvl} Exp for next lv {lvl * 5},hp {hp}");
        }
    }
}
