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

namespace TrabalhoLP2.Views
{
    /// <summary>
    /// Interaction logic for CriarProjetoPage.xaml
    /// </summary>
    public partial class CriarProjetoPage : Page
    {

        Utilizador owner;
        Projeto NovoProj;
        ProjetoControllers pqpp = new ProjetoControllers();


        public CriarProjetoPage()
        {
            InitializeComponent();
        }

        private void CriarProjButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(NomeProjeto.Text)||string.IsNullOrEmpty(OwnerName.Text))
            {
                MessageBox.Show("Preencha todos os espaços obrigatorios.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
                NomeProjeto.Text = ""; OwnerName.Text = ""; DescricaoProjeto.Text = "";
                this.NavigationService.Refresh();
            }
            else
            {
                if (MessageBox.Show("Tem a certeza que quer criar este projeto?", "Aviso", MessageBoxButton.YesNo, MessageBoxImage.Question)==MessageBoxResult.Yes)
                {
                    owner = new Utilizador(OwnerName.Text, EnumUtilizadores.Project_Owner);
                    NovoProj = new Projeto(NomeProjeto.Text, DescricaoProjeto.Text, owner);
                    pqpp.GravarProjeto(NovoProj);
                    InfoProjetoStack.Visibility = Visibility.Hidden;
                    CriarSprintButton.Visibility = Visibility.Visible;
                    CriarTarefaButton.Visibility = Visibility.Visible;
                    RelatarBuggButton.Visibility = Visibility.Visible;
                    GravarProjetoButton.Visibility = Visibility.Visible;
                    FazerEquipaButton.Visibility = Visibility.Visible;
                    TituloGrid.Content = "Ver Projeto";
                }
                else
                {
                    this.NavigationService.Refresh();
                }
            }
        }

        private void CriarTarefaButton_OnClick(object sender, RoutedEventArgs e)
        {
            CriarTarefaPage criarTarefaPage = new CriarTarefaPage(NovoProj);
            NavigationService.Navigate(criarTarefaPage);
        }

        private void CriarBuggButton_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void CriarSprintButton_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void FazerEquipaButton_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void GravarProjetoButton_OnClick(object sender, RoutedEventArgs e)
        {
            pqpp.GravarProjeto(NovoProj);
            MessageBox.Show("Projeto Gravado Com Sucesso!!!","Concluido",MessageBoxButton.OK,MessageBoxImage.Information);
        }
    }
}
