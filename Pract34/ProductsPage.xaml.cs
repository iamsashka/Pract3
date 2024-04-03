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
using Pract34.EntityFramework;

namespace Pract34
{
    /// <summary>
    /// Логика взаимодействия для ProductsPage.xaml
    /// </summary>
    public partial class ProductsPage : Page
    {
        private MagazinCosmetikiEntities contextPro = new MagazinCosmetikiEntities();
        public ProductsPage()
        {
            InitializeComponent();
            ProductsPageGrid.ItemsSource = contextPro.Products.ToList();
        }
    }
}
