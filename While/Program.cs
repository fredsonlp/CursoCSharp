using System;

namespace While

{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                //Executa um bloco de código
                Console.WriteLine(i);
                i++;
            }
            while (i < 10);
        }
    }
}
