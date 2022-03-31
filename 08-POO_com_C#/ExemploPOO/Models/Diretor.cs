namespace ExemploPOO.Models
{
    public class Diretor : Professor //Não é possível herdar de uma classe selada
    {
        public override void Apresentar() //Não é possível herdar um método setado
        {
            System.Console.WriteLine("Diretor.");
        }
    }
}