using System;

namespace ArrayBiDim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert array's horizontal dimension: ");
            int i = int.Parse(Console.ReadLine());

            Console.Write("Insert array's vertical dimension: ");
            int j = int.Parse(Console.ReadLine());

            float [,] arrayBiDim = new float [i,j];

            for (int a = 0; a < i; a++)
            {
                for (int b = 0; b < j; b++)
                {
                    Console.WriteLine($"Insert a value for position [{a},{b}]:");
                    arrayBiDim[a,b] = Single.Parse(Console.ReadLine());
                }
            }
            

        }
    }
}
