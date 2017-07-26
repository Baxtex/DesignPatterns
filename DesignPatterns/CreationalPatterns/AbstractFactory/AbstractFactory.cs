namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    internal abstract class AbstractFactory
    {
        internal abstract IColor GetColor(string color);

        internal abstract IShape GetShape(string shapeType);
    }
}