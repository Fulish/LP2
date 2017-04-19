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
using TrabalhoLP2.ScrumBoard;

namespace TrabalhoLP2
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ScrumBoard_OnClick(object sender, RoutedEventArgs e)
        {
            ScrumButton.Visibility = Visibility.Hidden;
            Painel.Visibility = Visibility.Visible;
            TextScrumInfo.Visibility = Visibility.Hidden;
        }

        private void Inicialize_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void Password_OnClick(object sender, RoutedEventArgs e)
        {
            if (Pass.Password=="desconfiado")
            {
                ScrumBoardPage scrumBoardPage = new ScrumBoardPage();
                NavigationService.Navigate(scrumBoardPage);
            }
            else
            {
                MessageBox.Show("Password incorreta", "Erro");
                Pass.Password = "";
            }
        }

        private void Scrum_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            string navigateUri = ScrumInfo.NavigateUri.ToString();
            Process.Start(new ProcessStartInfo(navigateUri));
            e.Handled = true;
        }
    }
}
