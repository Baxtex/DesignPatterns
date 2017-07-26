using System;

namespace DesignPatterns.Factory
{
    internal class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Rectangle Draw");
        }
    }
}