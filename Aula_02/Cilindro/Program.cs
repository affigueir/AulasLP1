using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
           /* float a;
            float r;
            float v;
            float sa;*/

            Console.Write("Insert the cylinder's height: ");
            float  a = Single.Parse(Console.ReadLine());

            Console.Write("Insert the cylinder's radius: ");
            float  r = Single.Parse(Console.ReadLine());

            float v = MathF.PI * MathF.Pow(r, 2) * a;
            float sa = 2*MathF.PI*r*(r + a);

            Console.WriteLine($"The cylinder's volume is {v} and the surface are is {sa}");

        }
    }
}
