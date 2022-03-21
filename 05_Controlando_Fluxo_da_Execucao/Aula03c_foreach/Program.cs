using System;

namespace Aula03c
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lista = {1, 2, 3, 4, 5};
            
            foreach (int numero in lista)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
