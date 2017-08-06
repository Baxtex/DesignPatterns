using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Prototype
{
    class ShapeCache
    {
        private static Dictionary<string, Shape> shapeMap = new Dictionary<string, Shape>();

        public static Shape GetShape( string shapeId)
        {
            Shape cachedShape = shapeMap[shapeId];
            return (Shape) cachedShape.Clone();
        }

        public static void LoadCache()
        {
            Circle circle = new Circle();
            circle.Id = ("1");
            shapeMap[circle.Id] = circle;

            Square square = new Square();
            square.Id = ("2");
            shapeMap[square.Id] = square;

            Rectangle rectangle = new Rectangle();
            rectangle.Id = ("3");
            shapeMap[rectangle.Id] = rectangle;
        }
    }
}
