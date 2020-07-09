using System;
using Figure;

namespace DemoApp
{
    class Demo
    {
        static void Main(string[] args)
        {
        Shape[] shapes =
        {
            new Circle(40),
            new Triangle(30, 40, 50),
        };
        System.Console.WriteLine("Shapes Collection");
        foreach (Shape s in shapes)
        {
            Console.WriteLine(s);
        }
        }
    }
}
