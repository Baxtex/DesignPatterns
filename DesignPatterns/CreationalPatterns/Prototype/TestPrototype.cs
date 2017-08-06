using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Prototype
{
    class TestPrototype
    {
        public TestPrototype()
        {
            Console.WriteLine("--TestPrototype start--");

            ShapeCache.LoadCache();

            Shape clonedShape1 = (Shape)ShapeCache.GetShape("1");
            Console.WriteLine($"Shape : {clonedShape1.Type}");

            Shape clonedShape2 = (Shape)ShapeCache.GetShape("2");
            Console.WriteLine($"Shape : {clonedShape2.Type}");

            Shape clonedShape3 = (Shape)ShapeCache.GetShape("3");
            Console.WriteLine($"Shape : {clonedShape3.Type}");

            Console.WriteLine("--TestPrototype end--");
        }
    }
}
