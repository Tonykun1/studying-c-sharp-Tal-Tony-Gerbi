using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Tal_Tony_Gerbi.Design_patterns_Builder
{
    public class Manufacturer
    {
        private string firstName;
        private string lastName;

        public Manufacturer(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }

        public string GetFirstName() { return this.FirstName; }
        public string GetLastName() { return this.LastName; }

        public override string ToString()
        {
            return $"Owner:[firstName={FirstName}, lastName={LastName}";
        }
    }
}
