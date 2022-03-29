using System;

namespace Uri1078
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n >= 2 && n < 1000)
            {
                for (int count = 1; count <= 10; count++)
                {       
                    int valor = count*n;
                    Console.WriteLine($"{count} x {n} = {valor}");
                }
            }
        }
    }
}
