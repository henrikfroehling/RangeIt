namespace RangeIt.Iterators
{
    using Adapters.Const;
    using Interfaces;
    using Interfaces.Adapters;
    using System.Collections;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    /// <summary>
    /// A helper class for iterating forwards and backward through a collection
    /// and manipulating its elements.
    /// <para />
    /// Changing the size of the underlying collection, while the iterator is used,
    /// leads to undefined behavior.
    /// </summary>
    /// <typeparam name="T">The type of the key element of the underlying collection.</typeparam>
    /// <typeparam name="U">The type of the value element of the underlying collection.</typeparam>
    public struct ConstIterator<T, U> : IConstIterator<T, U>, IIterable, IEnumerable<KeyValuePair<T, U>>
    {
        private readonly IConstIteratorAdapter<T, U> _iteratorAdapter;

        /// <summary>Initializes a new instance of the <see cref="ConstIterator{T, U}" /> struct.</summary>
        /// <param name="array">The array, for which this instance will be created.</param>
        public ConstIterator(KeyValuePair<T, U>[] array)
        {
            _iteratorAdapter = new ArrayConstIteratorAdapter<T, U>(array);
        }

        internal ConstIterator(KeyValuePair<T, U>[] array, bool isEnd)
        {
            _iteratorAdapter = new ArrayConstIteratorAdapter<T, U>(array, isEnd);
        }

        /// <summary>Initializes a new instance of the <see cref="ConstIterator{T, U}" /> struct.</summary>
        /// <param name="dictionary">The dictionary, for which this instance will be created.</param>
        public ConstIterator(Dictionary<T, U> dictionary)
        {
            _iteratorAdapter = new DictionaryConstIteratorAdapter<T, U>(dictionary);
        }

        internal ConstIterator(Dictionary<T, U> dictionary, bool isEnd)
        {
            _iteratorAdapter = new DictionaryConstIteratorAdapter<T, U>(dictionary, isEnd);
        }

        /// <summary>Initializes a new instance of the <see cref="ConstIterator{T, U}" /> struct.</summary>
        /// <param name="dictionary">The read only dictionary, for which this instance will be created.</param>
        public ConstIterator(ReadOnlyDictionary<T, U> dictionary)
        {
            _iteratorAdapter = new ReadOnlyDictionaryConstIteratorAdapter<T, U>(dictionary);
        }

        internal ConstIterator(ReadOnlyDictionary<T, U> dictionary, bool isEnd)
        {
            _iteratorAdapter = new ReadOnlyDictionaryConstIteratorAdapter<T, U>(dictionary, isEnd);
        }

        /// <summary>Initializes a new instance of the <see cref="ConstIterator{T, U}" /> struct.</summary>
        /// <param name="dictionary">The concurrent dictionary, for which this instance will be created.</param>
        public ConstIterator(ConcurrentDictionary<T, U> dictionary)
        {
            _iteratorAdapter = new ConcurrentDictionaryConstIteratorAdapter<T, U>(dictionary);
        }

        internal ConstIterator(ConcurrentDictionary<T, U> dictionary, bool isEnd)
        {
            _iteratorAdapter = new ConcurrentDictionaryConstIteratorAdapter<T, U>(dictionary, isEnd);
        }

        /// <summary>Returns the <see cref="KeyValuePair{TKey, TValue}" /> at the current iterator position.</summary>
        public KeyValuePair<T, U> Current => _iteratorAdapter.Current;

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
        /// See also <seealso cref="operator --(ConstIterator{T, U})" />.
        /// </summary>
        /// <returns>True, if iterator was moved, otherwise false.</returns>
        public bool Previous() => _iteratorAdapter.Previous();

        /// <summary>
        /// Moves the iterator one position forwards, if possible.
        /// <para />
        /// See also <seealso cref="operator ++(ConstIterator{T, U})" />.
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
        public static ConstIterator<T, U> operator --(ConstIterator<T, U> it)
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
        public static ConstIterator<T, U> operator ++(ConstIterator<T, U> it)
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
        public static ConstIterator<T, U> operator -(ConstIterator<T, U> it, int count)
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
        public static ConstIterator<T, U> operator +(ConstIterator<T, U> it, int count)
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
        public static implicit operator bool(ConstIterator<T, U> it) => it.IsValid;

        /// <summary>
        /// Casts the iterator to the element type of its collection
        /// and returns the value of the current position.
        /// <para />
        /// See also <see cref="Current" />.
        /// </summary>
        /// <param name="it"></param>
        public static explicit operator KeyValuePair<T, U>(ConstIterator<T, U> it) => it.Current;
    }
}
