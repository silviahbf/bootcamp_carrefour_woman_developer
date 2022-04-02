using System.Collections.Generic;
using Colecoes.Helper;

//LINQ: Language-Integrated Query

int[] arrayNumeros = new int[10] {100, 1, 4, 0, 8, 15, 19, 19, 4, 100};

var minimo = arrayNumeros.Min();
var maximo = arrayNumeros.Max();
var medio = arrayNumeros.Average();
var soma = arrayNumeros.Sum();
var arrayUnicos = arrayNumeros.Distinct().ToArray();


System.Console.WriteLine($"Mínimo: {minimo}");
System.Console.WriteLine($"Máximo: {maximo}");
System.Console.WriteLine($"Médio: {medio}");
System.Console.WriteLine($"Soma: {soma}");
System.Console.WriteLine($"Array original: {string.Join(", ", arrayNumeros)}");
System.Console.WriteLine($"Array distinto: {string.Join(", ", arrayUnicos)}");

// var numerosParesQuery = 
//     from num in arrayNumeros
//     where num % 2 == 0
//     orderby num
//     select num;

//Outra forma de fazer a mesma query, através de métodos
// System.Console.WriteLine("Números pares query: " + String.Join(", ", numerosParesQuery));

//DICIONÁRIOS

// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("MG", "Minas Gerais");
// estados.Add("BA", "Bahia");
//estados.Add("MG", ""); //A chave não pode ser duplicada, o valor sim

// foreach (var item in estados)
// {
    //System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// string valorProcurado = "BA";

//var teste = estados["SC"]; //Chave inexistente

// if (estados.TryGetValue(valorProcurado, out string estadoEncontrado))
// {
//     System.Console.WriteLine(estadoEncontrado);
// }
// else
// {
//     System.Console.WriteLine($"Chave {valorProcurado} não existe no dicionário.");
// }

// System.Console.WriteLine($"Removendo o valor: {valorProcurado}");

// estados.Remove(valorProcurado);

// foreach (var item in estados)
// {
//     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }


// System.Console.WriteLine("Valor original: ");
// System.Console.WriteLine(estados[valorProcurado]);

// estados[valorProcurado] = "BA - teste atualização";

// System.Console.WriteLine("Valor atualizado: ");
// System.Console.WriteLine(estados[valorProcurado]);

//PILHAS

// Stack<string> pilhaLivros = new Stack<string>();

// pilhaLivros.Push(".NET");
// pilhaLivros.Push("DDD");
// pilhaLivros.Push("Código Limpo");

// System.Console.WriteLine($"Livros para leitura: {pilhaLivros.Count}\n");

// while (pilhaLivros.Count > 0)
// {
//     System.Console.WriteLine($"Próximo livro para leitura: {pilhaLivros.Peek()}.");
//     System.Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso.\n");
// }

// System.Console.WriteLine($"Livros para leitura: {pilhaLivros.Count}\n");

//FILAS

// Queue<string> fila = new Queue<string>();

// fila.Enqueue("Leonardo");
// fila.Enqueue("Eduardo");
// fila.Enqueue("André");


// System.Console.WriteLine($"Pessoas na fila: {fila.Count}");

// while (fila.Count > 0)
// {
//     System.Console.WriteLine($"Vez de: {fila.Peek()}");
//     System.Console.WriteLine($"{fila.Dequeue()} atendido");
// }

// System.Console.WriteLine($"Pessoas na fila: {fila.Count}");


//LISTAS

// OperacoesLista opLista = new OperacoesLista();
// List<string> estados = new List<string> {"SP", "MG", "BA"};
// string[] estadosArray = new string[2] {"SC", "MT"};

// estados.Add("SP");
// estados.Add("MG");
// estados.Add("BA");

// System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");

// opLista.ImprimirListaString(estados);

// System.Console.WriteLine("Removendo o elemento.");

// estados.Remove("MG");

