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
        string tipo = "";

        public AdminPage()
        {
            InitializeComponent();
        }

        private void CriarUtilizador_OnClick(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(NomeNovoUtilizador.Text)||tipo=="")
            {
                MessageBox.Show("Nao pode deixar informaçao por preencher.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);

            }
            else
            {
                string user = "";
                if (MessageBox.Show("Adicionar " + NomeNovoUtilizador.Text + " como " +tipo, "Aviso", MessageBoxButton.YesNo, MessageBoxImage.Question)==MessageBoxResult.No)
                {

                }
                else
                {
                    Utilizador Pessoa = new Utilizador(NomeNovoUtilizador.Text, tipo);
                    utilizadoresControllers.InserirUtilizador(Pessoa);
                    user = "  " + Pessoa.Nome + "/" + Pessoa.Tipo + "[" + Pessoa.TrabalhoDisponivel + "]";
                    Utilizadores.Content += user;
                }
                NomeNovoUtilizador.Text = "";
                tipo = "";
                ProgramadorButton.Background = Brushes.LightGray;
                DesignerButton.Background = Brushes.LightGray;
                ScrumMasterButton.Background = Brushes.LightGray;
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
            tipo = "Programador";
            ProgramadorButton.Background = Brushes.DarkSeaGreen;
            DesignerButton.Background = Brushes.DarkRed;
            ScrumMasterButton.Background = Brushes.DarkRed;
        }

        private void DesignerButton_OnClick(object sender, RoutedEventArgs e)
        {
            tipo = "Designer";
            ProgramadorButton.Background = Brushes.DarkRed;
            DesignerButton.Background = Brushes.DarkSeaGreen;
            ScrumMasterButton.Background = Brushes.DarkRed;
        }
        private void ScrumMasterButton_OnClick(object sender, RoutedEventArgs e)
        {
            tipo = "Scrum Master";
            ProgramadorButton.Background = Brushes.DarkRed;
            DesignerButton.Background = Brushes.DarkRed;
            ScrumMasterButton.Background = Brushes.DarkSeaGreen;
        }

        private void CriarProjetoPage_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void VerProjetosPage_OnClick(object sender, RoutedEventArgs e)
        {

        }

    }
}
