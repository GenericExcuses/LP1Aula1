using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "Io";
            string y = "Oi"; 



            string s = "Ola Mundo!";
            Console.WriteLine (s);

            string b = "Ola Mundo\t or not";
            string e = @"something something";
            string z = "a" + 5;
            string g = "a" + x;
            string h = $"valor de x e {x}";
            string q = String .Format("Y e {1}, X e {0}", x, y);
            Console.WriteLine(@"Verbatim com x = {0}", x);

            Console.WriteLine (b);
            Console.WriteLine (e);
            Console.WriteLine (z);
            Console.WriteLine (g);
            Console.WriteLine (h);
            Console.WriteLine (q);
        }
    }
}
