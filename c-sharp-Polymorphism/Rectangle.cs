using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_Polymorphism
{
    internal class Rectangle:Shape
    {
        double Width;
        double Height;

        public Rectangle() { }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;

            Console.WriteLine($"the Area of rectangle is:{CalculateArea()}");
           
        }

        public override double CalculateArea()
        {
            return (Width * Height);
        }

       

    }

}
