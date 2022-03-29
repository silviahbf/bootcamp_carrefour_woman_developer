using System;

namespace Aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1;
            int valor2;
            int total;

            Console.WriteLine("Digite primeiro valor: ");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite segundo valor: ");
            valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"O primeiro valor é " + valor1);
            Console.WriteLine($"O segundo valor é " + valor2);

            total = valor1 + valor2;

            Console.WriteLine($"A soma dos 2 valores é " + total);

        }
    }
}
