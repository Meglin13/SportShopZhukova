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
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        public AdminPage()
        {
            InitializeComponent();

            ProductDG.ItemsSource = Data.sportShopZhukovaEntities.GetContext().Product.ToList();
        }

        private void EditBt_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Pages.AddEditPage((sender as Button).DataContext as Data.Product));
        }

        private void AddBT_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BackBT_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
