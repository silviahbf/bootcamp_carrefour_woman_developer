using System;

namespace Aula02b
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes;
            Console.WriteLine("Digite o número do mês: ");
            mes = int.Parse(Console.ReadLine());

            if (mes == 1)
            {
                Console.WriteLine("Janeiro");
            }
            else if (mes == 2)
            {
                Console.WriteLine("Fevereiro");
            }
            else if (mes == 3)
            {
                Console.WriteLine("Março");
            }
            else if (mes == 4)
            {
                Console.WriteLine("Abril");
            }
            else if (mes == 5)
            {
                Console.WriteLine("Maio");
            }
            else if (mes == 6)
            {
                Console.WriteLine("Junho");
            }
            else if (mes == 7)
            {
                Console.WriteLine("Julho");
            }
            else if (mes == 8)
            {
                Console.WriteLine("Agosto");
            }
            else if (mes == 9)
            {
                Console.WriteLine("Setembro");
            }
            else if (mes == 10)
            {
                Console.WriteLine("Outubro");
            }
            else if (mes == 11)
            {
                Console.WriteLine("Novembro");
            }
            else if (mes == 12)
            {
                Console.WriteLine("Dezembro");
            }
            else
            {
                Console.WriteLine("Número do més é Inválido");
            }
        }
    }
}
