using System;

namespace For

{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                //Console.WriteLine(i);
            }
            string[] carros = { "Golf", "Uno", "Onix" };
            foreach (string y in carros)
            { 
                Console.WriteLine(y);
            }
        }
    }
}
