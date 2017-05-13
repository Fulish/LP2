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

        public List<Utilizador> ListarUtilizadores()
        {
            List<Utilizador> listagem = new List<Utilizador>();
            foreach (Utilizador utilizador in utilizadoresList)
            {
                listagem.Add(utilizador);
            }
            return listagem;
        }
    }
}
