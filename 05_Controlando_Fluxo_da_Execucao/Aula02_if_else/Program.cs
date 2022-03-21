using System;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            Console.WriteLine("Digite a sua idade: ");
            idade = int.Parse(Console.ReadLine());
            
            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de Idade!");
            }
            else
            {
                Console.WriteLine("Você é menor de idade!");
            }
            
        }
    }
}
