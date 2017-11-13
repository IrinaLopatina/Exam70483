using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam70483_4
{
    class MyCollection<T> : IEnumerable<T> //,IList<T>, ICollection<T> 
    {
        //T[] data = new T[10]; //starts from []

        List<T> data = new List<T>();

        public void Add(T item)
        {
            data.Add(item);
        }

        #region IEnumerable<T>
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var t in data)
            {
                yield return t;
            }
            //return data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() // Explicit implementation (keeps it hidden)
        {
            return GetEnumerator();
        }
        #endregion IEnumerable<T>
    }
}
