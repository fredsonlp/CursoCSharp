using System;

namespace Strings

{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Vanessa Lemes ";
            string sobrenome = "Pereira";
            string nomeCompleto = $"{ nome}{sobrenome}";
            

            int posicao = nomeCompleto.IndexOf("P");
            string nomeFinal = nomeCompleto.Substring(posicao);

            //Escrever nome Final (LINHA 10)
            Console.WriteLine(nome);

            //Escrever nome Final (LINHA 11)
            Console.WriteLine(nomeFinal);

            //Escrever nome completo (LINHA 10 e 11)
            Console.WriteLine(string.Concat(nome, sobrenome));

            //Escrever nome completo usando concatenação (LINHA 12)
            Console.WriteLine(nomeCompleto);

            //Escrever nome completo com todas letras em maíusculo usando o recurso ToUpper
            Console.WriteLine(nomeCompleto.ToUpper());

            //Escrever nome completo com todas letras em minúsculo usando o recurso ToLower
            //Console.WriteLine(nomeCompleto.ToLower());

        }
    }
}