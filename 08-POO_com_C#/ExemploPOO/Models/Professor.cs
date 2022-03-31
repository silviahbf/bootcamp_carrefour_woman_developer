namespace ExemploPOO.Models
{
    public /*sealed*/ class Professor : Pessoa
    {
        public int Salario { get; set; }

        public /*sealed*/ override void Apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é {Nome} e meu salário é {Salario}.");
        }
    }
}