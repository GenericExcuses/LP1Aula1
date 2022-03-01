using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Ola Mundo!";
            Console.WriteLine (s);

            string b = "Ola Mundo\t or not";
            string e = @"something something";
            string z = "a" + 5;

            Console.WriteLine (b);
            Console.WriteLine (e);
            Console.WriteLine (z);
            
        }
    }
}
