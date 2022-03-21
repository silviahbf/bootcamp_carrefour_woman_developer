using System;

namespace Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean condicao = true;
            int valor;



            while (condicao == true)
            {
                Console.WriteLine("Digite um valor ou 0 para sair: ");
                valor = int.Parse(Console.ReadLine());

                if (valor == 0)
                {
                    Console.WriteLine("Você saiu da aplicação.");
                }
                else
                {
                    Console.WriteLine($"O valor informado é " + valor);
                    condicao = false;
                }
            }
        }
    }
}
