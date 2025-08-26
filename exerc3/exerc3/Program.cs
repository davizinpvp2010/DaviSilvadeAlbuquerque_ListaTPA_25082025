using System;
namespace program
{
    class exerc3
    {
        static void Main(string[] args)
        {
            int n, r;
            Console.WriteLine("escolha uma tabuada");
            n=int.Parse(Console.ReadLine());
            for(int i = 0; i < 10; i++)
            {
                r = n * i;
                Console.WriteLine("{0}x{1}={2}",n,i,r);
            }
        }
     }
}