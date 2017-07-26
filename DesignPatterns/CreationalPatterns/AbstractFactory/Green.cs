using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    class Green : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Green Fill");
        }
    }
}
