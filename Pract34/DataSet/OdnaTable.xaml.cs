using Pract34.DataSet.MagazinCosmetikiDataSetTableAdapters;
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

namespace Pract34
{
    /// <summary>
    /// Логика взаимодействия для OdnaTable.xaml
    /// </summary>
    public partial class OdnaTable : Page
    {
        ProductsTableAdapter productii = new ProductsTableAdapter();
        public OdnaTable()
        {
            InitializeComponent();
            ProductsGrid.ItemsSource = productii.GetDataBy();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        { 
            ProductsGrid.Columns[0].Visibility = Visibility.Collapsed;
            ProductsGrid.Columns[2].Visibility = Visibility.Collapsed;
            ProductsGrid.Columns[3].Visibility = Visibility.Collapsed;

            ProductsGrid.Columns[1].Header = "Название продукта";
            ProductsGrid.Columns[4].Header = "Цена";
            ProductsGrid.Columns[5].Header = "Категории";
            ProductsGrid.Columns[6].Header = "Страна производства";
        }
    }
    
}
