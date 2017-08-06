using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Prototype
{
    class Rectangle : Shape
    {
        public Rectangle()
        {
            Type = "Reactangle";
        }
        internal override void Draw()
        {
            Console.WriteLine("Rectangle here");
        }
    }
}
