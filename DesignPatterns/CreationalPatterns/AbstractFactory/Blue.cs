using System;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    internal class Blue : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Blue Fill");
        }
    }
}