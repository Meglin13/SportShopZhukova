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
    /// Логика взаимодействия для ManagerAndAuthUserPage.xaml
    /// </summary>
    public partial class ManagerAndAuthUserPage : Page
    {
        public ManagerAndAuthUserPage()
        {
            InitializeComponent();

            FIOTextBlock.Text = Manager.currentUser.UserSurname + " " +
                                Manager.currentUser.UserName + " " +
                                Manager.currentUser.UserPatronymic + " ";

            //CounterOfRecordsLabel.Content = string.Empty;

            var currentProduct = Data.sportShopZhukovaEntities.GetContext().Product.ToList();
            ListView.ItemsSource = currentProduct;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (Manager.MainFrame.CanGoBack)
            {
                Manager.MainFrame.GoBack();
            }
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ManufacturerComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
