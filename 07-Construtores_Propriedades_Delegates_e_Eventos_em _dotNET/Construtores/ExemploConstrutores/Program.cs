using System;
//using ExemploConstrutores.Models;

//Pessoa p1 = new Pessoa("Silvia", "Fernandes");
//p1.Apresentar();

//Pessoa p2 = new Pessoa();
//p2.Apresentar();

/*Log log1 = Log.GetInstance();

log1.PropriedadeLog = "Teste instância";

Log log2 = Log.GetInstance();
System.Console.WriteLine(log2.PropriedadeLog);*/

class Program
{
    public delegate void Operacao(int x, int y);

    static void Main(string[] args)
    {
        Matematica m = new Matematica(10, 20);
        m.Somar();
        
        
        //Operacao op = Calculadora.Somar;
        //Operacao op = new Operacao(Calculadora.Somar);
        //op.Invoke(10, 10);
        //op(10, 10); //Outra forma de chamar o delegate

        //op += Calculadora.Subtrair; //Nesse caso += significa que estamos adicionando mais um método sem perder a referência do método anterior
        //op.Invoke(10, 10); //Multicast delegate obedece a ordem fifo
    
        //Aluno p1 = new Aluno("Silvia", "Fernandes", "Teste");
        //p1.Apresentar();
   
        //const double pi = 3.14;
        //System.Console.WriteLine(pi);
        //pi = 0; //O valor da constante deve ser atribuído na sua inicialização. Não é possível alterar seu valor.
                     
        /*Data data = new Data();
        //data.SetMes(20);

        data.Mes = 20;
        //System.Console.WriteLine(data.Mes);

        data.ApresentarMes();*/
    }
}
