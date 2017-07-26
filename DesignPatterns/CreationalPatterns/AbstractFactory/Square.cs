using System;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    internal class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Square Draw");
        }
    }
}