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
        public static string GlobalCount { get; set; }
        public ManagerAndAuthUserPage()
        {
            InitializeComponent();

            if (Manager.currentUser != null)
            {
                FIOTextBlock.Text = Manager.currentUser.UserSurname + " " +
                                Manager.currentUser.UserName + " " +
                                Manager.currentUser.UserPatronymic + " ";
            }
            

            ManufacturerComboBox.ItemsSource = Data.sportShopZhukovaEntities.GetContext().Manufacturers.ToList();

            var currentProduct = Data.sportShopZhukovaEntities.GetContext().Product.ToList();
            ListView.ItemsSource = currentProduct;

            GlobalCount = currentProduct.Count().ToString();

            CounterOfRecordsLabel.Content = $"{currentProduct.Count}/{GlobalCount}";
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
            Update();
        }

        public void Update()
        {
            var search = Data.sportShopZhukovaEntities.GetContext().Product.ToList();

            var search2 = search.Where(d => d.Units.Unit.ToString().ToLower().Contains(SearchTextBox.Text.ToLower())
                || d.Manufacturers.Name.ToString().ToLower().Contains(SearchTextBox.Text.ToLower())
                || d.Suppliers.Name.ToString().ToLower().Contains(SearchTextBox.Text.ToLower())
                || d.Categories.Name.ToString().ToLower().Contains(SearchTextBox.Text.ToLower())
                || d.ProductArticleNumber.ToString().ToLower().Contains(SearchTextBox.Text.ToLower())
                || d.ProductName.ToString().ToLower().Contains(SearchTextBox.Text.ToLower())
                || d.ProductCost.ToString().ToLower().Contains(SearchTextBox.Text.ToLower())
                || d.ProductMaxDiscountAmount.ToString().ToLower().Contains(SearchTextBox.Text.ToLower())
                || d.ProductDiscountAmount.ToString().ToLower().Contains(SearchTextBox.Text.ToLower())
                || d.ProductQuantityInStock.ToString().ToLower().Contains(SearchTextBox.Text.ToLower())
                || d.ProductDescription.ToString().ToLower().Contains(SearchTextBox.Text.ToLower())
                );

            if (search2.Count() == 0)
            {
                MessageBox.Show("Смягчите фильтры! Нет доступных результатов!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning);
                ListView.ItemsSource = Data.sportShopZhukovaEntities.GetContext().Product.ToList();
            }
            else
            {
                ListView.ItemsSource = search2;
                CounterOfRecordsLabel.Content = $"{search2.Count()}/{GlobalCount}";
            }
        }

        private void ManufacturerComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
