using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Prototype
{
    internal abstract class Shape : ICloneable
    {
        public string Id { get; set; }
        public string Type { get; set; }

        internal abstract void Draw();

        public object Clone()
        {
            Object clone = null;
            clone = base.MemberwiseClone();
            return clone;
        }
    }
}
