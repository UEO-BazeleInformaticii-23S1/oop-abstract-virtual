using OopAbstractVirtual.FragileBaseClassProblem.Library;

namespace OopAbstractVirtual.FragileBaseClassProblem.Consumer
{
    public class AutoCountingCollectionOfIntegers : CollectionOfIntegers
    {
        public int Count { get; private set; } = 0;

        public override void AddElement(int element)
        {
            base.AddElement(element);
            Count++;
        }

        public override void AddCollection(int[] elements)
        {
            base.AddCollection(elements);
            Count = Count + (elements?.Length ?? 0);
        }
    }
}
