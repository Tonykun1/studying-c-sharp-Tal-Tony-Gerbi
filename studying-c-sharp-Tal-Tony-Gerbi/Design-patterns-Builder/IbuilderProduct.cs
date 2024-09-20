using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Tal_Tony_Gerbi.Design_patterns_Builder
{
    public  interface IbuilderProduct
    {
        public void BuilderName();
        public void BuildPackage();
        public void BuildPrice();
        public void BuildManufacturer();
        public void Reset();
        public Product Build();


    }
}
