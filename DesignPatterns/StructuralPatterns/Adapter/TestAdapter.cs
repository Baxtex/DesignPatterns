using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Adapter
{
    class TestAdapter
    {
        public TestAdapter()
        {
            Console.WriteLine("--Test Adapter start--");
            MicroSDCardReader reader = new MicroSDCardReader();
            reader.Read("sdcard");
            reader.Read("stick");
            reader.Read("foo");
            
            Console.WriteLine("--Test Adapter end--");
        }
    }
}
