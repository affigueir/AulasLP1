using System;

namespace Argumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string a in args)
            {
                //int b = 1;
                Console.WriteLine($"Argument is {a}.");
            }
        }
    }
}
