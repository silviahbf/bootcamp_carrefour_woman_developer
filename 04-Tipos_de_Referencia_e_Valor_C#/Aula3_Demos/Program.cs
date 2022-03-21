using static System.Console;
Pessoa p1 = new Pessoa();

p1.Nome = "Silvia";
p1.Idade = 46;

p1.EnderecoPessoa = new Endereco()
{
    Logradouro = "Rua dos Testes",
    Numero = 300,
    CEP = "00000001",
    Cidade = "São Paulo",
};

WriteLine("Fim!");
