using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Adapter
{
    class MicroSDCardReader : IMicroSDCardReader
    {
        private MemoryAdapter adapter;
        public void Read(string typeOfMemory)
        {
            if(typeOfMemory == "sdcard")
            {
                Console.WriteLine("Reading sd card.");
            }
            else
            {
                adapter = new MemoryAdapter();
                adapter.Read(typeOfMemory);
            }
        }
    }
}
