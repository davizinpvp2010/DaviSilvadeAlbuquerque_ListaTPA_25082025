using System;

namespace program
{
    class exer9
    {
        static void Main(string[] args)
        {
            int d = 0, m = 0, M = 0, N = 0, n;
            string r;

            while(true)
            {
                Console.WriteLine("digite um numero inteiro");
                n = int.Parse(Console.ReadLine());
                if (n  > 0)
                {
                    M++;
                }
                if (n <0)
                {
                    m++;
                }
                if (n % 2 == 0)
                {
                    d++;   
                }
                else
                {
                    N++;
                }

                Console.WriteLine("Você deseja finalizar o programa? (S/N)");
                r = Console.ReadLine();
                if(r == "S")
                {
                    break;
                }
            }
            Console.WriteLine("Você digitou {0} numeros pares", d);
            Console.WriteLine("Você digitou {0} numeros impares", N);
            Console.WriteLine("Você digitou {0} numeros Positivos", M);
            Console.WriteLine("Você digitou {0} numeros Negativos", m);
        }
    }
}
