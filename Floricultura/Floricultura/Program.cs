using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floricultura
{
    class Program
    {
        static void Main(string[] args)
        {
            


            Funcionario novofuncionario = new Funcionario();
            //Endereco End = new Endereco();

            novofuncionario.Nome = "Ana Marello";
            novofuncionario.CPF = "0000000";
            novofuncionario.RG = "000000";
            novofuncionario.Email = "ana@outlook.com";
            novofuncionario.Telefone = "0000-0000";
            novofuncionario.Celular = "0000-0000";
            //novofuncionario.DataNascimento = DateTime.Parse("2/16/2008 12:15:12 PM");
            novofuncionario.End.Logradouro = "Avenida das joaninhas";
            novofuncionario.End.Numero = 4;
            novofuncionario.End.Complemento = "A";
            novofuncionario.End.Bairro = "Mooca";
            novofuncionario.End.Estado = "SP";
            novofuncionario.End.Cidade = "São Paulo";
            novofuncionario.cargo = Funcionario.Cargo.Administradora;
            novofuncionario.NumCracha = "000099900";
            novofuncionario.Banco = "Itaú";
            novofuncionario.ContaCorrente = "000000";
            novofuncionario.Agencia = "000";


            novofuncionario.AdmitirFuncionario(
                novofuncionario.Nome,
                novofuncionario.CPF,
                novofuncionario.RG,
                novofuncionario.Email,
                novofuncionario.Telefone,
                novofuncionario.Celular,
                novofuncionario.End.Logradouro,
                novofuncionario.End.Numero,
                novofuncionario.End.Complemento,
                novofuncionario.End.Bairro,
                novofuncionario.End.Estado,
                novofuncionario.End.Cidade,
                novofuncionario.cargo,
                novofuncionario.NumCracha,
                novofuncionario.Banco,
                novofuncionario.ContaCorrente,
                novofuncionario.Agencia,1200.00,  DateTime.Today, "08:00","23:00",10);
        

            novofuncionario.DemitirFuncionario(
                 novofuncionario.Nome,
                 novofuncionario.CPF,
                 novofuncionario.RG,
                 novofuncionario.cargo,
                 novofuncionario.NumCracha,
                 DateTime.Today
                    );

            Console.ReadLine();


            //Fazer Pedido
            FichaCliente ficha1 = new FichaCliente();
            ficha1.NumPedido = "111111";
            ficha1.kits.Arranjos = true;
            ficha1.kits.Astromelias = true;
            ficha1.kits.Cravos = true;
            ficha1.kits.Gerberas = true;
            ficha1.kits.Pelucias = true;
            ficha1.kits.Lacos = true;
            ficha1.ValorPedido = 1594.99;

            ficha1.Nome = "Armelindo Santos";
            ficha1.Presente = true;
            ficha1.RG = "0000000";
            ficha1.CartaoCredito = "00000000-0";
            ficha1.DescricaoCartao = "Para Amélia com muito amor, Armelindo";
            ficha1.Celular = "99999-9999";
            ficha1.End.Logradouro = "Rua da Amélia";
            ficha1.End.Bairro = "Santa Cecília";
            ficha1.End.Cidade = "São Paulo";
            ficha1.End.Estado = "SP";
            ficha1.End.Numero = 6;
            ficha1.Entrega = true;
        }

    }
}
