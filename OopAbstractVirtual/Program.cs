using System.Drawing;

namespace OopAbstractVirtual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Shape s = new Shape("weird shape");
            //Console.WriteLine(s.GetArea());

            Square square = new Square(new Point(100, 100), 10);
            Console.WriteLine(square.GetArea());
            square.Move(50, 50);
            square.Rotate(45);
            Console.WriteLine(square.GetArea());

            Triangle triangle = new Triangle(
                new Point(50, 50),
                new Point(100, 50),
                new Point(75, 100));
            Console.WriteLine(triangle.GetArea());
            triangle.Move(50, 50);
            triangle.Rotate(45);
            Console.WriteLine(triangle.GetArea());

            Shape.Print();
            //Console.WriteLine("Hello, World!");
        }
    }
}