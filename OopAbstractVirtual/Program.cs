using OopAbstractVirtual.FragileBaseClassProblem.Consumer;

namespace OopAbstractVirtual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutoCountingCollectionOfIntegers collection = new AutoCountingCollectionOfIntegers();
            collection.AddElement(1);
            collection.AddCollection(new[] { 2, 3 });
            Console.WriteLine($"Count: {collection.Count}");


            NonPolymorphicDoSomethingWithBaseClass(new ChildClass());

            //Shape s = new Shape("weird shape");
            //Console.WriteLine(s.GetArea());

            Square square = new Square(new Point(100, 100), 10);
            PrintArea(square);
            PrintShape(square);
           

            Console.WriteLine($"Area of the {nameof(Square)} before:" + square.GetArea());
            square.Move(50, 50);
            square.Print();
            square.Rotate(45);
            square.Print();
            Console.WriteLine($"Area of the {nameof(Square)} after:" + square.GetArea());

            object x = "test";

            Triangle triangleShape = new Triangle(
                new Point(50, 50),
                new Point(100, 50),
                new Point(75, 100));
            MoveShape(triangleShape);
            PrintArea(triangleShape);
            PrintShape(triangleShape);

            Console.WriteLine($"Area of the {nameof(Triangle)} before:" + triangleShape.GetArea());
            triangleShape.Move(50, 50);
            triangleShape.Rotate(45);
            PrintArea(triangleShape);
            Console.WriteLine($"Area of the {nameof(Triangle)} after:" + triangleShape.GetArea());
        }

        private static void PrintShape(Shape s)
        {
            s.Print();
        }

        private static void PrintArea(Shape s)
        {
            // dynamic dispatch
            // 1) who is s? 
            //      s may be: a Triangle
            //      s may be: a Square
            // 2) what kind of method is GetArea?
            //      GetArea: abstract/or/virtual => polymorphic method
            //      GetArea: not abstract and not virtual => non-polymorphic method
            // 3) actual call:
            //      for polymorphic methods => call the method based on actual object identity
            //                                      (the type used when object is instantiated)
            //      for NON-polymorphic methods => call the method based on declared object type
            //                                      (the type used to declare the object)

            double area = s.GetArea();

            Console.WriteLine($"Area={area}");
        }

        private static void MoveShape(Shape s)
        {
            s.Move(50, 50);
        }

        private static void DoSomethingWithBaseClass(BaseClass obj)
        {
            obj.DoSomething();
        }

        private static void DoSomethingElseWithBaseClass(BaseClass obj)
        {
            obj.DoSomethingElse();
        }

        private static void NonPolymorphicDoSomethingWithBaseClass(ChildClass obj)
        {
            obj.NonPolymorphicDoSomething();
        }
    }

    public abstract class BaseClass
    {
        public abstract void DoSomething();

        public virtual void DoSomethingElse()
        {
            Console.WriteLine("BaseClass - DoSomethingElse");
        }

        public void NonPolymorphicDoSomething()
        {
            Console.WriteLine("BaseClass - NonPolymorphicDoSomething");
        }
    }

    public class ChildClass : BaseClass
    {
        public override void DoSomething()
        {
            Console.WriteLine("ChildClass - DoSomething");
        }

        public override void DoSomethingElse()
        {
            Console.WriteLine("ChildClass - DoSomethingElse");
        }

        public new void NonPolymorphicDoSomething()
        {
            Console.WriteLine("ChildClass - NonPolymorphicDoSomething");
        }
    }

    public class NephewClass : ChildClass
    {
        public override void DoSomething()
        {
            Console.WriteLine("NephewClass - DoSomething");
        }

        public override void DoSomethingElse()
        {
            Console.WriteLine("NephewClass - DoSomethingElse");
        }

        public void NonPolymorphicDoSomething()
        {
            Console.WriteLine("NephewClass - NonPolymorphicDoSomething");
        }
    }


}