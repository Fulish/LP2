using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLP2.Models
{
    class Projeto
    {
        public Projeto(bool estado, string conteudo, Utilizador owner)
        {
            Estado = estado;
            Conteudo = conteudo;
            Owner = owner;
        }

        public bool Estado { get; set; }
        public string Conteudo { get; set; }
        public Utilizador Owner { get; set; }
    }
}
