using static System.Console;

CriarDiretoriosGlobo();
CriarArquivo();

var origem = Path.Combine(Environment.CurrentDirectory, "argentina.txt");
var destino = Path.Combine(Environment.CurrentDirectory, 
                                "globo",
                                "América do Sul",
                                "Argentina",
                                "argentina.txt");

MoverArquivo(origem, destino);

CopiarArquivo(origem, destino);

static void CopiarArquivo(string pathOrigem, string pathDestino)
{
    if(!File.Exists(pathOrigem))
    {
        WriteLine("Arquivo de origem não existe.");
        return;
    }

    if(File.Exists(pathDestino))
    {
        WriteLine("Arquivo já existe na pasta de destino.");
        return;
    }
    File.Copy(pathOrigem, pathDestino);
}

static void MoverArquivo(string pathOrigem, string pathDestino)
{
    if(!File.Exists(pathOrigem))
    {
        WriteLine("Arquivo de origem não existe.");
        return;
    }

    if(File.Exists(pathDestino))
    {
        WriteLine("Arquivo já existe na pasta de destino.");
        return;
    }

    File.Move(pathOrigem, pathDestino);
}

static void CriarArquivo()
{
    var path = Path.Combine(Environment.CurrentDirectory, "argentina.txt");
    if(!File.Exists(path))
    {
        using var sw = File.CreateText(path);
        sw.WriteLine("População: 213MM");
        sw.WriteLine("IDH: 0,901");
        sw.WriteLine("Dados atualizado em 20/04/2018");
    }
}

static void CriarDiretoriosGlobo()
{
    var path = Path.Combine(Environment.CurrentDirectory, "globo");
    if(!Directory.Exists(path))
    {
        var dirGlobo = Directory.CreateDirectory(path);
        var dirAMNorte = dirGlobo.CreateSubdirectory("América do Norte");
        var dirAMCentral = dirGlobo.CreateSubdirectory("América Central");
        var dirAMSul = dirGlobo.CreateSubdirectory("América do Sul");

        dirAMNorte.CreateSubdirectory("USA");
        dirAMNorte.CreateSubdirectory("México");
        dirAMNorte.CreateSubdirectory("Canadá");

        dirAMCentral.CreateSubdirectory("Costa Rica");
        dirAMCentral.CreateSubdirectory("Panamá");

        dirAMSul.CreateSubdirectory("Brasil");
        dirAMSul.CreateSubdirectory("Argentina");
        dirAMSul.CreateSubdirectory("Paraguai");
    }
}