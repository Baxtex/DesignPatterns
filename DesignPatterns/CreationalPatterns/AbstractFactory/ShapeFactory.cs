namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    internal class ShapeFactory : AbstractFactory
    {
        internal override IColor GetColor(string color)
        {
            return null;
        }

        internal override IShape GetShape(string shapeType)
        {
            if (string.IsNullOrEmpty(shapeType))
                return null;
            else if (shapeType.ToLower() == "circle")
                return new Circle();
            else if (shapeType.ToLower() == "rectangle")
                return new Rectangle();
            else if (shapeType.ToLower() == "square")
                return new Square();
            else
                return null;
        }
    }
}