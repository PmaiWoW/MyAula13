using System;
using System.Collections.Generic;

namespace HowManyOfThisType
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<object> objects = new List<object>()
                { 1.0f, 9, "hola", "bruh", 8, 4.0f, 1.3f, "fds", 2, 3, 5,
                9.0f, 7.5f, 1, 93, 6542.4f };

            Console.WriteLine(HowManyOfThisType<int>(objects));
        }

        // se usasse System.Collections apenas, seria apenas:
        // private static int HowManyOfThisType<Type>(IEnumerable objects)
        private static int HowManyOfThisType<Type>(IEnumerable<object> objects)
        {
            int numOfType = 0;

            foreach (object o in objects)
            {
                if (o is Type) numOfType++;
            }

            return numOfType;
        }
    }
}
