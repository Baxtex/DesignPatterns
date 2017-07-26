﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    class FactoryProducer
    {
        public static AbstractFactory GetFactory(string choice)
        {
            if (choice.ToLower() == "shape")
                return new ShapeFactory();
            else if (choice.ToLower() == "color")
                return new ColorFactory();
            else
                return null;
        }
    }
}