//estados.AddRange(estadosArray);
// estados.Insert(1, "RJ");

// opLista.ImprimirListaString(estados);

// foreach (var item in estados)
// {
//     System.Console.WriteLine(item);
// }

// for (int i = 0; i < estados.Count; i++)
// {
//     System.Console.WriteLine($"Índice {i}, Valor: {estados[i]}");
// }



//ARRAYS

// OperacoesArray op = new OperacoesArray();
// int[] array = new int[5] {6, 3, 8, 1 , 9};
// int[] arrayCopia = new int[10];
// string[] arrayString = op.ConverterParaArrayString(array);

// //int valorProcurado = 1;

// System.Console.WriteLine($"Capacidade atual do array: {array.Length}");

// op.RedimensionarArray(ref array, array.Length * 2); //Dobrando a capacidade do array

// System.Console.WriteLine($"Capacidade atual do array após redimensionamento: {array.Length}");

// int indice = op.ObterIndice(array, valorProcurado);

// if (indice > -1)
// {
//     System.Console.WriteLine("O índice do elmento é {0}: {1}", valorProcurado, indice);
// }
// else
// {
//     System.Console.WriteLine("Valor não existente no array!");
// }

// int valorAchado = op.ObterValor(array, valorProcurado);

// if (valorAchado > 0)
// {
//     System.Console.WriteLine("Encontrei o valor.");
// }
// else
// {
//     System.Console.WriteLine("Não encontrei o valor.");
// }

// bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado);

// if (todosMaiorQue)
// {
//     System.Console.WriteLine("Todos os valores são maiores que {0}.", valorProcurado);
// }
// else
// {
//     System.Console.WriteLine("Existem valores que não são maiores do que o valor {0}.", valorProcurado);
// }

// bool existe = op.Existe(array, valorProcurado);

// if (existe)
// {
//     System.Console.WriteLine("Encontrei o valor: {0}", valorProcurado);
// }
// else
// {
//     System.Console.WriteLine("Não encontrei o valor: {0}", valorProcurado);
// }

// System.Console.WriteLine("Array original:");
// op.ImprimirArray(array);

//op.OrdenarBubbleSort(ref array);
//op.Ordenar(ref array);

// System.Console.WriteLine("\nArray ordenado:");
// op.ImprimirArray(array);

// System.Console.WriteLine("\nArray antes da cópia:");
// op.ImprimirArray(arrayCopia);

// op.Copiar(ref array, ref arrayCopia);
// System.Console.WriteLine("\nArray após a cópia:");
// op.ImprimirArray(arrayCopia);

//ARRAY MULTIDIMENSIONAL (MATRIZ)

// int[,] matriz = new int [4, 2]
// {
//     { 8, 8 },
//     { 10, 20 },
//     { 50, 100 },
//     { 90, 200 }
// };

// for (int i = 0; i < matriz.GetLength(0); i++) //i >> linha (0)
// {
//     for (int j = 0; j < matriz.GetLength(1); j++) //j >> coluna (1)
//     {
//         System.Console.WriteLine(matriz[i, j]);
//     }
// }


//ARRAY (VETOR)

//int[] arrayInteiros = new int[3];
// arrayInteiros[0] = 10;
// arrayInteiros[1] = 20;
// arrayInteiros[2] = int.Parse("30"); //Não aceita elementos de tipo diferente, é necessário fazer a conversão para um número do tipo inteiro

//arrayInteiros[3] = 30; //Não se pode modificar em tempo de execução o tamanho do array. É necessário criar um novo copiando os elementos do antigo

// System.Console.WriteLine("Percorrendo o array pelo For");
// for (int i = 0; i < arrayInteiros.Length; i++)
// {
//     System.Console.WriteLine(arrayInteiros[i]);
// }

// System.Console.WriteLine("Percorrendo o array pelo Foreach");
// foreach (int item in arrayInteiros)
// {
//     System.Console.WriteLine(item);
// }