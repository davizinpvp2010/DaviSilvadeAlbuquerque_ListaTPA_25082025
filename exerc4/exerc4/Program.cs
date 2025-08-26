using System;

namespace Programa
{
    class atividade4
    {
        static void Main(string[] args)
        {
            int n1, n2, qdni = 0;

            Console.WriteLine("escolha o numero menor");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("escolha o numero maior");
            n2 = int.Parse(Console.ReadLine());


            if (n1 % 2 == 0)
            {
                for (int i = n1 + 1; i <= n2;)
                {
                    i = i + 2;
                    qdni = qdni + 1;
                }
            }
            else
            {

                for (int i = n1; i <= n2;)
                {
                    i = i + 2;
                    qdni = qdni + 1;
                }
            }
            Console.WriteLine(qdni);
        }
    }
}