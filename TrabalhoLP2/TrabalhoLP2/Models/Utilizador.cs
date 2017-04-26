using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLP2.Models
{
    class Utilizador
    {
        public Utilizador(string nome, string tipo)
        {
            Nome = nome;
            Tipo = tipo;//designer, programador, scrum master, project owner
            TrabalhoDisponivel = 5;
            if (tipo=="Scrum Master"||tipo=="Project Owner")
            {
                TrabalhoDisponivel = 1;
            }
        }

        public string Nome { get; set; }
        public int TrabalhoDisponivel { get; set; }
        public string Tipo { get; set; }
    }
}
