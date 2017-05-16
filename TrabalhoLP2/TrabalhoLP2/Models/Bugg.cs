using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLP2.Models
{
    public class Bugg
    {
        public Bugg(string nome, string conteudo, Projeto projetopertencente)
        {
            Nome = nome;
            Conteudo = conteudo;
            projetoPertencente = projetopertencente;
        }

        public Projeto projetoPertencente { get; set; }
        public string Nome { get; set; }
        public string Conteudo { get; set; }
    }
}
