using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAbstractVirtual
{
    public class Triangle : Shape
    {
        public Triangle(Point p1, Point p2, Point p3)
            : base(nameof(Triangle), p1, p2, p3)
        {
        }

        public override sealed double GetArea()
        {
            Point p1 = Points[0];
            Point p2 = Points[1];
            Point p3 = Points[2];

            double area = Math.Abs(p1.X * (p2.Y - p3.Y) + p2.X * (p3.Y - p1.Y) + p3.X * (p1.Y - p2.Y)) / 2;
            return Math.Round(area, 2);
        }

        public override void Move(int dx, int dy)
        {
            Console.WriteLine("Before triangle move");
            Print();

            base.Move(dx, dy);

            Console.WriteLine("After triangle move");
            Print();
        }

        public void TriangleSpecificStuff()
        {
            Console.WriteLine("test");
        }
    }
}
