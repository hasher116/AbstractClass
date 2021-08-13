using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Circle : Figure
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return Math.PI*Math.Pow(Radius,2)/2;
        }
        public override double Perimetr()
        {
            return 2*Math.PI*Radius;
        }
    }
}
