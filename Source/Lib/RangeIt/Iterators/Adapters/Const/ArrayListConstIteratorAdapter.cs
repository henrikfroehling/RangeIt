namespace RangeIt.Iterators.Adapters.Const
{
    using Base;
    using Interfaces.Adapters;
    using System.Collections;

    internal sealed class ArrayListConstIteratorAdapter : BaseArrayListIteratorAdapter, IConstIteratorAdapter
    {
        internal ArrayListConstIteratorAdapter(ArrayList arrayList, bool isEnd = false) : base(arrayList, isEnd) { }

        public object Current => _current;
    }
}
