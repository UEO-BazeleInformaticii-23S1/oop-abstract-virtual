namespace OopAbstractVirtual
{
    public abstract class Shape
    {
        public Shape(
            string name,
            params Point[] points)
        {
            Name = name;
            Points = points;
        }   

        public string Name { get; }

        public Point[] Points
        {
            get;
        }

        public abstract double GetArea();

        public void Print()
        {
            Console.WriteLine($"{Name} coordinates:");
            foreach(Point p in Points)
            {
                Console.WriteLine($"    - X={p.X}, Y={p.Y}");
            }

            Console.WriteLine();
        }

        public void Move(int dx, int dy)
        {
            foreach (Point p in Points)
            {
                p.ApplyTranslationTransform(dx, dy);
            }
        }

        public void Rotate(double angleDegrees)
        {
            foreach (Point p in Points)
            {
                p.ApplyRotationTransform(angleDegrees);
            }
        }
    }
}
