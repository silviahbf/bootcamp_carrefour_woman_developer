int n = Convert.ToInt32(Console.ReadLine()); //Leitura do número N

for (int line = 1; line <= n; line++)
{
    Console.WriteLine($"{line} {Math.Pow(line, 2)} {Math.Pow(line, 3)}");
    Console.WriteLine($"{line} {(Math.Pow(line, 2) + 1)} {(Math.Pow(line, 3) + 1)}");
}