using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Adapter
{
    class MemoryStickReader : IMemoryStickReader
    {
        public void ReadMemoryStick()
        {
            Console.WriteLine("Reading Mem stick");
        }
    }
}
