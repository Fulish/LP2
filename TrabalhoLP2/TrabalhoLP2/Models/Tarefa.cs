using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLP2.Models
{
    class Tarefa
    {
        public Tarefa(bool estado, string conteudo, Utilizador user, Projeto projetopertencente)
        {
            Estado = estado;
            Conteudo = conteudo;
            User = user;
            projetoPertencente = projetopertencente;
        }

        public bool Estado { get; set; } //em progresso ou acabado
        public string Conteudo { get; set; }
        public Utilizador User { get; set; }
        public Projeto projetoPertencente { get; set; }
    }
}
