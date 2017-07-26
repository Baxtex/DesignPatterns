using System;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    internal class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Circle Draw");
        }
    }
}