using System;

namespace MyGenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Guarda3<string> save1 = new Guarda3<string>() { "Broas",
                "Biscoitos", "Caracól" };

            // Console.WriteLine($"{save1.GetItem(0)}\n{save1.GetItem(1)}\n" +
            //     $"{save1.GetItem(2)}");

            foreach(string s in save1) { Console.WriteLine(s); }
        }
    }
}
