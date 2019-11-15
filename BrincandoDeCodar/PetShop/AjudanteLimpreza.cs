using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop
{
    public class AjudanteLimpreza : Funcionario
    {
        public bool PossuiUniforme { get; set; }

        public string TamanhoUniforme { get; set; }

        public Turno Turno { get; set; }
    }

    public enum Turno
    {
        Manha,
        Tarde,
        Noite
    }
}
