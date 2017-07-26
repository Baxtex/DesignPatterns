using System;
namespace DesignPatterns.CreationalPatterns.AbstractFactory

{
    internal class TestAbstractFactory
    {
        public TestAbstractFactory()
        {
            Console.WriteLine("--TestAbstractFactory start--");
            AbstractFactory shapeFactory = FactoryProducer.GetFactory("shape");
            IShape shape1 = shapeFactory.GetShape("circle");
            IShape shape2 = shapeFactory.GetShape("rectangle");
            IShape shape3 = shapeFactory.GetShape("square");
            shape1.Draw();
            shape2.Draw();
            shape3.Draw();

            AbstractFactory colorFactory = FactoryProducer.GetFactory("color");
            IColor color1 = colorFactory.GetColor("red");
            IColor color2 = colorFactory.GetColor("green");
            IColor color3 = colorFactory.GetColor("blue");
            color1.Fill();
            color2.Fill();
            color3.Fill();

            Console.WriteLine("--TestAbstractFactory end--");
        }
    }
}