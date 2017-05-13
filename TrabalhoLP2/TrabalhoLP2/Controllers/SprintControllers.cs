using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoLP2.Models;
using System.IO;


namespace TrabalhoLP2.Controllers
{
    class SprintControllers
    {
        private List<Sprint> sprintsList;

        public SprintControllers()
        {
            sprintsList = new List<Sprint>();
        }

        public void InserirSprint(Sprint sprint)
        {
            sprintsList.Add(sprint);
        }

        public bool VerificarSeJaPassouDataLimite(Sprint sprint)
        {
            DateTime dataAtual = new DateTime();
            if (dataAtual.Year>sprint.anoFinal||dataAtual.Year==sprint.anoFinal&&dataAtual.Month>sprint.mesFinal
                || dataAtual.Year == sprint.anoFinal && dataAtual.Month == sprint.mesFinal&&dataAtual.Day>sprint.diaFinal)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool VerificarSeJaTerminou(Sprint sprint)
        {
            foreach (Tarefa tarefa in sprint.listTarefas)
            {
                if (tarefa.Estado != EnumEstados.Concluida)
                {
                    return false;
                }
            }
            return true;
        }

        public Sprint ProcurarSprintId(string id)
        {
            foreach (Sprint sprint in sprintsList)
            {
                if (sprint.Id==id)
                {
                    return sprint;
                }
            }
            return null;
        }

        public bool GravarSprint (Sprint sprint)
        {
            int i = 0;
            string[] infoSprint = new string[sprint.listTarefas.Count+1];
            infoSprint[0] = sprint.diaFinal.ToString() + "/" + sprint.mesFinal.ToString() + "/" + sprint.anoFinal.ToString();
            if (sprint.listTarefas.Count>0)
            {
                foreach (Tarefa tarefa in sprint.listTarefas)
                {
                    infoSprint[i] = tarefa.Nome;
                    i++;
                }
            }


            string ficheiro = Path.Combine(@"..\..\..\" + sprint.projetoPertencente.Nome + @"\Sprints", sprint.Id);
            File.WriteAllLines(ficheiro, infoSprint);

            return true;
        }
    }
}
