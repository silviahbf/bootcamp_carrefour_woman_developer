using System;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());
            double Media = (A*0.2)+(B*0.3)+(C*0.5);
            Console.WriteLine($"MEDIA = " + (Media.ToString("N1")));
            //Console.ReadKey();
        }
    }
}
//Outra solução proposta:
/*using System;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;
            A = double.Parse(Console.ReadLine());
            if (A < 0 || A > 10)
            {
                Console.WriteLine("Nota inválida, digite uma nota entre 0 e 10.0");
                A = double.Parse(Console.ReadLine());
            }
            B = double.Parse(Console.ReadLine());
            if (B < 0 || B > 10)
            {
                Console.WriteLine("Nota inválida, digite uma nota entre 0 e 10.0");
                B = double.Parse(Console.ReadLine());
            }
            C = double.Parse(Console.ReadLine());
            if (C < 0 || C > 10)
            {
                Console.WriteLine("Nota inválida, digite uma nota entre 0 e 10.0");
                C = double.Parse(Console.ReadLine());
            }
            double Media = (A*0.2)+(B*0.3)+(C*0.5);
            Console.WriteLine($"MEDIA = " + (Media.ToString("N1")));
            //Console.ReadKey();
        }
    }
}*/