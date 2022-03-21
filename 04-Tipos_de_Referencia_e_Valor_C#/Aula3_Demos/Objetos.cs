public ref struct Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public Endereco EnderecoPessoa { get; set; }
}

public struct Endereco : Dados
{
    public string Logradouro { get; set; }
    public int Numero { get; set; }
    public string CEP { get; set; }
    public string Cidade { get; set; }

};

public interface Dados
{
    int Numero { get; set; }
    string Logradouro { get; set; }
}