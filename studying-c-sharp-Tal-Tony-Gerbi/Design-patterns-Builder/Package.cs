using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Tal_Tony_Gerbi.Design_patterns_Builder
{
    public class Package
    {
        private Material material;

        public Material Material { get => material; set => material = value; }
    }
    public enum Material
    {
        //קרטון
        CARDBOARD, NYLON
    }
}
