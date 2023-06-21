using c_sharp_Polymorphism;

internal class Program
{
    private static void Main(string[] args)
    {
       
        Shape[] shape1 = { new Circle(2.3), new Rectangle(2.3,3.5) };
        
        Console.WriteLine($"the Area of Circle is:{shape1[0].CalculateArea()}");
        Console.WriteLine($"the Area of Rectangle is:{shape1[1].CalculateArea()}");

    }
}