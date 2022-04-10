double A, B, C;
A = double.Parse(Console.ReadLine());
B = double.Parse(Console.ReadLine());
C = double.Parse(Console.ReadLine());
double Media = (A*0.2)+(B*0.3)+(C*0.5); //Cálculo da Média
Console.WriteLine($"MEDIA = " + (Media.ToString("N1"))); //Exibe Média com 1 casa decimal
Console.ReadKey();
