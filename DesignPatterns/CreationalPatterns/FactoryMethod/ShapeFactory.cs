namespace DesignPatterns.Factory
{
    internal class ShapeFactory
    {
        public IShape GetShape(string shapeType)
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