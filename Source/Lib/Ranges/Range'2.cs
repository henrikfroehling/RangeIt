namespace Ranges
{
    using System.Collections;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;

    public sealed class Range<T, U> : IEnumerable<KeyValuePair<T, U>>
    {
        private Range()
        {
            Values = Enumerable.Empty<KeyValuePair<T, U>>();
        }

        public Range(IEnumerable<KeyValuePair<T, U>> values)
        {
            Values = values ?? Enumerable.Empty<KeyValuePair<T, U>>();
        }

        public IEnumerable<KeyValuePair<T, U>> Values { get; }

        public int Count => Values.Count();

        public override string ToString() => ToString(",");

        public string ToString(string separator) => string.Join(separator, Values);

        public IEnumerator<KeyValuePair<T, U>> GetEnumerator()
        {
            foreach (var val in Values)
                yield return val;
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public static explicit operator KeyValuePair<T, U>[] (Range<T, U> range) => range.Values.ToArray();

        public static implicit operator Range<T, U>(KeyValuePair<T, U>[] values) => new Range<T, U>(values);

        public static explicit operator List<KeyValuePair<T, U>>(Range<T, U> range) => range.Values.ToList();

        public static implicit operator Range<T, U>(List<KeyValuePair<T, U>> values) => new Range<T, U>(values);

        public static explicit operator LinkedList<KeyValuePair<T, U>>(Range<T, U> range) => new LinkedList<KeyValuePair<T, U>>(range.Values);

        public static implicit operator Range<T, U>(LinkedList<KeyValuePair<T, U>> values) => new Range<T, U>(values);

        public static explicit operator Queue<KeyValuePair<T, U>>(Range<T, U> range) => new Queue<KeyValuePair<T, U>>(range.Values);

        public static implicit operator Range<T, U>(Queue<KeyValuePair<T, U>> values) => new Range<T, U>(values);

        public static explicit operator Stack<KeyValuePair<T, U>>(Range<T, U> range) => new Stack<KeyValuePair<T, U>>(range.Values);

        public static implicit operator Range<T, U>(Stack<KeyValuePair<T, U>> values) => new Range<T, U>(values);

        public static explicit operator HashSet<KeyValuePair<T, U>>(Range<T, U> range) => new HashSet<KeyValuePair<T, U>>(range.Values);

        public static implicit operator Range<T, U>(HashSet<KeyValuePair<T, U>> values) => new Range<T, U>(values);

        public static explicit operator SortedSet<KeyValuePair<T, U>>(Range<T, U> range) => new SortedSet<KeyValuePair<T, U>>(range.Values);

        public static implicit operator Range<T, U>(SortedSet<KeyValuePair<T, U>> values) => new Range<T, U>(values);

        public static explicit operator ConcurrentBag<KeyValuePair<T, U>>(Range<T, U> range) => new ConcurrentBag<KeyValuePair<T, U>>(range.Values);

        public static implicit operator Range<T, U>(ConcurrentBag<KeyValuePair<T, U>> values) => new Range<T, U>(values);

        public static explicit operator ConcurrentQueue<KeyValuePair<T, U>>(Range<T, U> range) => new ConcurrentQueue<KeyValuePair<T, U>>(range.Values);

        public static implicit operator Range<T, U>(ConcurrentQueue<KeyValuePair<T, U>> values) => new Range<T, U>(values);

        public static explicit operator ConcurrentStack<KeyValuePair<T, U>>(Range<T, U> range) => new ConcurrentStack<KeyValuePair<T, U>>(range.Values);

        public static implicit operator Range<T, U>(ConcurrentStack<KeyValuePair<T, U>> values) => new Range<T, U>(values);

        public static explicit operator Dictionary<T, U>(Range<T, U> range)
            => range.Values.ToDictionary((kvp) => kvp.Key, (kvp) => kvp.Value);

        public static implicit operator Range<T, U>(Dictionary<T, U> values) => new Range<T, U>(values);

        public static explicit operator SortedDictionary<T, U>(Range<T, U> range)
        {
            var dictionary = range.Values.ToDictionary((kvp) => kvp.Key, (kvp) => kvp.Value);
            return new SortedDictionary<T, U>(dictionary);
        }

        public static implicit operator Range<T, U>(SortedDictionary<T, U> values) => new Range<T, U>(values);

        public static explicit operator ConcurrentDictionary<T, U>(Range<T, U> range) => new ConcurrentDictionary<T, U>(range.Values);

        public static implicit operator Range<T, U>(ConcurrentDictionary<T, U> values) => new Range<T, U>(values);
    }
}
