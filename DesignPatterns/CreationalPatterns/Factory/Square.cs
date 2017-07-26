using System;

namespace DesignPatterns.Factory
{
    internal class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Square Draw");
        }
    }
}