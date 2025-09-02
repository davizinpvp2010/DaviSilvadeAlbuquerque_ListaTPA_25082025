using System;

namespace jokenpo
{
    class jokenpo
    { 
        static void Main(string[] args)
        {
            Random random = new Random();
            int jkp, a;
            int ale = random.Next(1, 4);

            Console.WriteLine("escolha entre pedra papel e tesoura");
            Console.WriteLine("1-pedra");
            Console.WriteLine("2-papel");
            Console.WriteLine("3-tesorura");
            Console.WriteLine("digite o numero equivalente ao que quer jogar"); 
            jkp=int.Parse(Console.ReadLine());

            switch(jkp)
            {
                case 1:
                    Console.WriteLine("pedra");
                    break;
                case 2:
                    Console.WriteLine("papel");
                    break;
                case 3:
                    Console.WriteLine("tesoura");
                    break;
            }
            Console.WriteLine("seu adversario escolheu...");
            switch (ale)
            {
                case 1:
                    Console.WriteLine("pedra");
                    break;
                case 2:
                    Console.WriteLine("papel");
                    break;
                case 3:
                    Console.WriteLine("tesoura");
                    break;
            }
            a = (jkp - ale + 3) % 3;

            switch (a)
            {
                case 0:
                    Console.WriteLine("Empate!");
                    break;
                case 1:
                    Console.WriteLine("Você venceu!");
                    break;
                case 2:
                    Console.WriteLine("Computador venceu!");
                    break;
            }




        }
    }
}