using System;
using System.Collections.Generic;

namespace TheyCameBefore
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>() { -9, 8, -2, 3, -5, 1, 93 };

            List<float> floats = new List<float>()
                { 9.9f, 8.0f, 4.0f, 2.1f, 3.5f, 5.6f, 1.0f, 93.0f };

            Console.WriteLine("Ints:");
            foreach(int i in CameBefore<int>(ints, 1))
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nFloats:");
            foreach (float f in CameBefore<float>(floats, 10.0f))
            {
                Console.WriteLine(f);
            }
        }

        private static IEnumerable<T> CameBefore<T>(IEnumerable<T> itens, T Y)
            where T : struct, IComparable<T> 
        {
            foreach(T cena in itens)
                if(cena.CompareTo(Y) < 0) yield return cena;
        }

        private static IEnumerable<T> CameBefore2<T>(IEnumerable<T> itens, T Y)
            where T : struct, IComparable<T>
        {
            Queue<T> fila = new Queue<T>();

            foreach (T cena in itens)
                if (cena.CompareTo(Y) < 0) fila.Enqueue(cena);

            return fila;
        }
    }
}
