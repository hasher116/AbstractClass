using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Employee : Person
    {
        private string name;
        protected override string Name {
            get
            {
                return name + " (сотрудник)";
            }
            set
            {
                name = value;
            }
        }
        public string Position { get; set; }
        public Employee(string name, string position) : base (name)
        {
            Position = position;
        }
        public override void Display()
        {
            Console.WriteLine($"{Name} занимает должность {Position}");
        }
    }
}
