// classe nativa do .net 
using System;
using System.Collections.Generic;


//solution é quem agrupa todos os projetos

//projeto é onde se agrupam as classes

// namespace ajuda a identificar a qual projeto a classe pertence

//sobrenomme da classe, para que possamos usar o mesmo nome de classe no mesmo sistema 
namespace OOClasse
{
    class Program
    {
        //métotdo void que não retorna nada 
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            //aqui estamos passando os parâmetros obrigatórios que foram solicitados no consultor  
            Programadora cSharper = new Programadora(9,true);


            cSharper.Linguagens = new List<string>();
            cSharper.Linguagens.Add("c#");
            cSharper.Linguagens.Add("JS");

            cSharper.PossuiGraduacao = true;
            cSharper.Salario = 20000;
            cSharper.TrabalhaNaArea = true;


            cSharper.Idade = 24;
            cSharper.Nome = "Thalita";
            cSharper.NomeDaMae = "Cida";
            

                  //estamos instanciando a propriedade , um objeto dentro de outro objeto 
            cSharper.MeuEndereco = new Endereco();
            cSharper.MeuEndereco.Bairro = "Mooca";
            cSharper.MeuEndereco.Cidade = "SP";
            cSharper.MeuEndereco.Complemento = "Nenhum";
                                               

            //interpolação
            Console.WriteLine($"Hello {pessoa.Nome},\n você mora no bairro {pessoa.MeuEndereco.Bairro},\n e tem {pessoa.Idade} anos.");

            //
            string texto = "Olá" + pessoa.Nome + ", você mora no bairro " + pessoa.MeuEndereco.Bairro + ".";

            string t = string.Format("Ola (0), você mora no bairro (1)");

            Console.WriteLine(texto);
            Console.WriteLine(t);

        }
    }
}
