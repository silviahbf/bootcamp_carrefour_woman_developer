using System;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //n é o número de linhas que a saída deve ter        
            int x = 1;
            for (int linha = 1; linha <= n; linha++) 
            {
                Console.Write($"{x} {Math.Pow(x, 2)} {Math.Pow(x, 3)}");
                x++;
                Console.WriteLine();               
            }
        }
    }
}
