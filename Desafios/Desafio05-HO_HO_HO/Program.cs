using System;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            if (N > 0 && N <= 106)
            {
                for (int i = 0; i < N; i++)
                {
                    if (i < (N-1))
                    {
                        Console.Write("Ho ");
                    }
                    else
                    {
                        Console.WriteLine("Ho!");
                    }
                }              
            }         
        }
    }
}