using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLP2.Models
{
    class Tarefa
    {
        public Tarefa(string nome, string conteudo, Utilizador user, Projeto projetopertencente)
        {
            Estado = EnumEstados.Por_Comecar;
            Nome = nome;
            Conteudo = conteudo;
            User = user;
            projetoPertencente = projetopertencente;
        }


        public Tarefa(string nome, string conteudo, Projeto projetopertencente)
        {
            Estado = EnumEstados.Por_Comecar;
            Nome = nome;
            Conteudo = conteudo;
            projetoPertencente = projetopertencente;
        }

        public List<SubTarefa> listSubTarefas { get; set; }
        public EnumEstados Estado { get; set; } //em progresso ou acabado
        public string Nome { get; set; }
        public string Conteudo { get; set; }
        public Utilizador User { get; set; }
        public Projeto projetoPertencente { get; set; }
    }
}
