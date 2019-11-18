using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floricultura
{
    public class Funcionario : DadosPessoa
    {
        public Cargo cargo { get; set; }
        public double Salario { get; set; }

        public DateTime DataEntrada { get; set; }

        public DateTime? DataSaida { get; set; }

        public string TurnoEntrada { get; set; }

        public string TurnoSaida { get; set; }

        public string NumCracha { get; set; }

        public string Banco { get; set; }

        public string ContaCorrente { get; set; }

        public string Agencia { get; set; }

        public int DiaPagamento { get; set; }

        public enum Cargo{
        Administrador,
        Administradora,
        Atendente,
        Florista,
        Condutor,
        Condutora,
        Faxineiro
        }
        
        public void AdmitirFuncionario(string nome,
                                      string cpf,
                                      string rg,
                                      string email,
                                      string telefone,
                                      string celular,
                                      string logradouro,
                                      int numero,
                                      string complemento,
                                      string bairro,
                                      string cidade,
                                      string estado,
                                      Cargo caargo,
                                      string numcracha,
                                      string banco,
                                      string contacorrente,
                                      string agencia,
                                      double salario,
                                      DateTime dataentrada,
                                      string turnoentrada,
                                      string turnosaida,
                                      int diapagamento)
        {

            Nome = nome;
            CPF = cpf;
            RG = rg;
            Email = email;
            Telefone = telefone;
            Celular = celular;
            End.Logradouro = logradouro;
            End.Numero = numero;
            End.Complemento = complemento;
            End.Bairro = bairro;
            End.Cidade = cidade;
            End.Estado = estado;
            cargo = caargo;
            NumCracha = numcracha;
            Banco = banco;
            ContaCorrente = contacorrente;
            Agencia = agencia;
            Salario = salario;
            DataEntrada = DateTime.Today;
            TurnoEntrada = turnoentrada;
            TurnoSaida = turnosaida;
            DiaPagamento = diapagamento;
            Console.WriteLine($"Funcionário(a) {Nome} cadastrado(a) com sucesso.\n" +
                $"Cargo: {cargo}\nNúmero do Cracha: {NumCracha}\nSalário: {Salario} \nHorário de Entrada: {TurnoEntrada}\nHorário de Saída: {TurnoSaida} \n ");
        }

        public void DemitirFuncionario(string nome,
                                      string cpf,
                                      string rg,
                                      Cargo caargo,
                                      string numcracha,
                                      DateTime DataSaida
                                      ) {

            Nome = nome;
            CPF = cpf;
            RG = rg;
            cargo = caargo;
            NumCracha = numcracha;
            DataSaida = DateTime.Today;

            Console.WriteLine($"Funcionário(a): {Nome}, colaboradora no cargo de {cargo}; dono(a) dos seguintes documentos CPF: {CPF}, RG: {RG} e Cracha: {NumCracha}, está sendo desligada da empresa no dia {DataSaida}.");
        
        
        }

    }
}
