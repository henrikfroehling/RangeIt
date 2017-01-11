namespace RangeIt.Iterators
{
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public static class IteratorExtensions
    {
        /// <summary>
        /// Creates a <see cref="Iterator{T}" /> for the given <paramref name="array" />.
        /// <para />
        /// The returned iterator is positioned before the first element in the given <paramref name="array" />.
        /// </summary>
        /// <typeparam name="T">The type of element in the given <paramref name="array" />.</typeparam>
        /// <param name="array">The array, for which the iterator will be created.</param>
        /// <returns>A <see cref="Iterator{T}" /> instance.</returns>
        public static Iterator<T> Begin<T>(this T[] array) => new Iterator<T>(array);

        /// <summary>
        /// Creates a <see cref="Iterator{T}" /> for the given <paramref name="array" />.
        /// <para />
        /// The returned iterator is positioned after the last element in the given <paramref name="array" />.
        /// </summary>
        /// <typeparam name="T">The type of element in the given <paramref name="array" />.</typeparam>
        /// <param name="array">The array, for which the iterator will be created.</param>
        /// <returns>A <see cref="Iterator{T}" /> instance.</returns>
        public static Iterator<T> End<T>(this T[] array) => new Iterator<T>(array, true);

        /// <summary>
        /// Creates a <see cref="Iterator{T}" /> for the given <paramref name="list" />.
        /// <para />
        /// The returned iterator is positioned before the first element in the given <paramref name="list" />.
        /// </summary>
        /// <typeparam name="T">The type of element in the given <paramref name="list" />.</typeparam>
        /// <param name="list">The list, for which the iterator will be created.</param>
        /// <returns>A <see cref="Iterator{T}" /> instance.</returns>
        public static Iterator<T> Begin<T>(this List<T> list) => new Iterator<T>(list);

        /// <summary>
        /// Creates a <see cref="Iterator{T}" /> for the given <paramref name="list" />.
        /// <para />
        /// The returned iterator is positioned after the last element in the given <paramref name="list" />.
        /// </summary>
        /// <typeparam name="T">The type of element in the given <paramref name="list" />.</typeparam>
        /// <param name="list">The list, for which the iterator will be created.</param>
        /// <returns>A <see cref="Iterator{T}" /> instance.</returns>
        public static Iterator<T> End<T>(this List<T> list) => new Iterator<T>(list, true);

        /// <summary>
        /// Creates a <see cref="Iterator{T}" /> for the given <paramref name="collection" />.
        /// <para />
        /// The returned iterator is positioned before the first element in the given <paramref name="collection" />.
        /// </summary>
        /// <typeparam name="T">The type of element in the given <paramref name="collection" />.</typeparam>
        /// <param name="collection">The collection, for which the iterator will be created.</param>
        /// <returns>A <see cref="Iterator{T}" /> instance.</returns>
        public static Iterator<T> Begin<T>(this Collection<T> collection) => new Iterator<T>(collection);

        /// <summary>
        /// Creates a <see cref="Iterator{T}" /> for the given <paramref name="collection" />.
        /// <para />
        /// The returned iterator is positioned after the last element in the given <paramref name="collection" />.
        /// </summary>
        /// <typeparam name="T">The type of element in the given <paramref name="collection" />.</typeparam>
        /// <param name="collection">The collection, for which the iterator will be created.</param>
        /// <returns>A <see cref="Iterator{T}" /> instance.</returns>
        public static Iterator<T> End<T>(this Collection<T> collection) => new Iterator<T>(collection, true);

        /// <summary>
        /// Creates a <see cref="Iterator{T, U}" /> for the given <paramref name="keyValuePairs" /> array.
        /// <para />
        /// The returned iterator is positioned before the first element in the given <paramref name="keyValuePairs" /> array.
        /// </summary>
        /// <typeparam name="T">The type of the key element in the given <paramref name="keyValuePairs" /> array.</typeparam>
        /// <typeparam name="U">The type of the value element in the given <paramref name="keyValuePairs" /> array.</typeparam>
        /// <param name="keyValuePairs">The array of key value pairs, for which the iterator will be created.</param>
        /// <returns>A <see cref="Iterator{T, U}" /> instance.</returns>
        public static Iterator<T, U> Begin<T, U>(this KeyValuePair<T, U>[] keyValuePairs) => new Iterator<T, U>(keyValuePairs);

        /// <summary>
        /// Creates a <see cref="Iterator{T, U}" /> for the given <paramref name="keyValuePairs" /> array.
        /// <para />
        /// The returned iterator is positioned after the last element in the given <paramref name="keyValuePairs" /> array.
        /// </summary>
        /// <typeparam name="T">The type of the key element in the given <paramref name="keyValuePairs" /> array.</typeparam>
        /// <typeparam name="U">The type of the value element in the given <paramref name="keyValuePairs" /> array.</typeparam>
        /// <param name="keyValuePairs">The array of key value pairs, for which the iterator will be created.</param>
        /// <returns>A <see cref="Iterator{T, U}" /> instance.</returns>
        public static Iterator<T, U> End<T, U>(this KeyValuePair<T, U>[] keyValuePairs) => new Iterator<T, U>(keyValuePairs, true);

        /// <summary>
        /// Creates a <see cref="Iterator{T, U}" /> for the given <paramref name="dictionary" />.
        /// <para />
        /// The returned iterator is positioned before the first element in the given <paramref name="dictionary" />.
        /// </summary>
        /// <typeparam name="T">The type of the key element in the given <paramref name="dictionary" />.</typeparam>
        /// <typeparam name="U">The type of the value element in the given <paramref name="dictionary" />.</typeparam>
        /// <param name="dictionary">The dictionary, for which the iterator will be created.</param>
        /// <returns>A <see cref="Iterator{T, U}" /> instance.</returns>
        public static Iterator<T, U> Begin<T, U>(this Dictionary<T, U> dictionary) => new Iterator<T, U>(dictionary);

        /// <summary>
        /// Creates a <see cref="Iterator{T, U}" /> for the given <paramref name="dictionary" />.
        /// <para />
        /// The returned iterator is positioned after the last element in the given <paramref name="dictionary" />.
        /// </summary>
        /// <typeparam name="T">The type of the key element in the given <paramref name="dictionary" />.</typeparam>
        /// <typeparam name="U">The type of the value element in the given <paramref name="dictionary" />.</typeparam>
        /// <param name="dictionary">The dictionary, for which the iterator will be created.</param>
        /// <returns>A <see cref="Iterator{T, U}" /> instance.</returns>
        public static Iterator<T, U> End<T, U>(this Dictionary<T, U> dictionary) => new Iterator<T, U>(dictionary, true);

        /// <summary>
        /// Creates a <see cref="Iterator{T, U}" /> for the given concurrent <paramref name="dictionary" />.
        /// <para />
        /// The returned iterator is positioned before the first element in the given concurrent <paramref name="dictionary" />.
        /// </summary>
        /// <typeparam name="T">The type of the key element in the given concurrent <paramref name="dictionary" />.</typeparam>
        /// <typeparam name="U">The type of the value element in the given concurrent <paramref name="dictionary" />.</typeparam>
        /// <param name="dictionary">The concurrent dictionary, for which the iterator will be created.</param>
        /// <returns>A <see cref="Iterator{T, U}" /> instance.</returns>
        public static Iterator<T, U> Begin<T, U>(this ConcurrentDictionary<T, U> dictionary) => new Iterator<T, U>(dictionary);

        /// <summary>
        /// Creates a <see cref="Iterator{T, U}" /> for the given concurrent <paramref name="dictionary" />.
        /// <para />
        /// The returned iterator is positioned after the last element in the given concurrent <paramref name="dictionary" />.
        /// </summary>
        /// <typeparam name="T">The type of the key element in the given concurrent <paramref name="dictionary" />.</typeparam>
        /// <typeparam name="U">The type of the value element in the given concurrent <paramref name="dictionary" />.</typeparam>
        /// <param name="dictionary">The concurrent dictionary, for which the iterator will be created.</param>
        /// <returns>A <see cref="Iterator{T, U}" /> instance.</returns>
        public static Iterator<T, U> End<T, U>(this ConcurrentDictionary<T, U> dictionary) => new Iterator<T, U>(dictionary, true);

        /// <summary>
        /// Creates a <see cref="ConstIterator{T}" /> for the given <paramref name="array" />.
        /// <para />
        /// The returned iterator is positioned before the first element in the given <paramref name="array" />.
        /// </summary>
        /// <typeparam name="T">The type of element in the given <paramref name="array" />.</typeparam>
        /// <param name="array">The array, for which the iterator will be created.</param>
        /// <returns>A <see cref="ConstIterator{T}" /> instance.</returns>
        public static ConstIterator<T> ConstBegin<T>(this T[] array) => new ConstIterator<T>(array);

        /// <summary>
        /// Creates a <see cref="ConstIterator{T}" /> for the given <paramref name="array" />.
        /// <para />
        /// The returned iterator is positioned after the last element in the given <paramref name="array" />.
        /// </summary>
        /// <typeparam name="T">The type of element in the given <paramref name="array" />.</typeparam>
        /// <param name="array">The array, for which the iterator will be created.</param>
        /// <returns>A <see cref="ConstIterator{T}" /> instance.</returns>
        public static ConstIterator<T> ConstEnd<T>(this T[] array) => new ConstIterator<T>(array, true);

        /// <summary>
        /// Creates a <see cref="ConstIterator{T}" /> for the given <paramref name="list" />.
        /// <para />
        /// The returned iterator is positioned before the first element in the given <paramref name="list" />.
        /// </summary>
        /// <typeparam name="T">The type of element in the given <paramref name="list" />.</typeparam>
        /// <param name="list">The list, for which the iterator will be created.</param>
        /// <returns>A <see cref="ConstIterator{T}" /> instance.</returns>
        public static ConstIterator<T> ConstBegin<T>(this List<T> list) => new ConstIterator<T>(list);

        /// <summary>
        /// Creates a <see cref="ConstIterator{T}" /> for the given <paramref name="list" />.
        /// <para />
        /// The returned iterator is positioned after the last element in the given <paramref name="list" />.
        /// </summary>
        /// <typeparam name="T">The type of element in the given <paramref name="list" />.</typeparam>
        /// <param name="list">The list, for which the iterator will be created.</param>
        /// <returns>A <see cref="ConstIterator{T}" /> instance.</returns>
        public static ConstIterator<T> ConstEnd<T>(this List<T> list) => new ConstIterator<T>(list, true);

        /// <summary>
        /// Creates a <see cref="ConstIterator{T}" /> for the given <paramref name="collection" />.
        /// <para />
        /// The returned iterator is positioned before the first element in the given <paramref name="collection" />.
        /// </summary>
        /// <typeparam name="T">The type of element in the given <paramref name="collection" />.</typeparam>
        /// <param name="collection">The collection, for which the iterator will be created.</param>
        /// <returns>A <see cref="ConstIterator{T}" /> instance.</returns>
        public static ConstIterator<T> ConstBegin<T>(this Collection<T> collection) => new ConstIterator<T>(collection);

        /// <summary>
        /// Creates a <see cref="ConstIterator{T}" /> for the given <paramref name="collection" />.
        /// <para />
        /// The returned iterator is positioned after the last element in the given <paramref name="collection" />.
        /// </summary>
        /// <typeparam name="T">The type of element in the given <paramref name="collection" />.</typeparam>
        /// <param name="collection">The collection, for which the iterator will be created.</param>
        /// <returns>A <see cref="ConstIterator{T}" /> instance.</returns>
        public static ConstIterator<T> ConstEnd<T>(this Collection<T> collection) => new ConstIterator<T>(collection, true);

        /// <summary>
        /// Creates a <see cref="ConstIterator{T}" /> for the given read only <paramref name="collection" />.
        /// <para />
        /// The returned iterator is positioned before the first element in the given read only <paramref name="collection" />.
        /// </summary>
        /// <typeparam name="T">The type of element in the given read only <paramref name="collection" />.</typeparam>
        /// <param name="collection">The read only collection, for which the iterator will be created.</param>
        /// <returns>A <see cref="ConstIterator{T}" /> instance.</returns>
        public static ConstIterator<T> ConstBegin<T>(this ReadOnlyCollection<T> collection) => new ConstIterator<T>(collection);

        /// <summary>
        /// Creates a <see cref="ConstIterator{T}" /> for the given read only <paramref name="collection" />.
        /// <para />
        /// The returned iterator is positioned after the last element in the given read only <paramref name="collection" />.
        /// </summary>
        /// <typeparam name="T">The type of element in the given read only <paramref name="collection" />.</typeparam>
        /// <param name="collection">The read only collection, for which the iterator will be created.</param>
        /// <returns>A <see cref="ConstIterator{T}" /> instance.</returns>
        public static ConstIterator<T> ConstEnd<T>(this ReadOnlyCollection<T> collection) => new ConstIterator<T>(collection, true);

        /// <summary>
        /// Creates a <see cref="ConstIterator{T, U}" /> for the given <paramref name="keyValuePairs" /> array.
        /// <para />
        /// The returned iterator is positioned before the first element in the given <paramref name="keyValuePairs" /> array.
        /// </summary>
        /// <typeparam name="T">The type of the key element in the given <paramref name="keyValuePairs" /> array.</typeparam>
        /// <typeparam name="U">The type of the value element in the given <paramref name="keyValuePairs" /> array.</typeparam>
        /// <param name="keyValuePairs">The array of key value pairs, for which the iterator will be created.</param>
        /// <returns>A <see cref="ConstIterator{T, U}" /> instance.</returns>
        public static ConstIterator<T, U> ConstBegin<T, U>(this KeyValuePair<T, U>[] keyValuePairs) => new ConstIterator<T, U>(keyValuePairs);

        /// <summary>
        /// Creates a <see cref="ConstIterator{T, U}" /> for the given <paramref name="keyValuePairs" /> array.
        /// <para />
        /// The returned iterator is positioned after the last element in the given <paramref name="keyValuePairs" /> array.
        /// </summary>
        /// <typeparam name="T">The type of the key element in the given <paramref name="keyValuePairs" /> array.</typeparam>
        /// <typeparam name="U">The type of the value element in the given <paramref name="keyValuePairs" /> array.</typeparam>
        /// <param name="keyValuePairs">The array of key value pairs, for which the iterator will be created.</param>
        /// <returns>A <see cref="ConstIterator{T, U}" /> instance.</returns>
        public static ConstIterator<T, U> ConstEnd<T, U>(this KeyValuePair<T, U>[] keyValuePairs) => new ConstIterator<T, U>(keyValuePairs, true);

        /// <summary>
        /// Creates a <see cref="ConstIterator{T, U}" /> for the given <paramref name="dictionary" />.
        /// <para />
        /// The returned iterator is positioned before the first element in the given <paramref name="dictionary" />.
        /// </summary>
        /// <typeparam name="T">The type of the key element in the given <paramref name="dictionary" />.</typeparam>
        /// <typeparam name="U">The type of the value element in the given <paramref name="dictionary" />.</typeparam>
        /// <param name="dictionary">The dictionary, for which the iterator will be created.</param>
        /// <returns>A <see cref="ConstIterator{T, U}" /> instance.</returns>
        public static ConstIterator<T, U> ConstBegin<T, U>(this Dictionary<T, U> dictionary) => new ConstIterator<T, U>(dictionary);

        /// <summary>
        /// Creates a <see cref="ConstIterator{T, U}" /> for the given <paramref name="dictionary" />.
        /// <para />
        /// The returned iterator is positioned after the last element in the given <paramref name="dictionary" />.
        /// </summary>
        /// <typeparam name="T">The type of the key element in the given <paramref name="dictionary" />.</typeparam>
        /// <typeparam name="U">The type of the value element in the given <paramref name="dictionary" />.</typeparam>
        /// <param name="dictionary">The dictionary, for which the iterator will be created.</param>
        /// <returns>A <see cref="ConstIterator{T, U}" /> instance.</returns>
        public static ConstIterator<T, U> ConstEnd<T, U>(this Dictionary<T, U> dictionary) => new ConstIterator<T, U>(dictionary, true);

        /// <summary>
        /// Creates a <see cref="ConstIterator{T, U}" /> for the given read only <paramref name="dictionary" />.
        /// <para />
        /// The returned iterator is positioned before the first element in the given read only <paramref name="dictionary" />.
        /// </summary>
        /// <typeparam name="T">The type of the key element in the given read only <paramref name="dictionary" />.</typeparam>
        /// <typeparam name="U">The type of the value element in the given read only <paramref name="dictionary" />.</typeparam>
        /// <param name="dictionary">The read only dictionary, for which the iterator will be created.</param>
        /// <returns>A <see cref="ConstIterator{T, U}" /> instance.</returns>
        public static ConstIterator<T, U> ConstBegin<T, U>(this ReadOnlyDictionary<T, U> dictionary) => new ConstIterator<T, U>(dictionary);

        /// <summary>
        /// Creates a <see cref="ConstIterator{T, U}" /> for the given read only <paramref name="dictionary" />.
        /// <para />
        /// The returned iterator is positioned after the last element in the given read only <paramref name="dictionary" />.
        /// </summary>
        /// <typeparam name="T">The type of the key element in the given read only <paramref name="dictionary" />.</typeparam>
        /// <typeparam name="U">The type of the value element in the given read only <paramref name="dictionary" />.</typeparam>
        /// <param name="dictionary">The read only dictionary, for which the iterator will be created.</param>
        /// <returns>A <see cref="ConstIterator{T, U}" /> instance.</returns>
        public static ConstIterator<T, U> ConstEnd<T, U>(this ReadOnlyDictionary<T, U> dictionary) => new ConstIterator<T, U>(dictionary, true);

        /// <summary>
        /// Creates a <see cref="ConstIterator{T, U}" /> for the given concurrent <paramref name="dictionary" />.
        /// <para />
        /// The returned iterator is positioned before the first element in the given concurrent <paramref name="dictionary" />.
        /// </summary>
        /// <typeparam name="T">The type of the key element in the given concurrent <paramref name="dictionary" />.</typeparam>
        /// <typeparam name="U">The type of the value element in the given concurrent <paramref name="dictionary" />.</typeparam>
        /// <param name="dictionary">The concurrent dictionary, for which the iterator will be created.</param>
        /// <returns>A <see cref="ConstIterator{T, U}" /> instance.</returns>
        public static ConstIterator<T, U> ConstBegin<T, U>(this ConcurrentDictionary<T, U> dictionary) => new ConstIterator<T, U>(dictionary);

        /// <summary>
        /// Creates a <see cref="ConstIterator{T, U}" /> for the given concurrent <paramref name="dictionary" />.
        /// <para />
        /// The returned iterator is positioned after the last element in the given concurrent <paramref name="dictionary" />.
        /// </summary>
        /// <typeparam name="T">The type of the key element in the given concurrent <paramref name="dictionary" />.</typeparam>
        /// <typeparam name="U">The type of the value element in the given concurrent <paramref name="dictionary" />.</typeparam>
        /// <param name="dictionary">The concurrent dictionary, for which the iterator will be created.</param>
        /// <returns>A <see cref="ConstIterator{T, U}" /> instance.</returns>
        public static ConstIterator<T, U> ConstEnd<T, U>(this ConcurrentDictionary<T, U> dictionary) => new ConstIterator<T, U>(dictionary, true);
    }
}
