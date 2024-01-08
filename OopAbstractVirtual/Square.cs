
namespace OopAbstractVirtual
{
    public class Square : Shape
    {
        public Square(Point topLeft, int width) 
            : base(
                  nameof(Square),
                  topLeft,
                  new Point(topLeft.X + width, topLeft.Y),
                  new Point(topLeft.X + width, topLeft.Y + width),
                  new Point(topLeft.X, topLeft.Y + width))
        { 
            Width = width;
        }

        public int Width { get; }

        public override double GetArea()
        {
            return Width * Width;
        }
    }
}
