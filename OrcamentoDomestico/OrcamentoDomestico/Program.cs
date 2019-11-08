using System;

namespace OrcamentoDomestico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  SISTEMA DE ORÇAMENTO DOMÉSTICO ");
            Console.WriteLine();
            Console.WriteLine();

            Pessoa mae = new Pessoa();

            Console.WriteLine("Digite o nome da mãe:");
            mae.Nome = Console.ReadLine();
            Console.Write("Salário:  R$");
            mae.Salario = double.Parse(Console.ReadLine());
            



            Pessoa avo = new Pessoa();
            Console.WriteLine("Digite o nome da avó:"); 
            avo.Nome  = Console.ReadLine();
            Console.Write("Salario:  R$");
            avo.Salario = double.Parse(Console.ReadLine());


            Pessoa filho = new Pessoa();
            Console.WriteLine("Digite o nome do filho:");
            filho.Nome = Console.ReadLine();
            Console.Write("Salário:  R$");
            filho.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("DESPESAS DA FAMÍLIA");
            Console.WriteLine();
            
            mae.Agua = 150.99;
            mae.Luz = 100.44;
            mae.Lazer = 100.99;
            var despesaMae = mae.Agua + mae.Lazer + mae.Luz;
            Console.WriteLine("Despesas da mãe RS"+despesaMae);

            avo.ItensCozinha = 50;
            avo.Eletrodomesticos = 10000;
            avo.Telefone = 80;

            var despesaAvo = avo.ItensCozinha +avo.Eletrodomesticos + avo.Telefone;
            Console.WriteLine("Despesas da mãe RS" + despesaAvo);

            filho.Roupas = 300;
            filho.Eletrodomesticos = 1500;
            filho.Escola = 700.55;


           




        }
    }
}
