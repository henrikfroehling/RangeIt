namespace RangeIt.Ranges
{
    using System.Collections;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;

    public sealed class Range<T> : IEnumerable<T>
    {
        private Range()
        {
            Values = Enumerable.Empty<T>();
        }

        public Range(IEnumerable<T> values)
        {
            Values = values ?? Enumerable.Empty<T>();
        }

        public IEnumerable<T> Values { get; }

        public int Count => Values.Count();

        public override string ToString() => ToString(",");

        public string ToString(string separator) => string.Join(separator, Values);

        public IEnumerator<T> GetEnumerator() => Values.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public static explicit operator T[] (Range<T> range) => range.Values.ToArray();

        public static implicit operator Range<T>(T[] values) => new Range<T>(values);

        public static explicit operator List<T>(Range<T> range) => range.Values.ToList();

        public static implicit operator Range<T>(List<T> values) => new Range<T>(values);

        public static explicit operator LinkedList<T>(Range<T> range) => new LinkedList<T>(range.Values);

        public static implicit operator Range<T>(LinkedList<T> values) => new Range<T>(values);

        public static explicit operator Queue<T>(Range<T> range) => new Queue<T>(range.Values);

        public static implicit operator Range<T>(Queue<T> values) => new Range<T>(values);

        public static explicit operator Stack<T>(Range<T> range) => new Stack<T>(range.Values);

        public static implicit operator Range<T>(Stack<T> values) => new Range<T>(values);

        public static explicit operator HashSet<T>(Range<T> range) => new HashSet<T>(range.Values);

        public static implicit operator Range<T>(HashSet<T> values) => new Range<T>(values);

        public static explicit operator SortedSet<T>(Range<T> range) => new SortedSet<T>(range.Values);

        public static implicit operator Range<T>(SortedSet<T> values) => new Range<T>(values);

        public static explicit operator ConcurrentBag<T>(Range<T> range) => new ConcurrentBag<T>(range.Values);

        public static implicit operator Range<T>(ConcurrentBag<T> values) => new Range<T>(values);

        public static explicit operator ConcurrentQueue<T>(Range<T> range) => new ConcurrentQueue<T>(range.Values);

        public static implicit operator Range<T>(ConcurrentQueue<T> values) => new Range<T>(values);

        public static explicit operator ConcurrentStack<T>(Range<T> range) => new ConcurrentStack<T>(range.Values);

        public static implicit operator Range<T>(ConcurrentStack<T> values) => new Range<T>(values);
    }
}
