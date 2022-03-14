using System;

namespace ClasseMath
    
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("valor máximo entre 5 e 79: " + Math.Max(5, 79));      //Número máximo entre 5 e 79
            Console.WriteLine("valor mínimo entre 5 e 79: " + Math.Min(5, 64));      //Número mínimo entre 5 64


            Console.WriteLine("Raiz Quadrada: " + Math.Sqrt(79));       //Raiz Quadrada      
            Console.WriteLine("valor máximo: " + Math.Round(9.76));     //Arredondamento
        }
    }
}