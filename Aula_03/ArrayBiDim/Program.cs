using System;

namespace ArrayBiDim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert array's horizontal dimension: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Insert array's vertical dimension: ");
            int b = int.Parse(Console.ReadLine());

            float [,] arrayBiDim = new float [a,b];

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.WriteLine($"Insert a value for position [{i},{j}]:");
                    arrayBiDim[i,j] = Single.Parse(Console.ReadLine());
                }
            }
            
            for (int i = 0; i < a; i++)
            {
                float average = 0;
                for (int j = 0; j < b; j++)
                {
                    average += arrayBiDim[i,j];
                }
                average /= b;
                Console.WriteLine($"Line {i} average is {average}");
            }
        }
    }
}
