using System;

namespace Programa
{
    class atividade6
    {
        static void Main(string[] args)
        {
            int n, n2 = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Digite um numero:");
                n = int.Parse(Console.ReadLine());

                if (n >= 0 && n <= 10)
                {
                    n2 = n2 + n;
                }
                else
                {
                    Console.WriteLine("Digite um numero valido");
                    i = i - 1;
                }
            }
            Console.WriteLine(n2 / 10);
        }
    }
}