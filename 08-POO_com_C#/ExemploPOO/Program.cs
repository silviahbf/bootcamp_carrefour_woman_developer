using System.Collections.Generic;
using System;
using System.IO;
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //MANIPULANDO ARQUIVOS
            
            var caminho = "D:\\!Dio\\dio-desafio-github-primeiro-repositorio\\08-POO_com_C#\\Trabalhando_com_arquivos";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta_Teste_1");
            var caminhoArquivo = Path.Combine(caminho,"arquivo-teste-stream1.txt");
            var listaString = new List<string> {"Linha1", "Linha2", "Linha3"};
            var listaStringContinua = new List<string> {"Linha4", "Linha5", "Linha6"};
            var novoCaminhoArquivo = Path.Combine(caminho, "Pasta_Teste_2","arquivo-teste-stream1.txt" );
            var caminhoArquivoTeste = Path.Combine(caminho,"arquivo-teste.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho,"arquivo-teste-backup.txt");

            FileHelper helper = new FileHelper();
            
            helper.DeletarArquivo(caminhoArquivoTesteCopia);
            //helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
            //helper.MoverArquivo(caminhoArquivo,novoCaminhoArquivo);
            //helper.LerArquivoStream(caminhoArquivo);
            //helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            //helper.AdicionarTextoStream(caminhoArquivo, listaStringContinua);
            //helper.CriarArquivoTexto(caminhoArquivo, "Olá! Teste de escrita de arquivo.");
            //helper.ApagarDiretorio(caminhoPathCombine, true);
            //System.Console.WriteLine("Criando diretório: " + caminhoPathCombine);
            //helper.CriarDiretorio(caminhoPathCombine);
            //helper.ListarArquivosDiretorios(caminho);
            //helper.ListarDiretorios(caminho);

            
            //INTERFACE

            //ICalculadora calc = new ICalculadora(); //Não funciona porque uma interface não pode ser instanciada
            // ICalculadora calc = new Calculadora();
            // System.Console.WriteLine(calc.Somar(10, 20));

                       
            //CLASSE OBJECT

            // Computador comp = new Computador();
            // System.Console.WriteLine(comp.ToString());
            
            //CLASSE ABSTRATA

            // Corrente c = new Corrente();
            // c.Creditar(100);
            // c.ExibirSaldo();
            
            //Conta conta = new Conta(); //Não é possível criar instância de classes abstratas

            
            
            // POLIMORFISMO em tempo de compilção (Overload ou Early Binding)

            // Calculadora calc = new Calculadora();
            // System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10, 10));
            // System.Console.WriteLine("Resultado da segunda soma: " + calc.Somar(10, 10, 10));
            

            // POLIMORFISMO em tempo de execução (Override ou Late Binding)

            // Aluno p1 = new Aluno();
            // p1.Nome = "Bob";
            // p1.Idade = 20;
            // p1.Documento = "123456";
            // p1.Nota = 10;
            // p1.Apresentar();

            // Professor p2 = new Professor();
            // p2.Nome = "Robert";
            // p2.Idade = 35;
            // p2.Documento = "456789";
            // p2.Salario = 2000;
            // p2.Apresentar();


            // HERANÇA:

            // Aluno p1 = new Aluno();
            // p1.Nome = "Bob";
            // p1.Idade = 20;
            // p1.Apresentar();

            // Professor p2 = new Professor();
            // p2.Nome = "Robert";
            // p2.Idade = 35;
            // p2.Salario = 2000; 
            // p2.Apresentar();
            

            // ENCAPSULAMENTO:

            // Valores válidos
            // Retangulo r = new Retangulo();
            // //r.comprimento = 3; //Não funciona porque a classe é privada
            // r.DefinirMedidas(30, 30);
            // System.Console.WriteLine($"Área: {r.ObterArea()}");

            // //Valores inválidos
            // Retangulo r2 = new Retangulo();
            // r2.DefinirMedidas(0, 0);
            // System.Console.WriteLine($"Área: {r2.ObterArea()}");


            // ABSTRAÇÃO

            // Pessoa p1 = new Pessoa();
            // p1.Nome = "Bob";
            // p1.Idade = 20;
            // p1.Apresentar();
        }
    }
}
internal interface ICalcudora
{
}