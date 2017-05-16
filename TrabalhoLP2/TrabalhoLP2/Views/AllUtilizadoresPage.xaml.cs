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
    /// Interaction logic for AllUtilizadoresPage.xaml
    /// </summary>
    public partial class AllUtilizadoresPage : Page
    {
        List<Utilizador> listUsers;

        public AllUtilizadoresPage(List<Utilizador> listUtilizadores)
        {
            listUsers = listUtilizadores;

            InitializeComponent();

            foreach (Utilizador user in listUsers)
            {
                if (user.listaProfissoes.Contains(EnumUtilizadores.Programador))
                {
                    StackPanel newstack = new StackPanel();
                    newstack.Orientation = Orientation.Horizontal;
                    Label infoUser = new Label();
                    infoUser.Content ="-> "+ user.Nome + " " + user.Email+"                         ";
                    infoUser.Foreground = Brushes.Beige;
                    Button editUserButton = new Button();
                    //EditarButton_OnClick(editUserButton, new RoutedEventArgs());
                    editUserButton.Content = "Editar";
                    Button removeUserButton = new Button();
                    removeUserButton.Click += new RoutedEventHandler(ApagarButton_OnClick);
                    //ApagarButton_OnClick(removeUserButton, new RoutedEventArgs());
                    removeUserButton.Content = "Apagar";
                    newstack.Children.Add(infoUser);
                    newstack.Children.Add(editUserButton);
                    newstack.Children.Add(removeUserButton);
                    ProgramadoresStack.Children.Add(newstack);

                }

                else if (user.listaProfissoes.Contains(EnumUtilizadores.Designer))
                {
                    StackPanel newstack = new StackPanel();
                    newstack.Orientation = Orientation.Horizontal;
                    Label infoUser = new Label();
                    infoUser.Content = "-> " + user.Nome + " " + user.Email + "                         ";
                    infoUser.Foreground = Brushes.Beige;
                    Button editUserButton = new Button();
                    //EditarButton_OnClick(editUserButton, new RoutedEventArgs());
                    editUserButton.Content = "Editar";
                    Button removeUserButton = new Button();
                    removeUserButton.Click += new RoutedEventHandler(ApagarButton_OnClick);
                    //ApagarButton_OnClick(removeUserButton, new RoutedEventArgs());
                    removeUserButton.Content = "Apagar";
                    newstack.Children.Add(infoUser);
                    newstack.Children.Add(editUserButton);
                    newstack.Children.Add(removeUserButton);
                    DesignersStack.Children.Add(newstack);
                }
                else if (user.listaProfissoes.Contains(EnumUtilizadores.Scrum_Master))
                {
                    StackPanel newstack = new StackPanel();
                    newstack.Orientation = Orientation.Horizontal;
                    Label infoUser = new Label();
                    infoUser.Content = "-> " + user.Nome + " " + user.Email + "                         ";
                    infoUser.Foreground = Brushes.Beige;
                    Button editUserButton = new Button();
                    //EditarButton_OnClick(editUserButton, new RoutedEventArgs());
                    editUserButton.Content = "Editar";
                    Button removeUserButton = new Button();
                    removeUserButton.Click += new RoutedEventHandler(ApagarButton_OnClick);
                    //ApagarButton_OnClick(removeUserButton, new RoutedEventArgs());
                    removeUserButton.Content = "Apagar";
                    newstack.Children.Add(infoUser);
                    newstack.Children.Add(editUserButton);
                    newstack.Children.Add(removeUserButton);
                    ScrumMastersStack.Children.Add(newstack);

                }
                else if (user.listaProfissoes.Contains(EnumUtilizadores.Project_Owner))
                {
                    StackPanel newstack = new StackPanel();
                    newstack.Orientation = Orientation.Horizontal;
                    Label infoUser = new Label();
                    infoUser.Content = "-> " + user.Nome + " " + user.Email + "                         ";
                    infoUser.Foreground = Brushes.Beige;
                    Button editUserButton = new Button();
                    //EditarButton_OnClick(editUserButton, new RoutedEventArgs());
                    editUserButton.Content = "Editar";
                    Button removeUserButton = new Button();
                    removeUserButton.Click += new RoutedEventHandler(ApagarButton_OnClick);
                    //ApagarButton_OnClick(removeUserButton, new RoutedEventArgs());
                    removeUserButton.Content = "Apagar";
                    newstack.Children.Add(infoUser);
                    newstack.Children.Add(editUserButton);
                    newstack.Children.Add(removeUserButton);
                    ProjectOwnerStack.Children.Add(newstack);

                }
            }

        }

        private void EditarButton_OnClick(object sender, RoutedEventArgs e)
        {
            //por a poder alterar nome e email e acrescentar profissao etc.
        }

        private void ApagarButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Tem a certeza que quer apagar o utilizador?", "Aviso", MessageBoxButton.YesNo, MessageBoxImage.Exclamation)==MessageBoxResult.No)
            {

            }
            else
            {
                //por a remover stack
            }
            this.NavigationService.Refresh();
        }
    }
}
