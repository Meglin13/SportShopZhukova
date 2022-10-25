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
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {
        Data.Product _currentproduct;
        public AddEditPage(Data.Product product)
        {
            InitializeComponent();

            _currentproduct = product != null ? product : new Data.Product();

            DataContext = _currentproduct;

            CategoryCB.ItemsSource = Data.sportShopZhukovaEntities.GetContext().Categories.ToList();
            SuppliersCB.ItemsSource = Data.sportShopZhukovaEntities.GetContext().Suppliers.ToList();
            UnitCB.ItemsSource = Data.sportShopZhukovaEntities.GetContext().Units.ToList();
            ManufacturerCB.ItemsSource = Data.sportShopZhukovaEntities.GetContext().Manufacturers.ToList();
        }

        private void BackBT_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Pages.AdminPage());
        }

        private void SaveBT_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentproduct.ProductName))
                errors.AppendLine("Укажите имя продукта");

            if (_currentproduct.Manufacturers == null)
                errors.AppendLine("Выберите производителя");

            if (string.IsNullOrWhiteSpace(_currentproduct.ProductDescription))
                errors.AppendLine("Укажите описание");

            if (_currentproduct.ProductQuantityInStock < 0)
                errors.AppendLine("Отрицательное значение товара в наличии");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            try
            {
                _currentproduct.ProductArticleNumber = 0.ToString();
                _currentproduct.ProductMaxDiscountAmount = 0;
                _currentproduct.ProductDiscountAmount = 0;

                int id = Int32.Parse(IDTB.Text);

                if (Data.sportShopZhukovaEntities.GetContext().Product.Where(b => b.Id == id).FirstOrDefault() != null)
                {
                    Data.sportShopZhukovaEntities.GetContext().Product.Add(_currentproduct);
                }

                Data.sportShopZhukovaEntities.GetContext().SaveChanges();

                MessageBox.Show("Сохранено!\n");
                Manager.MainFrame.GoBack();
            }
            //catch (System.Data.Entity.Infrastructure.DbUpdateException)
            //{
            //    MessageBox.Show("Товар с таким же артикулом уже существует");
            //}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
