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
            string[] infoTarefa = new string[4];
            infoTarefa[0] = tarefa.Nome;
            infoTarefa[1] = tarefa.Conteudo;
            infoTarefa[2] = tarefa.Estado.ToString();
            if (tarefa.User==null)
            {
                infoTarefa[3] = "";
            }
            else
            {

                infoTarefa[3] = tarefa.User.Nome;
            }
            Directory.CreateDirectory(@"..\..\..\" + tarefa.projetoPertencente.Nome + @"\Tarefas" + @"\" + tarefa.Nome);
            string infoPath = Path.Combine(@"..\..\..\" + tarefa.projetoPertencente.Nome + @"\Tarefas" + @"\" + tarefa.Nome, "Tarefa_Info");
            string subTarefasPath = Path.Combine(@"..\..\..\" + tarefa.projetoPertencente.Nome + @"\Tarefas", tarefa.Nome);
            File.WriteAllLines(infoPath, infoTarefa);
            Directory.CreateDirectory(Path.Combine(subTarefasPath,"SubTarefas"));

            return true;
        }
    }
}
