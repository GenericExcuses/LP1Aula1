using System;

namespace OlaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {

                string value = args[i];
                Console.WriteLine("for: {0}", value);

            }       
        }
    }
}

