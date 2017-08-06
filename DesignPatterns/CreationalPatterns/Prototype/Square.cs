using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Prototype
{
    class Square : Shape
    {
        public Square()
        {
            Type = "Square";
        }
        internal override void Draw()
        {
            Console.WriteLine("Square here");
        }
    }
}
