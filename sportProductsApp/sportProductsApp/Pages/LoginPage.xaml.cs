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

namespace sportProductsApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(LoginTextBox.Text) 
                && !string.IsNullOrWhiteSpace(PasswordBox.Password))
            {
                if (Data.sportShopZhukovaEntities.GetContext().User
                    .Any(user => user.UserLogin == LoginTextBox.Text
                    && user.UserPassword == PasswordBox.Password))
                {
                    Manager.currentUser = Data.sportShopZhukovaEntities.GetContext().User
                        .Where(user => user.UserLogin == LoginTextBox.Text 
                        && user.UserPassword == PasswordBox.Password).FirstOrDefault();

                    MessageBox.Show("Успешный вход!", "Инфо", MessageBoxButton.OK, MessageBoxImage.Information);

                    if (Manager.currentUser.Role.RoleName == "Менеджер" ||
                        Manager.currentUser.Role.RoleName == "Клиент")
                    {
                        Manager.MainFrame.Navigate(new Pages.ManagerAndAuthUserPage());
                    }
                }
            } else
            {
                MessageBox.Show("Поле логин/пароль пустое!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void EnterGusetButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Pages.ManagerAndAuthUserPage());
        }
    }
}
