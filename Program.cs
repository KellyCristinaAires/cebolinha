using System;

namespace cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;
            Console.Write("Digite Qualquer Coisa: ");
            frase = Console.ReadLine();
            Console.Write("\n");

            Console.WriteLine($"{frase.Replace("r", "l").Replace("R", "L")}");
            Console.WriteLine("Pressione ENTER para sair");
            Console.ReadKey();
        }
    }
}

