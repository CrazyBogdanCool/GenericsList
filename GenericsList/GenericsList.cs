using System;

namespace GenericsListTests
{
    public class GenericsList<T>
    {
        private T[] _list = Array.Empty<T>();

        public T this[int index]
        {
            get { return _list[index]; }

            set { _list[index] = value; }
        }

        public int Count { get { return _list.Length; } }

        public void Add(T value)
        {
            var newList = new T[_list.Length + 1];

            for (int i = 0; i < _list.Length; i++)
            {
                newList[i] = _list[i];
            }

            newList[_list.Length] = value;

            _list = newList;
        }

        public bool Remove(T value)
        {
            int indexToRemove = -1;

            for (int i = 0; i < _list.Length; i++)
            {
                if (_list[i].Equals(value))
                {
                    indexToRemove = i;
                    break;
                }
            }

            if (indexToRemove == -1)
            {
                return false;
            }

            var newList = new T[_list.Length - 1];

            for (int i = 0, j = 0; i < _list.Length; i++)
            {
                if (i == indexToRemove)
                {
                    continue;
                }

                newList[j++] = _list[i];
            }

            _list = newList;

            return true;
        }

        public void Clear()
        {
            _list = Array.Empty<T>();
        }

        public bool Contains(T value)
        {
            foreach (T item in _list)
            {
                if (item.Equals(value))
                {
                    return true;
                }
            }
            return false;
        }
    }
}