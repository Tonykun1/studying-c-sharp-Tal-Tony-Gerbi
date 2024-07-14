using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Tal_Tony_Gerbi.List
{
    public  class AddList
    {
        public static void Demo()
        {
            addList();
        }
        public static void addList()
        {
            List<int> list = new List<int>();
            Console.WriteLine("add list");
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            Console.WriteLine(string.Join(",",list));
            Console.WriteLine("remove list");
            list.Remove(2);
            Console.WriteLine(string.Join(",", list));
            Console.WriteLine("take one from list");
            Console.WriteLine(list[0]);
            Console.WriteLine(list[1]);
        }
    }
}
