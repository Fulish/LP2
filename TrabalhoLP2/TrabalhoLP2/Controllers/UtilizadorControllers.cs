using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoLP2.Models;

namespace TrabalhoLP2.Controllers
{
    class UtilizadorControllers
    {
        private List<Utilizador> utilizadoresList;

        public UtilizadorControllers()
        {
            utilizadoresList = new List<Utilizador>();
        }

        public void InserirUtilizador(Utilizador utilizador)
        {
            utilizadoresList.Add(utilizador);
        }

        public bool DarTarefa(Utilizador utilizador)
        {
            if (utilizador.TrabalhoDisponivel < 1)
            {
                return false;
            }
            else
            {
                utilizador.TrabalhoDisponivel = utilizador.TrabalhoDisponivel - 1;
                return true;
            }
        }

        public List<string> ListarUtilizadores()
        {
            List<string> listagem = new List<string>();
            foreach (Utilizador utilizador in utilizadoresList)
            {
                listagem.Add(string.Concat("  " + utilizador.Nome + "/" + utilizador.Tipo + " [" + utilizador.TrabalhoDisponivel + "]"));
            }
            return listagem;
        }
    }
}
