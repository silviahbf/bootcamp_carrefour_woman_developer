using ExemploPOO.Interfaces;

namespace ExemploPOO.Models
{
    public class Calculadora : ICalculadora //Calculadora implementa a interface
    {
        // public int Dividir(int num1, int num2)
        // {
        //     return num1 / num2;
        // }
        //Somente é obrigatório implementar um método na Classe quando o método não possui implementação na Interface

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

         public int Somar(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}