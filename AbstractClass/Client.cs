using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Client : Person
    {
        private string name;
        protected override string Name
        {
            get
            {
                return name + " (клиент)";
            }
            set
            {
                name = value;
            }
        }
        public decimal Sum { get; set; }
        public Client(string name, decimal sum) : base (name)
        {
            Sum = sum;
        }
        public override void Display()
        {
            Console.WriteLine($"{Name} имеет {Sum} рублей");
        }
    }
}
