using System;

class TESTE
{
    static void Main ()
    {
        var N = int.Parse(Console.ReadLine()); //N indica a pressão desejada
        var M = int.Parse(Console.ReadLine()); //M indica a pressão lida
        int DiferencaPressao = N - M;
        Console.WriteLine(DiferencaPressao);
    }
}
