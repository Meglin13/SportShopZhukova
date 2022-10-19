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
        Data.Product _currentProduct;
        public AddEditPage(Data.Product product)
        {
            InitializeComponent();

            _currentProduct = product != null ? product : new Data.Product();

            DataContext = _currentProduct;
        }

        private void BackBT_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SaveBT_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
