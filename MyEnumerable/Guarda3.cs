using System;
using System.Collections;
using System.Collections.Generic;

namespace MyGenericClass
{
    class Guarda3<T> : IEnumerable<T>
    {
        private T var1, var2, var3;

        public Guarda3()
        {
            var1 = default(T);
            var2 = default(T);
            var3 = default(T);
        }

        public T GetItem(int i)
        {
            if (i == 0) return var1;
            if (i == 1) return var2;
            if (i == 2) return var3;
            throw new IndexOutOfRangeException();
        }

        public void SetItem(int i, T item)
        {
            if (i == 0) var1 = item;
            else if (i == 1) var2 = item;
            else if (i == 2) var3 = item;
            else throw new IndexOutOfRangeException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            // yield return var1;
            // yield return var2;
            // yield return var3;
            for (int i = 0; i < 3; i++) yield return GetItem(i);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
