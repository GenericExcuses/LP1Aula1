using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "Io";
            string y = "Oi"; 
            double xx = 0.12345;
           

            string s = "Ola Mundo!";
            Console.WriteLine (s);

            string b = "Ola Mundo\t or not";
            string e = @"something something";
            string z = "a" + 5;
            string g = "a" + x;
            string h = $"valor de x e {x}";
            string q = String.Format("Y e {1}, X e {0}", x, y);
            string kk = String.Format("{1,6:f2} e {0:p1}", 0.1234, 18);
            string k = $"x={xx:f2}";

            string l = String.Format("{1,6:x2} e {0:c1}", 0.1234, 18);

            Console.WriteLine (b);
            Console.WriteLine (e);
            Console.WriteLine (z);
            Console.WriteLine (g);
            Console.WriteLine (h);
            Console.WriteLine (q);
            Console.WriteLine(@"Verbatim com x = {0}", x);
            Console.WriteLine(k);
            Console.WriteLine(kk);
            Console.WriteLine(l);
        }
    }
}
