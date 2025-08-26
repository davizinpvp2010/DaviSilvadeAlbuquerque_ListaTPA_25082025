using System;

namespace Programa
{
    class atividade5
    {
        static void Main(string[] args)
        {
            int n, n2 = 0;

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Escolha um numero");
                n = int.Parse(Console.ReadLine());

                if (n >= n2)
                {
                    n2 = n;
                }
            }

            Console.WriteLine(n2);
        }
    }
}