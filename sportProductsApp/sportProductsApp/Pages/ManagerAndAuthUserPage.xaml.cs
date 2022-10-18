using System;
using System.Collections.Generic;
using System.IO;
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
        public static bool PriceOrderByDesc { get; set; } = false;
        public static bool PriceOrderBy { get; set; } = false;
        public ManagerAndAuthUserPage()
        {
            InitializeComponent();

            if (Manager.currentUser != null)
            {
                FIOTextBlock.Text = Manager.currentUser.UserSurname + " " +
                                Manager.currentUser.UserName + " " +
                                Manager.currentUser.UserPatronymic + " ";
            }

            var manufacturers = Data.sportShopZhukovaEntities.GetContext().Manufacturers.ToList();
            manufacturers.Insert(0, new Data.Manufacturers { Name = "Все производители" });

            ManufacturerComboBox.ItemsSource = manufacturers;
            ManufacturerComboBox.SelectedIndex = 0;

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

            if (!string.IsNullOrEmpty(SearchTextBox.Text))
            {
                search = search.Where(d => d.Units.Unit.ToString().ToLower().Contains(SearchTextBox.Text.ToLower())
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
                ).ToList();
            }

            if (PriceOrderBy == true)
            {
                search = search.OrderBy(p => p.ProductCost).ToList();
            }
            
            if (PriceOrderByDesc == true)
            {
                search = search.OrderByDescending(p => p.ProductCost).ToList();
            }

            var selectManufacturer = ManufacturerComboBox.SelectedItem as Data.Manufacturers;

            if (selectManufacturer.Name != "Все производители")
            {
                search = search.Where(d => d.Manufacturers.Name == selectManufacturer.Name).ToList();
            }

            if (search.Count() == 0)
            {
                MessageBox.Show("Смягчите фильтры! Нет доступных результатов!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning);
                ListView.ItemsSource = null;
            }
            else
            {
                ListView.ItemsSource = search;
                CounterOfRecordsLabel.Content = $"{search.Count()}/{GlobalCount}";
            }
        }

        private void ManufacturerComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update();
        }

        private void PriceOrderByDescRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            PriceOrderByDesc = true;
            Update();
        }

        private void PriceOrderByRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            PriceOrderBy = true;
            Update();
        }

        private void PriceOrderByRadioButton_Unchecked(object sender, RoutedEventArgs e)
        {
            PriceOrderBy = false;
            Update();
        }

        private void PriceOrderByDescRadioButton_Unchecked(object sender, RoutedEventArgs e)
        {
            PriceOrderByDesc = false;
            Update();
        }
    }
}
