using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Adapter
{
    interface IMicroSDCardReader
    {
        void Read(string typeOfMemory);
    }
}
