namespace OopAbstractVirtual
{
    public class Point
    {
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X 
        {
            get;
            private set; 
        }

        public double Y { get; private set; } = 0;

        public void ApplyTranslationTransform(int dx, int dy)
        {
            X = X + dx;
            Y = Y + dy;
        }

        public void ApplyRotationTransform(double angleDegrees)
        {
            double angleRadians = (Math.PI / 180) * angleDegrees;

            // see: https://en.wikipedia.org/wiki/Rotation_matrix

            double originalX = this.X;
            double originalY = this.Y;

            X = (originalX * Math.Cos(angleRadians) - originalY * Math.Sin(angleRadians));
            Y = (originalX * Math.Sin(angleRadians) + originalY * Math.Cos(angleRadians));
        }
    }
}
