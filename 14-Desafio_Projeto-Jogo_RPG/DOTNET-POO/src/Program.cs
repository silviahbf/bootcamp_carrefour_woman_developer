using System;
using DOTNET_POO.src.Entities;

namespace DOTNET_POO
{
    class Program
    {   
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Hero opponent = new Hero("Maleficus", 99, "Devil");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
            
            Console.WriteLine(arus);
            Console.WriteLine(opponent);
            Console.WriteLine(wizard);

            Console.WriteLine();

            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack());
            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(7));
            Console.WriteLine(arus.Defend());

            Console.WriteLine("\nTecle [ENTER] para finalizar");
            Console.ReadKey();

        }
    }   
}