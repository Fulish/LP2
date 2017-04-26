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
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void AdminPage_OnClick(object sender, RoutedEventArgs e)
        {
            AdminButton.Visibility = Visibility.Hidden;
            Painel.Visibility = Visibility.Visible;
            TextScrumInfo.Visibility = Visibility.Hidden;
        }

        private void EmployeesButton_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void Password_OnClick(object sender, RoutedEventArgs e)
        {
            if (Pass.Password == "desconfiado")
            {
                AdminPage adminPage = new AdminPage();
                NavigationService.Navigate(adminPage);
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
