using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLP2.Models
{
    class SubTarefa
    {

        public SubTarefa(bool estado, string conteudo, Tarefa tarefapertencente)
        {
            Estado = estado;
            Conteudo = conteudo;
            tarefaPertencente = tarefapertencente;
        }

        public bool Estado { get; set; }
        public string Conteudo { get; set; }
        public Tarefa tarefaPertencente { get; set; }
    }
}
