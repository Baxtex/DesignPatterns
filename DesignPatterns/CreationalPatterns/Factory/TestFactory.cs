using System;

namespace DesignPatterns.Factory
{
    internal class TestFactory
    {
        public TestFactory()
        {
            Console.WriteLine("--TestFactory start--");
            ShapeFactory factory = new ShapeFactory();

            IShape circleShape = factory.GetShape("circle");
            circleShape.Draw();

            IShape rectangleShape = factory.GetShape("rectangle");
            rectangleShape.Draw();

            IShape squareShape = factory.GetShape("square");
            squareShape.Draw();
            Console.WriteLine("--TestFactory end--");
        }
    }
}