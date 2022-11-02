using System;
using System.Collections.Generic;
using System.Drawing;
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

            if (_currentproduct.Id == 0)
                IDTB.Visibility = Visibility.Hidden;

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
            try
            {
                ProductUtilities productUtilities = new ProductUtilities();

                if (productUtilities.IsProductValid(_currentproduct))
                {
                    _currentproduct.ProductArticleNumber = 0.ToString();
                    _currentproduct.ProductMaxDiscountAmount = 0;
                    _currentproduct.ProductDiscountAmount = 0;

                    int id = Int32.Parse(IDTB.Text);

                    if (_currentproduct.Id == 0)
                    {
                        Data.sportShopZhukovaEntities.GetContext().Product.Add(_currentproduct);
                    }

                    Data.sportShopZhukovaEntities.GetContext().SaveChanges();

                    MessageBox.Show("Сохранено!\n");
                    Manager.MainFrame.Navigate(new Pages.AdminPage());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PhotoLoadBT_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string filePath;

                using (System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        filePath = openFileDialog.FileName;
                        FileInfo file = new FileInfo(filePath);

                        Uri imageUri = new Uri(filePath, UriKind.Absolute);
                        BitmapImage imageBitmap = new BitmapImage(imageUri);

                        var dsf = Math.Round(imageBitmap.Width);

                        if (Math.Round(imageBitmap.Width) <= 300 & Math.Round(imageBitmap.Height) <= 200)
                        {
                            ProductPhotoIMG.Source = imageBitmap;

                        ImageConverter converter = new ImageConverter();

                        JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                        encoder.Frames.Add(BitmapFrame.Create(imageBitmap));
                        using (MemoryStream ms = new MemoryStream())
                        {
                            encoder.Save(ms);
                            byte[] img = ms.ToArray();
                            _currentproduct.ProductPhoto = img;
                        }
                    }
                    else
                        MessageBox.Show("Неправильное соотношение сторон! Необходимо: 300x200", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Плохое изображение!!!!!!!!!" + ex.Message);
            }
        }

        private void ProductQuantityInStockTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            string ClearText = "";

            foreach (var c in ProductQuantityInStockTB.Text)
            {
                if (char.IsDigit(c))
                {
                    ClearText += c;
                }
            }

            ProductQuantityInStockTB.Text = ClearText;
            ProductQuantityInStockTB.SelectionStart = ProductQuantityInStockTB.Text.Length;
        }

        private void ProductCostTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            string ClearText = "";

            string Text = ProductCostTB.Text;

            foreach (var c in Text)
            {
                if (char.IsDigit(c))
                {
                    ClearText += c;
                }
                else if (c == '.')
                {
                    if (Text.Substring(Text.IndexOf(".") + 1).Length < 3 & !Text.Substring(Text.IndexOf(".") + 1).Contains('.'))
                    {
                        ClearText += c;
                    }
                }
            }

            ProductCostTB.Text = ClearText;
            ProductCostTB.SelectionStart = ProductCostTB.Text.Length;
        }
    }
}
