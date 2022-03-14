using System;

namespace Operadores

{
    class Program
    {
        static void Main(string[] args)
        {
            int somaA = 100 + 50;
            int somaB = somaA + 385;
            int somaC = (somaA + somaB) / 10 + (somaB);
            
            Console.WriteLine("o resultado da somaA é " + somaA);
            Console.WriteLine("o resultado da somaB é " + somaB);
            Console.WriteLine("o resultado da somaC é " + somaC);
        }
    }
}
