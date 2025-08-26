using System;
namespace program
{
    class exerc2
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("escolha um numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("escolha um numero");
            n2 = int.Parse(Console.ReadLine());
            if (n1 % 2 == 0)
            {
                Console.WriteLine(n1);
                for (int i = n1 - 1; n2 <= i; i--)
                {
                    Console.WriteLine(i);
                    i = i - 1;
                }
             
            }
            else
            {
                Console.WriteLine(n1);
                for (int i = n1 - 1; n2 <= i; i--)
                {
                    Console.WriteLine(i);
                    i = i - 1;
                }
            }
            Console.WriteLine(n2);
        }

    }
}