using System.Collections;
using System.ComponentModel;

namespace algrithm
{
    internal class DArray<T> : IEnumerable<T> // : IEnumerable<T> means the Darray is Enumerable now given that it implement this interface
    {
        public DArray()
        {
            mData = new T[INITIAL_SIZE]; // start with an array with initial size
            mSize = 0; // the size of the array starts with 0. mSize also indicates the next avaliable slot to add a new element.
        }

        public int Size
        {
            get { return mSize; }
        }

        public T this[int index]
        {
            get
            {
                return Get(index);
            }
            set { 
                Set(value, index);
            }
        }

        public void Add(T newItem)
        {
            if(mSize == mData.Length) // are we reaching to the maximum capacity of the internal array?
            {
                Expand(mSize); // if we are, expand our capacity.
            }

            mData[mSize] = newItem;
            ++mSize;
        }

        private void Set(T newItem, int index)
        {
            EnsureRange(index);
            mData[index] = newItem;

        }
        private T Get(int index)
        {
            EnsureRange(index);
            return mData[index];
        }

        private void EnsureRange(int index)
        {
            if (index < 0 || index >= mSize)
            {
                throw new IndexOutOfRangeException($"{this}: index {index} is out of range ({0},{mSize - 1})");
            }
        }

        private void Expand(int expandAmt)
        { 
            //create a new int[] that is the size mSize + expandAmt
            T[] newArray = new T[mSize + expandAmt];

            //copy the values from mData to the new int[]
            for(int i = 0; i < mData.Length; ++i)
            {
                newArray[i] = mData[i];
            }
            
            //make mData = the new list
            mData = newArray;
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return mData.GetEnumerator();
        }

        static private readonly int INITIAL_SIZE = 10;
        private T[] mData;
        private int mSize;
    }

    class DArrayEnumerator<T> : IEnumerator<T>
    {
        private DArray<T> mOwner;
        private int mIndex;
        public DArrayEnumerator(DArray<T> owner)
        {
            mOwner = owner;
            mIndex = -1;
        }

        public T Current => mOwner[mIndex];

        object IEnumerator.Current => mOwner[mIndex];

        public void Dispose()
        {
            //if yours handles online connects, file stream, you clean them up here.
        }

        public bool MoveNext()
        {
            if(mIndex < mOwner.Size)
            {
                mIndex++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            mIndex = -1;
        }
    }
}
