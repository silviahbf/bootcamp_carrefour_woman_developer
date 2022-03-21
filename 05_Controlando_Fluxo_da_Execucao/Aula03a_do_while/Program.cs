using System;

namespace Aula03a
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean condicao = true;
            int valor;
            
            do
            {
                Console.WriteLine("Digite um valor ou 0 para sair");
                valor = int.Parse(Console.ReadLine());

                if (valor == 0)
                {
                    Console.WriteLine("Você saiu da aplicação");
                    condicao = false;
                }
                else
                {
                    Console.WriteLine($"O valor digitado é " + valor);
                };
            }
            while (condicao == true);
        }
    }
}
