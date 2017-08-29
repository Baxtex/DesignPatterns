using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Adapter
{
    class MemoryAdapter : IMicroSDCardReader
    {
        private IMemoryStickReader stickReader = new MemoryStickReader();


        public void Read(string typeOfMemory)
        {
            if(typeOfMemory == "stick")
            {
                stickReader.ReadMemoryStick();
            }
            else
            {
                Console.WriteLine("Unknown");
            }
        }
    }
}
