using System;
using System.Collections.Generic;

namespace Crushs
{
    class Program
    {
        static void Main(string[] args)
        {
            Crush marido = new Crush();
            marido.Apelido = "Baby";
            marido.Avaliacao = 6;
            marido.Comportamentos = new List<Comportamento>();

            marido.Comportamentos.Add(new Comportamento
            {
                Descricao = "Engraçado",
                Intensidade = 5
            });

            //ou podemos fazer assim 
            Comportamento compEngraçado = new Comportamento();
            compEngraçado.Descricao = "Alegre";
            compEngraçado.Intensidade = 9;

            compEngraçado.IncluirIntensidade(5);

            Console.WriteLine(compEngraçado.Intensidade);

            compEngraçado.IncluirIntensidade(1);

            Console.WriteLine(compEngraçado.Intensidade);

            Comportamento compRomantico = new Comportamento();
            compRomantico.Descricao = "Romântico";
            compRomantico.Intensidade = 1;

            compRomantico.IncluirIntensidade(1);

            marido.Comportamentos.Add(compRomantico);
            marido.Comportamentos.Add(compEngraçado);



        }
    }
}
