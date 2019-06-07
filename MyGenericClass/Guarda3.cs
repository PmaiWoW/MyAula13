using System;
using System.Collections.Generic;
using System.Text;

namespace MyGenericClass
{
    class Guarda3<T>
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
    }
}
