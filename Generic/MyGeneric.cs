using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class MyGeneric<T> where T : struct
    {
        private Collection<T> collection;

        public void addItem(T item)
        {
            collection.Add(item);
        }

        public T getItem(int index)
        {
            return collection[index];
        }
    }
}
