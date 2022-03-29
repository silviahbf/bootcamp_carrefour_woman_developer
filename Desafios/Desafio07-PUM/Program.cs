using System;

namespace TESTE
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()); //N é o número de linhas
            int X = 1;
            for (int i = 1; i <= N; i++)
            {
                for (int coluna = 1; coluna <=3; coluna++)
                {
                    Console.Write($"{X} ");
                    X++;
                }
                X++;   
                Console.Write("PUM");
                Console.WriteLine();
            }
        }
    }
}