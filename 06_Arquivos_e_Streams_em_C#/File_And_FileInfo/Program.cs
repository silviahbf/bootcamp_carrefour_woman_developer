
//using System.IO;
//(Não necessário, está em D:\!Dio\File_And_FileInfo\obj\Debug\net6.0\File_And_FileInfo.GlobalUsings.g.cs)

//var path = Environment.CurrentDirectory + "\\teste.txt";

//Outras opções e exemplos:
//var path = Path.Combine(Environment.CurrentDirectory, "teste.txt");
//var path = Path.Combine(@"C:\\temp", "teste.txt";

//File.Create(path);

/*var sw = File.CreateText(path);
sw.WriteLine("Essa é a linha 1 do arquivo.");
sw.WriteLine("Essa é a linha 2 do arquivo.");
sw.WriteLine("Essa é a linha 3 do arquivo.");
sw.Flush();*/

//Outra opção, Flush() por linha:
/*var path1 = Environment.CurrentDirectory + "\\teste1.txt";

var sw1 = File.CreateText(path1);
sw1.WriteLine("Essa é a linha 1 do arquivo.");
sw1.Flush();
sw1.WriteLine("Essa é a linha 2 do arquivo.");
sw1.Flush();
sw1.WriteLine("Essa é a linha 3 do arquivo.");
sw1.Flush();
sw1.Flush();*/


//Outra forma, com StreamWriter:
/*var path2 = Environment.CurrentDirectory + "\\teste2.txt";

using var sw2 = File.CreateText(path2);
sw2.WriteLine("Essa é a linha 1 do arquivo.");
sw2.WriteLine("Essa é a linha 2 do arquivo.");
sw2.WriteLine("Essa é a linha 3 do arquivo.");*/