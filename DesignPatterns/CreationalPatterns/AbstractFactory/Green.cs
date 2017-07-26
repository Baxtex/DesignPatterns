using System;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    internal class Green : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Green Fill");
        }
    }
}