using System;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    internal class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Rectangle Draw");
        }
    }
}