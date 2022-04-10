var raio = double.Parse(System.Console.ReadLine()); //Entrada valor do raio

double A =(Math.Pow(raio, 2) * 3.14159); //Cálculo da área do círculo

Console.WriteLine("A=" + string.Format("{0:0.0000}", A));