namespace RangeIt.Iterators
{
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public static class IteratorExtensions
    {
        public static Iterator<T> Begin<T>(this T[] items) => new Iterator<T>(items);

        public static Iterator<T> End<T>(this T[] items) => new Iterator<T>(items, true);

        public static Iterator<T> Begin<T>(this List<T> list) => new Iterator<T>(list);

        public static Iterator<T> End<T>(this List<T> list) => new Iterator<T>(list, true);

        public static Iterator<T> Begin<T>(this Collection<T> collection) => new Iterator<T>(collection);

        public static Iterator<T> End<T>(this Collection<T> collection) => new Iterator<T>(collection, true);

        public static Iterator<T, U> Begin<T, U>(this KeyValuePair<T, U>[] items) => new Iterator<T, U>(items);

        public static Iterator<T, U> End<T, U>(this KeyValuePair<T, U>[] items) => new Iterator<T, U>(items, true);

        public static Iterator<T, U> Begin<T, U>(this Dictionary<T, U> dictionary) => new Iterator<T, U>(dictionary);

        public static Iterator<T, U> End<T, U>(this Dictionary<T, U> dictionary) => new Iterator<T, U>(dictionary, true);

        public static Iterator<T, U> Begin<T, U>(this ConcurrentDictionary<T, U> dictionary) => new Iterator<T, U>(dictionary);

        public static Iterator<T, U> End<T, U>(this ConcurrentDictionary<T, U> dictionary) => new Iterator<T, U>(dictionary, true);

        public static ConstIterator<T> ConstBegin<T>(this T[] items) => new ConstIterator<T>(items);

        public static ConstIterator<T> ConstEnd<T>(this T[] items) => new ConstIterator<T>(items, true);

        public static ConstIterator<T> ConstBegin<T>(this List<T> list) => new ConstIterator<T>(list);

        public static ConstIterator<T> ConstEnd<T>(this List<T> list) => new ConstIterator<T>(list, true);

        public static ConstIterator<T> ConstBegin<T>(this Collection<T> collection) => new ConstIterator<T>(collection);

        public static ConstIterator<T> ConstEnd<T>(this Collection<T> collection) => new ConstIterator<T>(collection, true);

        public static ConstIterator<T> ConstBegin<T>(this ReadOnlyCollection<T> collection) => new ConstIterator<T>(collection);

        public static ConstIterator<T> ConstEnd<T>(this ReadOnlyCollection<T> collection) => new ConstIterator<T>(collection, true);

        public static ConstIterator<T, U> ConstBegin<T, U>(this KeyValuePair<T, U>[] items) => new ConstIterator<T, U>(items);

        public static ConstIterator<T, U> ConstEnd<T, U>(this KeyValuePair<T, U>[] items) => new ConstIterator<T, U>(items, true);

        public static ConstIterator<T, U> ConstBegin<T, U>(this Dictionary<T, U> dictionary) => new ConstIterator<T, U>(dictionary);

        public static ConstIterator<T, U> ConstEnd<T, U>(this Dictionary<T, U> dictionary) => new ConstIterator<T, U>(dictionary, true);

        public static ConstIterator<T, U> ConstBegin<T, U>(this ReadOnlyDictionary<T, U> dictionary) => new ConstIterator<T, U>(dictionary);

        public static ConstIterator<T, U> ConstEnd<T, U>(this ReadOnlyDictionary<T, U> dictionary) => new ConstIterator<T, U>(dictionary, true);

        public static ConstIterator<T, U> ConstBegin<T, U>(this ConcurrentDictionary<T, U> dictionary) => new ConstIterator<T, U>(dictionary);

        public static ConstIterator<T, U> ConstEnd<T, U>(this ConcurrentDictionary<T, U> dictionary) => new ConstIterator<T, U>(dictionary, true);
    }
}
