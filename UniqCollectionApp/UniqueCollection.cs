using System;
using System.Collections;

namespace UniqCollectionApp
{
    public class UniqueCollection<T> : IList
    {
        const int SizeMultiplicator = 2;

        const int InitialSize = 10;

        public UniqueCollection()
        {
            if (_internalArray == null)
                _internalArray = new T[InitialSize];
        }

        private T[] _internalArray;

        public T this[int index]
        {
            get
            {
                if (_internalArray[index] != null)
                    return _internalArray[index];
                return default(T);
            }

            set { Add(value); }
        }

        object IList.this[int index]
        {
            get
            {
                if (_internalArray[index] != null)
                    return _internalArray[index];
                return null;
            }

            set { Add(value); }
        }

        public bool IsReadOnly => false;

        public bool IsFixedSize => false;

        public int Count
        {
            get { return _count; }
            private set { _count = value; }
        }

        private int _count = 0;

        public object SyncRoot => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();

        public int Add(object value)
        {
            if (!Contains(value))
                _internalArray[Count] = (T)value;

            var previousCount = Count;
            var nextCount = ++Count;
            if (nextCount >= _internalArray.Length)
                Array.Resize<T>(ref _internalArray, Count * SizeMultiplicator);

            return previousCount;
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(object value)
        {
            foreach (var item in _internalArray)
                if (item.GetHashCode() == value.GetHashCode())
                    return true;

            return false;
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            return _internalArray.GetEnumerator();
        }

        public int IndexOf(object value)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, object value)
        {
            throw new NotImplementedException();
        }

        public void Remove(object value)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }
    }
}
