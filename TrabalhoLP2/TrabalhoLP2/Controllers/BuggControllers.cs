using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoLP2.Models;
using System.IO;

namespace TrabalhoLP2.Controllers
{
    class BuggControllers
    {
        private List<Bugg> buggsList;

        public BuggControllers()
        {
            buggsList = new List<Bugg>();
        }

        public void InserirBugg(Bugg bugg)
        {
            buggsList.Add(bugg);
        }

        public bool GravarBugg(Bugg bugg)
        {
            string[] infoBugg = new string[2];
            infoBugg[0] = bugg.Conteudo;
            string ficheiro = Path.Combine(@"..\..\..\" + bugg.projetoPertencente.Nome + @"\Buggs", bugg.Nome);
            File.WriteAllLines(ficheiro, infoBugg);
            return true;
        }
    }
}
