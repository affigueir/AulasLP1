using System;

namespace Argumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 1;
            foreach (string a in args)
            {
                Console.WriteLine($"Argument {b++} is {a}.");
            }
        }
    }
}
