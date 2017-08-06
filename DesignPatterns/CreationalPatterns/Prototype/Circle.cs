using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Prototype
{
    class Circle : Shape
    {
        public Circle()
        {
            Type = "Circle";
        }
        internal override void Draw()
        {
            Console.WriteLine("Circle here.");
        }
    }
}
