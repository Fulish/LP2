using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLP2.Models
{
    class SubTarefa
    {

        public SubTarefa(string nome, string conteudo, Tarefa tarefapertencente)
        {
            Estado = EnumEstados.Por_Comecar;
            Conteudo = conteudo;
            tarefaPertencente = tarefapertencente;
            Nome = nome;
        }

        public string Nome { get; set; }
        public EnumEstados Estado { get; set; }
        public string Conteudo { get; set; }
        public Tarefa tarefaPertencente { get; set; }
    }
}
