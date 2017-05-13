using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoLP2.Models;
using System.IO;


namespace TrabalhoLP2.Controllers
{
    class ProjetoControllers
    {
        private List<Projeto> projetosList;

        public ProjetoControllers()
        {
            projetosList = new List<Projeto>();
        }

        public void InserirProjeto(Projeto projeto)
        {
            projetosList.Add(projeto);
        }


        public bool GravarProjeto(Projeto projeto)
        {
            string projectName = projeto.Nome;
            int i = 0;

            Directory.CreateDirectory(@"..\..\..\"+projectName);//criar projetos
            Directory.CreateDirectory(Path.Combine(@"..\..\..\" + projectName, "Tarefas"));
            Directory.CreateDirectory(Path.Combine(@"..\..\..\" + projectName, "Buggs"));//criar pasta pra buggs
            Directory.CreateDirectory(Path.Combine(@"..\..\..\" + projectName, "Sprints"));//criar pasta pra sprints
            string ficheiroPath = Path.Combine(@"..\..\..\" + projectName, "Projeto_Info");
            string[] infoProj = new string[projeto.Equipa.Count+5];
            infoProj[0] = projeto.Nome;
            infoProj[1] = projeto.Conteudo;
            infoProj[2] = projeto.Estado.ToString();
            infoProj[3] = projeto.Owner.Nome;
            if (projeto.ScrumMaster!=null)
            {
                infoProj[4] = projeto.ScrumMaster.ToString();
            }

            if (projeto.Equipa.Count!=0)
            {
                foreach (Utilizador user in projeto.Equipa)
                {
                    infoProj[i] = user.Nome;
                    i++;
                }
            }

            File.WriteAllLines(ficheiroPath,infoProj);

            foreach (Tarefa tarefa in projeto.listTarefas)
            { 
                Directory.CreateDirectory(Path.Combine(@"..\..\..\" + projectName + @"\Tarefas", tarefa.Nome));//criar tarefas
                if (tarefa.listSubTarefas.Count==0)
                {
                    string[] infoTarefa = new string[5];
                    infoTarefa[0] = tarefa.Nome;
                    infoTarefa[1] = tarefa.Conteudo;
                    infoTarefa[2] = tarefa.Estado.ToString();
                    infoTarefa[3] = tarefa.User.ToString();
                    string tarefasPath = Path.Combine(@"..\..\..\" + projectName + @"\Tarefas", tarefa.Nome);
                    Directory.CreateDirectory(tarefasPath);
                }
                else
                {
                    string[] infoTarefa = new string[tarefa.listSubTarefas.Count+4];
                    infoTarefa[0] = tarefa.User.ToString();
                    infoTarefa[1] = tarefa.Conteudo;
                    infoTarefa[2] = tarefa.Estado.ToString();
                    infoTarefa[3] = tarefa.Nome;
                    string tarefasPath;
                    foreach (SubTarefa subTarefa in tarefa.listSubTarefas)
                    {
                        tarefasPath = Path.Combine(@"..\..\..\" + projectName + @"\Tarefas", tarefa.Nome);
                        Directory.CreateDirectory(tarefasPath);//criar subtarefas
                        string[] infoSubTarefa = new string[2];
                        infoSubTarefa[1] = subTarefa.Estado.ToString();
                        infoSubTarefa[0] = subTarefa.Conteudo;
                        string ficheiro = Path.Combine(@"..\..\..\" + projectName + @"\Tarefas", subTarefa.Nome);
                        File.WriteAllLines(Path.Combine(ficheiro, "SubTarefas"), infoSubTarefa);
                    }
                }
            }



            return true;


        }
    }
}
