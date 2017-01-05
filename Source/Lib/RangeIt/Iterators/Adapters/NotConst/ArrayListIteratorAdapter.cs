namespace RangeIt.Iterators.Adapters.NotConst
{
    using Base;
    using Interfaces.Adapters;
    using System.Collections;

    internal sealed class ArrayListIteratorAdapter : BaseArrayListIteratorAdapter, IIteratorAdapter
    {
        internal ArrayListIteratorAdapter(ArrayList arrayList, bool isEnd = false) : base(arrayList, isEnd) { }

        public object Current
        {
            get { return _current; }

            set
            {
                if (_isEnd || _arrayList.IsReadOnly)
                    return;

                if (_index >= 0 && _index < _arrayList.Count)
                {
                    _current = value;
                    _arrayList[_index] = _current;
                }
            }
        }
    }
}
