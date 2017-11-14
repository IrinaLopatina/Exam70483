using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam70483_4
{
    class MyCollection<T> : IEnumerable<T>, ICollection<T>, IList<T> where T: IThreeDimensional, IEquatable<T>
    { 
        // The inner collection to store objects.
        List<T> innerCol = new List<T>();

        #region IList

        //Gets or sets the element at the specified index
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= innerCol.Count)
                    throw new IndexOutOfRangeException("Invalid index!!");
                return innerCol[index];
            }
            set
            {
                if (!Contains(value))
                {
                    innerCol[index] = value;
                }
            }
        }

        //Determines the index of a spesific item
        public int IndexOf(T item)
        {
            var index = -1;
            for (var i = 0; i < innerCol.Count; i++)
            {
                if (innerCol[i].Equals(item))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        //Inserts an item at the specified index
        public void Insert(int index, T item)
        {
            if (index < 0 || index >= innerCol.Count)
                throw new IndexOutOfRangeException("Invalid index!!");

            if (!Contains(item))
            {
                innerCol.Insert(index, item);
            }
        }

        //Remove the item at the specified index
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= innerCol.Count)
                throw new IndexOutOfRangeException("Invalid index!!");

            innerCol.RemoveAt(index);
        }


        #endregion IList

        #region ICollection<T> members

        public int Count
        {
            get { return innerCol.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        // Adds an item if it is not already in the collection
        // as determined by calling the Contains method.
        public void Add(T item)
        {

            if (!Contains(item))
            {
                innerCol.Add(item);
            }
            else
            {
                Console.WriteLine("A box with {0}x{1}x{2} dimensions was already added to the collection.",
                                  item.Length.ToString(), item.Height.ToString(), item.Width.ToString());
            }
        }


        public bool Remove(T item)
        {
            foreach (var elem in innerCol)
            {
                // Equality defined by the Box
                // class's implmentation of IEquatable<T>.
                if (elem.Equals(item))
                {
                    Console.WriteLine("Removing a box with {0}x{1}x{2} dimensions from the collection.",
                                  item.Length.ToString(), item.Height.ToString(), item.Width.ToString());
                    innerCol.Remove(item);
                    return true;
                }
            }
            Console.WriteLine("A box with {0}x{1}x{2} dimensions does not exist in the collection.",
                              item.Length.ToString(), item.Height.ToString(), item.Width.ToString());
            return false;
        }

        public void Clear()
        {
            innerCol.Clear();
        }


        public bool Contains(T item)
        {
            bool found = false;

            foreach (var elem in innerCol)
            {
                // Equality defined by the Box
                // class's implmentation of IEquatable<T>.
                if (elem.Equals(item))
                {
                    found = true;
                }
            }
            return found;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array == null)
                throw new ArgumentNullException("The array can't be null!");
            if (arrayIndex < 0)
                throw new ArgumentOutOfRangeException("The array index can not be negativ!");


            for (var i=0; i< innerCol.Count; i++, arrayIndex++)
            {
                if (arrayIndex < array.Length)
                {
                    array[arrayIndex] = innerCol[i];
                }
                else
                {
                    Console.WriteLine("Only {0} elements were copied from the collection to the array.", i-1);
                    break;
                }
            }
        }

        #endregion ICollection<T> members

        //TODO: write own enumerator for fun
        #region IEnumerable<T> members
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var t in innerCol)
            {
                yield return t;
            }
            //return data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() // Explicit implementation (keeps it hidden)
        {
            return GetEnumerator();
        }
        #endregion IEnumerable<T> members
    }
}
