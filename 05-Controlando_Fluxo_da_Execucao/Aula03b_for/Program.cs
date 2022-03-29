using System;

namespace Aula03b
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            Console.WriteLine("Digite um valor: ");
            valor = int.Parse(Console.ReadLine());

            for (int i = valor; i <= 15; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
