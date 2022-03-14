using System;

namespace Array

{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carros = { "Gol", "Uno", "Onix", "Volvo" };
            int[] numeros = { 1, 2, 3, 4 };

            //Substituir algum carro da String
            //carros[2] = "Camaro Amarelo";
            //Console.WriteLine(carros[2]);

            //Escrever quantidade de Carros
            //Console.WriteLine(carros.Length);

            for (int i = 0; i < carros.Length; i++)
            {
                Console.WriteLine(carros[i]);
            }
        }
    }
}
