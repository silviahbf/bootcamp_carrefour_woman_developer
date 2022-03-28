    public class Pessoa
    {
        //private string nome;
        //private string sobrenome;

        private readonly string nome = "Silvia";
        private readonly string sobrenome;

        public Pessoa()
        {
            nome = string.Empty;
            sobrenome = string.Empty;
        }

        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            System.Console.WriteLine("Construtor classe pessoa!");
        }
        public void Apresentar()
        {
            //this.nome = "teste"; //Alterações de campo readonly só são permitidas no seu construtor
            System.Console.WriteLine($"Olá, meu nome é: {nome} {sobrenome}");
        }
    }