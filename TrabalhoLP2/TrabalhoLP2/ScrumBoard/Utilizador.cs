using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLP2.ScrumBoard
{
    class Utilizador
    {
        public Utilizador(string nome)
        {
            Nome = nome;
            TrabalhoDisponivel = 5;
        }

        public string Nome { get; set; }
        public int TrabalhoDisponivel { get; set; }
    }
}
