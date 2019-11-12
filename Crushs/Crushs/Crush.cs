using System;
using System.Collections.Generic;
using System.Text;

namespace Crushs
{
    class Crush
    {
        protected string Apelido { get; set; }
        public string Telefone { get; set; }
        public string Local { get; set; }
        public EstadoCivil EstadoCivilCrush { get; set; }

        public int Avaliacao { get; set; }

        public List<Comportamento> Comportamentos { get; set; }

        private int PropriedadePrivada { get; set; }

    }
    public string Aparencia(int nota)
    {
        switch (nota)
        {
            case 10:
                return "Moreno alto, bonito e sensual";
            case 9:
                return "Moreno, alto, bonito";
            case 8:
                return "Moreno, alto";
            case 7:
                return "Moreno";
        }
    }



    //enum lista pre definida para limitar as possibilidades de escolhas
    public enum EstadoCivil
    {
        Solteiro,
        Namorando,
        Noivo,
        Casado,
        Divorciado,
        Viuvo
    }

    // public void teste()
    // {
    //    PropriedadePrivada = 0;
    //}
    private void BeijosNoBoy(int NivelSaudade)
    {
        bool darBeijosNoBoy = false;
        for (int i = 0; i<NivelSaudade; i+=2)
			{
            darBeijosNoBoy = true;
			}
       }

    public void GanharPresentesDoBoy(List<string> presentes)
    {
        string meuPresente = "Eu vou ganhar";
        //ele conta a quantidade de itens que tem na lista como parâmetro e conta os itens até ele 
        //no foreach não existe o indice, pois ele percorre os elementos que tem na lista 
        foreach(var presente in presentes)
        {
            meuPresente += presente + ",";
        }
        return meuPresente;
    }
}