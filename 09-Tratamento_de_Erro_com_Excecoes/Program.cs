int a = 100, b = 00;
double resultado = 0;

try
{
    resultado = Dividir(a, b);
    System.Console.WriteLine("{0} divido por {1} = {2}", a, b, resultado);
}
catch(DivideByZeroException ex) //when (a < 0)
{
    System.Console.WriteLine(ex.Message);
}
catch(Exception ex) //Exceção genérica. Deve se iniciar sempre tratando as exceções mais específicas.
{
    System.Console.WriteLine(ex.Message);
    //throw;
}
finally
{
    System.Console.WriteLine("Finalmente a divisão foi finalizada!");
}


static double Dividir(int x, int y)
{
    if (y == 0)
    {
        //throw new DivideByZeroException();
        //throw new ArithmeticException();
        throw new MyClassException("Minha mensagem customizada de erro.");
    }
    return(x / y);
}