using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    class Blue : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Blue Fill");
        }
    }
}
