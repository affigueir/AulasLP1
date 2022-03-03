using System;

namespace IncDec
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int i = 1;
            int b = 2;
            Console.WriteLine($"i = {i} b = {b}");
            Console.WriteLine("Run IncDec?");
            Console.ReadLine();
            Console.WriteLine($"As you can see b is now {++b} while i is still {i++}");
        }
    }
}
