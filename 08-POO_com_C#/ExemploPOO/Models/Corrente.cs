namespace ExemploPOO.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(double valor)
        {
            base.saldo = valor; //Posso utilizar o this no lugar de base
        }
    }
}