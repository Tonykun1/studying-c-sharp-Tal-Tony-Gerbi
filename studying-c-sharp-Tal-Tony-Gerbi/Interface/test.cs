using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace studying_c_sharp_Tal_Tony_Gerbi.Interface
{
    public  class test
    {
        public static void testDemo()
        {
            PokemonDemo Pikachu=new PokemonDemo("Pikachu",200,1,1,"Electric");

            DoomDemo DoomDemo = new DoomDemo("DoomTony", 1, 5, "shootgun", 1500);

            Study_Interface[] players=new Study_Interface[2];

            players[0] = Pikachu;
            players[1] = DoomDemo;
            for(int i=0; i<players.Length; i++)
            {
                players[i].DoSomething();
                players[i].ShowLvl();
            }

        }
    }
}
