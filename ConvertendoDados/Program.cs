using System;

namespace ConvertendoDados

{
    class Program
    {
        static void Main(string[] args)
        {

            int meuInteiro = 42;
            double meuDouble = 13.80;
            bool meuBool = true;                                // Verdadeiro


            Console.WriteLine(Convert.ToString(meuInteiro));    // Conversão de Int para String (Casting
            Console.WriteLine(Convert.ToDouble(meuInteiro));    // Conversão de Int para Double
            Console.WriteLine(Convert.ToInt32(meuDouble));

            Console.Write("Meu Teste");                         //Escreve conteúdo
            Console.WriteLine("Novo Teste");                    //Escreve conteúdo e pula para próxima linha

        }
    }
}
