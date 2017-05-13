using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLP2.Models
{
    public class Utilizador
    {
        public Utilizador(string nome, EnumUtilizadores tipo)
        {
            Nome = nome;
            listaProfissoes = new List<EnumUtilizadores>();
            listaProfissoes.Add(tipo);
        }


        public string Nome { get; set; }
        public List<EnumUtilizadores> listaProfissoes { get; set; }
        public string Email { get; set; }
    }
}
