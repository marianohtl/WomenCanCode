using System;
using PetShop;


namespace BrincandoDeCodar
{
    class Program
    {
        static void Main(string[] args)
        {
            Veterinario drPet = new Veterinario();
            DadosPessoais();
            DadosPagamento();
        }
            private static void DadosPessoais() {
                Console.WriteLine("Informe o nome do Veterinário");
                string nome = Console.ReadLine();

                Console.WriteLine("Informe o CRMV do Veterinário");
                string crmv = Console.ReadLine();

                Console.WriteLine("Informe o cracha do Veterinário");
                string crasha = Console.ReadLine();

            }


            private static void DadosPagamento()
            {
                Console.WriteLine("Informe o salario para o pagamento do Veterinário");
                decimal salario = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Informe o CRMV para o pagamento do Veterinário");
                string banco = Console.ReadLine();

                Console.WriteLine("Informe a agencia para o pagamento Veterinário");
                string agencia = Console.ReadLine();


                Console.WriteLine("Informe o conta corrente para o pagamento  Veterinário");
                string cc = Console.ReadLine();

            }
           


            }

                
        }
    

