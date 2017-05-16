using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TrabalhoLP2.Models;
using TrabalhoLP2.Controllers;
using System.IO;

namespace TrabalhoLP2.Views
{
    /// <summary>
    /// Interaction logic for CriarTarefaPage.xaml
    /// </summary>
    public partial class CriarTarefaPage : Page
    {
        List<Utilizador> listUsers;
        Tarefa tarefa;
        Projeto ProjetoPertencente;

        public CriarTarefaPage(Projeto ProjPertencente)
        {
            ProjetoPertencente = ProjPertencente;
            listUsers = new List<Utilizador>();

            InitializeComponent();

            foreach (Utilizador user in listUsers)
            {
                if (user.listaProfissoes.Contains(EnumUtilizadores.Programador))
                {
                    StackPanel newstack = new StackPanel();
                    newstack.Orientation = Orientation.Horizontal;
                    Button NameUserButton = new Button();
                    NameUserButton.Content = "-> " + user.Nome + " " + user.Email + "                         ";
                    NameUserButton.Foreground = Brushes.Beige;
                    Label addUser = new Label();
                    addUser.Foreground = Brushes.Beige;
                    addUser.Content = "Add";
                    NameUserButton.Click += new RoutedEventHandler(AddButton_OnClick);
                    //ApagarButton_OnClick(removeUserButton, new RoutedEventArgs());
                    newstack.Children.Add(addUser);
                    newstack.Children.Add(NameUserButton);
                    ProgramadoresStack.Children.Add(newstack);

                }

                else if (user.listaProfissoes.Contains(EnumUtilizadores.Designer))
                {
                    StackPanel newstack = new StackPanel();
                    newstack.Orientation = Orientation.Horizontal;
                    Label infoUser = new Label();
                    infoUser.Content = "-> " + user.Nome + " " + user.Email + "                         ";
                    infoUser.Foreground = Brushes.Beige;
                    Button addUserButton = new Button();
                    addUserButton.Click += new RoutedEventHandler(AddButton_OnClick);
                    //ApagarButton_OnClick(removeUserButton, new RoutedEventArgs());
                    addUserButton.Content = "Add";
                    newstack.Children.Add(infoUser);
                    newstack.Children.Add(addUserButton);
                    DesignersStack.Children.Add(newstack);
                }
            }
        }

        private void CriarTarefaButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(NomeTarefa.Text) || string.IsNullOrEmpty(DescricaoTarefa.Text))
            {
                MessageBox.Show("Preencha todos os espaços obrigatorios.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
                NomeTarefa.Text = ""; DescricaoTarefa.Text = "";
                this.NavigationService.Refresh();
            }
            else
            {
                if (MessageBox.Show("Tem a certeza que quer criar esta tarefa?", "Aviso", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    tarefa = new Tarefa(NomeTarefa.Text,DescricaoTarefa.Text,ProjetoPertencente);
                    InfoTarefaStack.Visibility = Visibility.Hidden;
                    EditarTarefa.Visibility = Visibility.Visible;
                    NomeTarefaDefinitivo.Content += tarefa.Nome;
                    DescricaoDefinitiva.Content += tarefa.Conteudo;
                    if (tarefa.User!=null)
                    {
                        UserNome.Content = tarefa.User.Nome;
                    }
                    else
                    {
                        UserNome.Content = "(Indefinido)";
                    }
                    TituloGrid.Content = "Ver Tarefa";
                    this.NavigationService.Refresh();
                }
                else
                {
                    NomeTarefa.Text = ""; DescricaoTarefa.Text = "";
                    this.NavigationService.Refresh();
                }
            }


            TarefaControllers pqpp = new TarefaControllers();
            pqpp.GravarTarefaEmProjeto(tarefa);
            MessageBox.Show("Tarefa Gravado Com Sucesso!!!", "Concluido", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void AddButton_OnClick(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("User Adicionado com sucesso!!", "Concluido", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void CriarSubTarefaButton_OnClick(object sender, RoutedEventArgs e)
        {
            CriarSubTarefaPage criarSubTarefasPage = new CriarSubTarefaPage();
            NavigationService.Navigate(criarSubTarefasPage);
        }
    }
}
