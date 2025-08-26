using System;

namespace program
{
    class exerc8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite um numero inteiro");
            int n;
            n = int.Parse(Console.ReadLine());

            for (int i = n - 1; i > 0; i--)
            {
                n = n * i;
            }
            Console.WriteLine(n);
        }
    }
}
