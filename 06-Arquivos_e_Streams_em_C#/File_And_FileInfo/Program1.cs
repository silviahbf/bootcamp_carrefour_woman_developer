using static System.Console;

WriteLine("Digite o nome do arquivo: ");
var nome = ReadLine();
nome = LimparNome(nome);

var path3 = Path.Combine(Environment.CurrentDirectory, $"{nome}.txt");

CriarArquivo(path3);

WriteLine("Digite ENTER para finalizar.");
ReadLine();

static string LimparNome(string nome)
{
    //Path.GetInvalidFileNameChars(); => retorna array com lista de caracteres não permitidos
    foreach (var @char in Path.GetInvalidFileNameChars())
    {
        //substitui o caracter inválido por traço '-'
        nome = nome.Replace(@char, '-'); //o @ antes da palavra (char) reservada, permite utilizá-la
    }
    return nome;
}

static void CriarArquivo(string path3)
{
    using var sw3 = File.CreateText(path3);
    sw3.WriteLine("Essa é a linha 1 do arquivo.");
    sw3.WriteLine("Essa é a linha 2 do arquivo.");
    sw3.WriteLine("Essa é a linha 3 do arquivo.");
}


/*{
    try
    {
        using var sw3 = File.CreateText(path3);
        sw3.WriteLine("Essa é a linha 1 do arquivo.");
        sw3.WriteLine("Essa é a linha 2 do arquivo.");
        sw3.WriteLine("Essa é a linha 3 do arquivo.");
    }
    catch
    {
        WriteLine("O nome do arquivo é inválido.");
    }
}*/