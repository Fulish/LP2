using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLP2.Models
{
    public class Sprint
    {
        public Sprint(string id, int diafinal, int mesfinal, int anofinal, List<Tarefa> listtarefas, Projeto projetopertencente)
        {
            Id = id;
            diaFinal = diafinal;
            mesFinal = mesfinal;
            anoFinal = anofinal;
            listTarefas = new List<Tarefa>();
            listTarefas = listtarefas;
            projetoPertencente = projetopertencente;
        }

        public Projeto projetoPertencente { get; set; }
        public string Id { get; set; }
        public int diaFinal { get; set; }
        public int mesFinal { get; set; }
        public int anoFinal { get; set; }
        public List<Tarefa> listTarefas { get; set; }
    }
}
