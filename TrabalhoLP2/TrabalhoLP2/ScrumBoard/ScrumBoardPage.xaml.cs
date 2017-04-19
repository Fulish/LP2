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

namespace TrabalhoLP2.ScrumBoard
{
    /// <summary>
    /// Interaction logic for ScrumBoardPage.xaml
    /// </summary>
    public partial class ScrumBoardPage : Page
    {
        UtilizadorController utilizadoresControllers = new UtilizadorController();

        public ScrumBoardPage()
        {
            InitializeComponent();            
        }

        private void CriarUtilizador_OnClick(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(NomeNovoUtilizador.Text))
            {
                MessageBox.Show("Preencha todo o formulario.", "Aviso");
            }
            else
            {
                string user="";
                MessageBox.Show("Utilizador inserido com sucesso", "Concluido");
                Utilizador Pessoa = new Utilizador(NomeNovoUtilizador.Text);
                utilizadoresControllers.InserirUtilizador(Pessoa);
                user="  " +Pessoa.Nome + "["+Pessoa.TrabalhoDisponivel+"]";
                Utilizadores.Content += user;
                NomeNovoUtilizador.Text = "";
                this.NavigationService.Refresh();
            }
        }

        private void Criacao_OnClick(object sender, RoutedEventArgs e)
        {
            OpcaoCriar.Visibility = Visibility.Hidden;
            Stack.Visibility = Visibility.Visible;
        }

        private void NewProjeto_OnClick(object sender, RoutedEventArgs e)
        {
            if (Projeto1.Text==" - ")
            {
                Projeto1.Text += "Ainda tenho de por a permitir escrever aqui";
                ButtonP1.Visibility = Visibility.Visible;
            }
            else if (Projeto2.Text==" - ")
            {
                Projeto2.Text += "Ainda tenho de por a permitir escrever aqui";
                ButtonP2.Visibility = Visibility.Visible;
            }
            else if (Projeto3.Text == " - ")
            {
                Projeto3.Text += "Ainda tenho de por a permitir escrever aqui";
                ButtonP3.Visibility = Visibility.Visible;
            }
            else
            {
                MessageBox.Show("Limite maximo de Projetos atingidos", "Aviso");
            }
        }
        private void NewTarefa_OnClick(object sender, RoutedEventArgs e)
        {

        }
        private void NewSubTarefa_OnClick(object sender, RoutedEventArgs e)
        {

        }
        private void NewProgresso_OnClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
