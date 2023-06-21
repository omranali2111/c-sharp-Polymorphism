using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_Polymorphism
{
    /*
    Shape Hierarchy:
Create a shape hierarchy consisting of a base class called Shape 
        and derived classes such as Circle, Rectangle, and Triangle.
        Each shape should have a method called CalculateArea() that 
            calculates and returns its area.Write code to demonstrate 
            polymorphism by creating an array of Shape objects and calling
            the CalculateArea() method for each shape.
    */
    internal abstract class Shape
    {
        public Shape() { }

        public abstract double CalculateArea();
        
    }
}
