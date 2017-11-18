namespace RangeIt.Iterators
{
    using Adapters.NotConst;
    using Interfaces;
    using Interfaces.Adapters;
    using System.Collections;
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    /// <summary>
    /// A helper class for iterating forwards and backward through a collection
    /// and manipulating its elements.
    /// <para />
    /// Changing the size of the underlying collection, while the iterator is used,
    /// leads to undefined behavior.
    /// </summary>
    /// <typeparam name="T">The type of the key element of the underlying collection.</typeparam>
    /// <typeparam name="U">The type of the value element of the underlying collection.</typeparam>
    public struct Iterator<T, U> : IIterator<T, U>, IIterable, IEnumerable<KeyValuePair<T, U>>
    {
        private readonly IIteratorAdapter<T, U> _iteratorAdapter;

        /// <summary>Initializes a new instance of the <see cref="Iterator{T, U}" /> struct.</summary>
        /// <param name="array">The array, for which this instance will be created.</param>
        public Iterator(KeyValuePair<T, U>[] array)
        {
            _iteratorAdapter = new ArrayIteratorAdapter<T, U>(array);
        }

        internal Iterator(KeyValuePair<T, U>[] array, bool isEnd)
        {
            _iteratorAdapter = new ArrayIteratorAdapter<T, U>(array, isEnd);
        }

        /// <summary>Initializes a new instance of the <see cref="Iterator{T, U}" /> struct.</summary>
        /// <param name="dictionary">The dictionary, for which this instance will be created.</param>
        public Iterator(Dictionary<T, U> dictionary)
        {
            _iteratorAdapter = new DictionaryIteratorAdapter<T, U>(dictionary);
        }

        internal Iterator(Dictionary<T, U> dictionary, bool isEnd)
        {
            _iteratorAdapter = new DictionaryIteratorAdapter<T, U>(dictionary, isEnd);
        }

        /// <summary>Initializes a new instance of the <see cref="Iterator{T, U}" /> struct.</summary>
        /// <param name="dictionary">The concurrent dictionary, for which this instance will be created.</param>
        public Iterator(ConcurrentDictionary<T, U> dictionary)
        {
            _iteratorAdapter = new ConcurrentDictionaryIteratorAdapter<T, U>(dictionary);
        }

        internal Iterator(ConcurrentDictionary<T, U> dictionary, bool isEnd)
        {
            _iteratorAdapter = new ConcurrentDictionaryIteratorAdapter<T, U>(dictionary, isEnd);
        }

        /// <summary>
        /// Gets or sets the <see cref="KeyValuePair{TKey, TValue}" /> at the current iterator position.
        /// <para />
        /// Nothing is changed if the iterator is positioned before the first element or
        /// after the last element of the underlying collection.
        /// </summary>
        public KeyValuePair<T, U> Current
        {
            get { return _iteratorAdapter.Current; }
            set { _iteratorAdapter.Current = value; }
        }

        /// <summary>Returns the key of the element at the current iterator position.</summary>
        public T Key => _iteratorAdapter.Key;

        /// <summary>Returns the value of the element at the current iterator position.</summary>
        public U Value => _iteratorAdapter.Value;

        /// <summary>Returns the index of the current position of the iterator.</summary>
        public int Index => _iteratorAdapter.Index;

        /// <summary>Returns, whether the iterator is positioned after the last element in the collection.</summary>
        public bool IsEndIterator => _iteratorAdapter.IsEndIterator;

        /// <summary>Returns, whether the iterator is positioned at a valid position in the collection.</summary>
        public bool IsValid => _iteratorAdapter.IsValid;

        /// <summary>
        /// Moves the iterator one position backward, if possible.
        /// <para />
        /// See also <seealso cref="operator --(Iterator{T, U})" />.
        /// </summary>
        /// <returns>True, if iterator was moved, otherwise false.</returns>
        public bool Previous() => _iteratorAdapter.Previous();

        /// <summary>
        /// Moves the iterator one position forwards, if possible.
        /// <para />
        /// See also <seealso cref="operator ++(Iterator{T, U})" />.
        /// </summary>
        /// <returns>True, if iterator was moved, otherwise false.</returns>
        public bool Next() => _iteratorAdapter.Next();

        /// <summary>Returns a <see cref="IEnumerator{T}" /> for the underlying collection.</summary>
        /// <returns>A <see cref="IEnumerator{T}" />.</returns>
        public IEnumerator<KeyValuePair<T, U>> GetEnumerator() => _iteratorAdapter.GetEnumerator();

        /// <summary>Returns a <see cref="IEnumerator" /> for the underlying collection.</summary>
        /// <returns>A <see cref="IEnumerator" />.</returns>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        /// <summary>
        /// Returns a string that represents the current position of the iterator.
        /// <para />
        /// See also <seealso cref="Current" />.
        /// </summary>
        /// <returns>A string representing the current position of the iterator.</returns>
        public override string ToString() => Current.ToString();

        /// <summary>
        /// Moves the given iterator one position backward, if possible.
        /// <para />
        /// See also <seealso cref="Previous()" />.
        /// </summary>
        /// <param name="it">The iterator, which will be moved by one position.</param>
        /// <returns>True, if the given iterator was moved, otherwise false.</returns>
        public static Iterator<T, U> operator --(Iterator<T, U> it)
        {
            it.Previous();
            return it;
        }

        /// <summary>
        /// Moves the given iterator one position forwards, if possible.
        /// <para />
        /// See also <seealso cref="Next()" />.
        /// </summary>
        /// <param name="it">The iterator, which will be moved by one position.</param>
        /// <returns>True, if the given iterator was moved, otherwise false.</returns>
        public static Iterator<T, U> operator ++(Iterator<T, U> it)
        {
            it.Next();
            return it;
        }

        /// <summary>
        /// Moves the given iterator a given number of positions backward, if possible.
        /// <para />
        /// See also <seealso cref="Previous()" />.
        /// </summary>
        /// <param name="it">The iterator, which will be moved <paramref name="count"/> positions.</param>
        /// <param name="count">The number of positions the iterator will be moved.</param>
        /// <returns>The moved iterator. No new instance will be created.</returns>
        public static Iterator<T, U> operator -(Iterator<T, U> it, int count)
        {
            for (int i = count; i > 0; --i)
            {
                if (!it.Previous())
                    break;
            }

            return it;
        }

        /// <summary>
        /// Moves the given iterator a given number of positions forwards, if possible.
        /// <para />
        /// See also <seealso cref="Previous()" />.
        /// </summary>
        /// <param name="it">The iterator, which will be moved <paramref name="count"/> positions.</param>
        /// <param name="count">The number of positions the iterator will be moved.</param>
        /// <returns>The moved iterator. No new instance will be created.</returns>
        public static Iterator<T, U> operator +(Iterator<T, U> it, int count)
        {
            for (int i = 0; i < count; ++i)
            {
                if (!it.Next())
                    break;
            }

            return it;
        }

        /// <summary>
        /// Returns, whether the iterator is positioned at a valid position in the collection.
        /// <para />
        /// See also <seealso cref="IsValid" />.
        /// </summary>
        /// <param name="it"></param>
        public static implicit operator bool(Iterator<T, U> it) => it.IsValid;

        /// <summary>
        /// Casts the iterator to the element type of its collection
        /// and returns the value of the current position.
        /// <para />
        /// See also <see cref="Current" />.
        /// </summary>
        /// <param name="it"></param>
        public static explicit operator KeyValuePair<T, U>(Iterator<T, U> it) => it.Current;
    }
}
