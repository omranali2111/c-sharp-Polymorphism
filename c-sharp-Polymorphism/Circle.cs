using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_Polymorphism
{
    internal class Circle:Shape
    {
        double Radius;

        public Circle(double Radius)
        {
            this.Radius = Radius;

            Console.WriteLine($"the Area of circle is:{CalculateArea()}");
           
        }

        public override double CalculateArea()
        {
            return (Math.PI * Radius * Radius);
        }

       
    }
}
