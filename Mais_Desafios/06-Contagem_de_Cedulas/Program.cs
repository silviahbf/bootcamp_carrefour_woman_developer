int n, nota, quociente, resto;

n = int.Parse(Console.ReadLine());
Console.WriteLine(n);

resto = n;
nota = 100;

if (resto >= nota) 
{
    quociente = resto / nota;
    Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
    resto = resto % nota;
}
else
{
    Console.WriteLine($"0 nota(s) de R$ {nota},00");
}

nota = 50;

if (resto >= nota)
{
    quociente = resto / nota;
    Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
    resto = resto % nota;
}
else
{
    Console.WriteLine($"0 nota(s) de R$ {nota},00");
}

nota = 20;

if (resto >= nota)
{
    quociente = resto / nota;
    Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
    resto = resto % nota;

}
else
{
    Console.WriteLine($"0 nota(s) de R$ {nota},00");
}

nota = 10;

if (resto >= nota)
{
    quociente = resto / nota;
    Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
    resto = resto % nota;

}
else
{
    Console.WriteLine($"0 nota(s) de R$ {nota},00");
}

nota = 5;

if (resto >= nota)
{
    quociente = resto / nota;
    Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
    resto = resto % nota;
}
else
{
    Console.WriteLine($"0 nota(s) de R$ {nota},00");
}

nota = 2;

if (resto >= nota)
{
    quociente = resto / nota;
    Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
    resto = resto % nota;
}
else
{
    Console.WriteLine($"0 nota(s) de R$ {nota},00");
}

nota = 1;

if (resto >= nota)
{
    quociente = resto / nota;
    Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
    resto = resto % nota;
}
else
{
    Console.WriteLine($"0 nota(s) de R$ {nota},00");
}
Console.ReadLine();