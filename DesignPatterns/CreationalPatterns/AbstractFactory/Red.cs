using System;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    internal class Red : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Red Fill");
        }
    }
}