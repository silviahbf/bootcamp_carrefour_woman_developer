using System; 

class Problem
{
    static void Main(string[] args)
    {
        string[] v = Console.ReadLine().Split(); //v é um vetor de 2 elementos
        int N = int.Parse(v[0]); //N é o número de lados do polígono
        int L = int.Parse(v[1]); //L é o comprimento de cada lado
        if ((N >= 3 && N <= 1000000) && (L >= 1 && L <= 4000))
        {
            int P = N * L; //P é o perímetro do polígono
            Console.WriteLine(P);
        }    
    }
}