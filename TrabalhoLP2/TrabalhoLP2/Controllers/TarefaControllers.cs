using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoLP2.Models;
using System.IO;

namespace TrabalhoLP2.Controllers
{
    class TarefaControllers
    {
        private List<Tarefa> tarefasList;

        public TarefaControllers()
        {
            tarefasList = new List<Tarefa>();
        }

        public void InserirTarefa(Tarefa tarefa)
        {
            tarefasList.Add(tarefa);
        }

        public bool GravarTarefaEmProjeto(Tarefa tarefa)
        {
            string[] infoTarefa = new string[2];
            infoTarefa[0] = tarefa.User.ToString();
            infoTarefa[1] = tarefa.Conteudo;
            infoTarefa[2] = tarefa.Estado.ToString();
            string ficheiro = Path.Combine(@"..\..\..\" + tarefa.projetoPertencente.Nome + @"\Tarefas", tarefa.Nome);
            File.WriteAllLines(ficheiro, infoTarefa);
            Directory.CreateDirectory(Path.Combine(ficheiro,"SubTarefas"));

            return true;
        }
    }
}
