using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    class Red : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Red Fill");
        }
    }
}
