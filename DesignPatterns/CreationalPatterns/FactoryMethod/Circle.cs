using System;

namespace DesignPatterns.Factory
{
    internal class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Circle Draw");
        }
    }
}