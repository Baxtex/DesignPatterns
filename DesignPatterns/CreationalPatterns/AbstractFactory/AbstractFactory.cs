using DesignPatterns.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    abstract class AbstractFactory
    {
        internal abstract IColor GetColor(string color);
        internal abstract IShape GetShape(string shapeType);
    }
}
