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
using System.Diagnostics;
using TrabalhoLP2.Models;
using TrabalhoLP2.Controllers;

namespace TrabalhoLP2.Views
{
    /// <summary>
    /// Interaction logic for AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        UtilizadorControllers utilizadoresControllers = new UtilizadorControllers();
        EnumUtilizadores tipo = 0;

        public AdminPage()
        {
            InitializeComponent();
        }

        private void CriarUtilizador_OnClick(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(NomeNovoUtilizador.Text)||tipo==0)
            {
                MessageBox.Show("Nao pode deixar informaçao por preencher.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);

            }
            else
            {
                string user = "";
                if (MessageBox.Show("Adicionar " + NomeNovoUtilizador.Text + " como " + tipo.ToString(), "Aviso", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
                {

                }
                else
                {
                    Utilizador Pessoa = new Utilizador(NomeNovoUtilizador.Text, tipo);
                    utilizadoresControllers.InserirUtilizador(Pessoa);
                    user = "  " + Pessoa.Nome + "/" + Pessoa.listaProfissoes[0];//VER ESTA CENINHAFOFA
                    //Utilizadores.Content += user;
                }
                NomeNovoUtilizador.Text = "";
                tipo = 0;
                ProgramadorButton.Background = Brushes.LightGray;
                DesignerButton.Background = Brushes.LightGray;
                ScrumMasterButton.Background = Brushes.LightGray;
                ProjectManagerButton.Background = Brushes.LightGray;
                ProjectOwnerButton.Background = Brushes.LightGray;
                this.NavigationService.Refresh();
            }
        }

        private void Criacao_OnClick(object sender, RoutedEventArgs e)
        {
            OpcaoCriar.Visibility = Visibility.Hidden;
            Stack.Visibility = Visibility.Visible;
        }

        private void ProgramadorButton_OnClick(object sender, RoutedEventArgs e)
        {
            tipo = EnumUtilizadores.Programador;
            ProgramadorButton.Background = Brushes.DarkSeaGreen;
            DesignerButton.Background = Brushes.LightGray;
            ScrumMasterButton.Background = Brushes.LightGray;
            ProjectOwnerButton.Background = Brushes.LightGray;
            ProjectManagerButton.Background = Brushes.LightGray;
        }
        private void DesignerButton_OnClick(object sender, RoutedEventArgs e)
        {
            tipo = EnumUtilizadores.Designer;
            ProgramadorButton.Background = Brushes.LightGray;
            DesignerButton.Background = Brushes.DarkSeaGreen;
            ScrumMasterButton.Background = Brushes.LightGray;
            ProjectOwnerButton.Background = Brushes.LightGray;
            ProjectManagerButton.Background = Brushes.LightGray;
        }
        private void ScrumMasterButton_OnClick(object sender, RoutedEventArgs e)
        {
            tipo = EnumUtilizadores.Scrum_Master;
            ProgramadorButton.Background = Brushes.LightGray;
            DesignerButton.Background = Brushes.LightGray;
            ScrumMasterButton.Background = Brushes.DarkSeaGreen;
            ProjectOwnerButton.Background = Brushes.LightGray;
            ProjectManagerButton.Background = Brushes.LightGray;
        }
        private void ProjectOwnerButton_OnClick(object sender, RoutedEventArgs e)
        {
            tipo = EnumUtilizadores.Project_Owner;
            ProgramadorButton.Background = Brushes.LightGray;
            DesignerButton.Background = Brushes.LightGray;
            ScrumMasterButton.Background = Brushes.LightGray;
            ProjectOwnerButton.Background = Brushes.DarkSeaGreen;
            ProjectManagerButton.Background = Brushes.LightGray;
        }
        private void ProjectManagerButton_OnClick(object sender, RoutedEventArgs e)
        {
            tipo = EnumUtilizadores.Project_Manager;
            ProgramadorButton.Background = Brushes.LightGray;
            DesignerButton.Background = Brushes.LightGray;
            ScrumMasterButton.Background = Brushes.LightGray;
            ProjectOwnerButton.Background = Brushes.LightGray;
            ProjectManagerButton.Background = Brushes.DarkSeaGreen;
        }

        private void AllUtilizadoresPage_OnClick(object sender, RoutedEventArgs e)
        {
            AllUtilizadoresPage utilizadoresPage = new AllUtilizadoresPage((utilizadoresControllers.ListarUtilizadores()));
            NavigationService.Navigate(utilizadoresPage);
        }

        private void CriarProjetoPage_OnClick(object sender, RoutedEventArgs e)
        {
            CriarProjetoPage criarProjetoPage = new CriarProjetoPage();
            NavigationService.Navigate(criarProjetoPage);
        }

        private void VerProjetosPage_OnClick(object sender, RoutedEventArgs e)
        {

        }

    }
}
