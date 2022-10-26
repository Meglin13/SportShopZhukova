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
        string cap;

        public LoginPage()
        {
            InitializeComponent();

            CAPTCHASP.Visibility = Visibility.Collapsed;

            cap = MakeCAPTCHA();

            CAPTCHALabel.Content = "CAPTCHA: " + cap;
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
                    if ((CAPTCHACheckTextBox.Text == cap & CAPTCHASP.Visibility == Visibility.Visible) || CAPTCHASP.Visibility == Visibility.Collapsed)
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
                        else if (Manager.currentUser.Role.RoleName == "Администратор")
                        {
                            Manager.MainFrame.Navigate(new Pages.AdminPage());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите капчу!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                } else
                {
                    MessageBox.Show("Пользователей с такими данными не существует!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                    CAPTCHASP.Visibility = Visibility.Visible;
                }
            } else
            {
                MessageBox.Show("Поле логин/пароль/капча пустое!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                CAPTCHASP.Visibility = Visibility.Visible;
            }
        }

        private void EnterGusetButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Pages.ManagerAndAuthUserPage());
        }

        private string MakeCAPTCHA()
        {
            string result = "";

            char[] chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_+|/".ToCharArray();

            Random random = new Random();

            for (int i = 0; i < 4; i++)
            {
                result += chars[random.Next(0, chars.Length - 1)];
            }

            return result;
        }

        private void NewCAPTCHAButton_Click(object sender, RoutedEventArgs e)
        {
            cap = MakeCAPTCHA();
            CAPTCHALabel.Content = "CAPTCHA: " + cap;
        }
    }
}
