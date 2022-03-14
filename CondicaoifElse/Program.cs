using System;

namespace CondicaoifElse

{
    class Program
    {
        static void Main(string[] args)
        {
            //bool queroPescar = true;
            //if (queroPescar == false)
            //{
            //    Console.WriteLine("Eu vou pescar no próximo Sábado");
            //}
            //else
            //{
            //    Console.WriteLine("Eu não quero pescar no próximo Sábado");
            //}

            int time = 10;

            string resultado = (time < 12) ? "Bom dia!" : "Boa tarde!";

            Console.WriteLine(resultado);

            //if (time < 12)
            //{
            //    Console.WriteLine("Bom dia!"); 
            //}
            //else if (time < 18)
            //{
            //    Console.WriteLine("Boa tarde!");
            //}
            //else
            //{
            //    Console.WriteLine("Boa noite!");
            //}
            
        }
    }
}
