using System;

namespace PercorreString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert phrase: ");
            string insert = Console.ReadLine();

            Console.Write("Insert a char: ");
            char a = char.Parse(Console.ReadLine());
            Console.Write("Your new string is ");

            for (int i = 0; i < insert.Length; i++)
            {
                if (insert[i] != a)
                {
                    Console.Write(insert[i]);
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
