using System;

namespace program
{
    class exer9
    {
        static void Main(string[] args)
        {
            int C, N, E = 0;
            string R;

            while (true) 
            {
                Console.WriteLine("qual seu codigo de usuario");
                C = int.Parse(Console.ReadLine());

                Console.WriteLine("quantas horas você trabalhou");
                N = int.Parse(Console.ReadLine());
                
                if (N > 50) 
                {
                    E = 20 * (N - 50);
                    N = 50;
                }
                N = N * 10;
                Console.WriteLine("O trabalhador {0}, ele ganhou R${1},00 em horas normais e ganhou R${2},00 em horas extras.", C, N, E);

                Console.WriteLine("Você deseja terminar o programa? (S/N)");
                R = Console.ReadLine();

                if (R == "S")
                {
                    break;
                }
            } 
        }
    }
}
