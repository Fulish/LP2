using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoLP2.Models;
using System.IO;


namespace TrabalhoLP2.Controllers
{
    class SubTarefaControllers
    {
        private List<SubTarefa> subTarefasList;

        public SubTarefaControllers()
        {
            subTarefasList = new List<SubTarefa>();
        }

        public void InserirSubTarefa(SubTarefa subTarefa)
        {
            subTarefasList.Add(subTarefa);
        }

        public bool GravarSubTarefaEmProjeto(SubTarefa subTarefa)
        {
            string[] infoSubTarefa = new string[2];
            infoSubTarefa[1] = subTarefa.Estado.ToString();
            infoSubTarefa[0] = subTarefa.Conteudo;
            string ficheiro = Path.Combine(@"..\..\..\" + subTarefa.tarefaPertencente.projetoPertencente.Nome + @"\Tarefas", subTarefa.Nome);
            Directory.CreateDirectory(Path.Combine(ficheiro, "SubTarefas"));
            File.WriteAllLines(Path.Combine(ficheiro, "SubTarefas"), infoSubTarefa);


            return true;
        }
    }
}
