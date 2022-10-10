using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace W4
{
    internal class Person
    {
        private string name;
        
        public Person(string name) 
        { 
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("name must not be blank");
            }
            else
            {
                this.name = name;
            }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            return this.name;
        }

    }
}
