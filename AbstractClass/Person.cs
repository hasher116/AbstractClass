using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    abstract class Person
    {
        protected abstract string Name { get; set; }
        protected Person(string name)
        {
            Name = name;
        }
        public abstract void Display();
    }
}
