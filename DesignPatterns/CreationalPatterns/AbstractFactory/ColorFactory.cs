namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    internal class ColorFactory : AbstractFactory
    {
        internal override IColor GetColor(string colorType)
        {
            if (string.IsNullOrEmpty(colorType))
                return null;
            else if (colorType.ToLower() == "red")
                return new Red();
            else if (colorType.ToLower() == "green")
                return new Green();
            else if (colorType.ToLower() == "blue")
                return new Blue();
            else
                return null;
        }

        internal override IShape GetShape(string shapeType)
        {
            return null;
        }
    }
}