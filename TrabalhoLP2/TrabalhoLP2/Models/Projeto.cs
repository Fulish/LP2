using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLP2.Models
{
    public class Projeto
    {
        public Projeto(string nome, string conteudo, Utilizador owner)
        {
            Estado = EnumEstados.Por_Comecar;
            Nome = nome;
            Conteudo = conteudo;
            Owner = owner;
            Equipa = new List<Utilizador>();
            listTarefas = new List<Tarefa>();
        }

        public List<Tarefa> listTarefas { get; set; }
        public List<Utilizador> Equipa { get; set; }
        public Utilizador ScrumMaster { get; set; }
        public EnumEstados Estado { get; set; }
        public string Conteudo { get; set; }
        public string Nome { get; set; }
        public Utilizador Owner { get; set; }
    }
}
