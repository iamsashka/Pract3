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

namespace Pract34.EntityFramework
{
    /// <summary>
    /// Логика взаимодействия для OdnaTable2E.xaml
    /// </summary>
    public partial class OdnaTable2E : Page
    {
        private MagazinCosmetikiEntities contextPro = new MagazinCosmetikiEntities();
        public OdnaTable2E()
        {
            InitializeComponent();
            ProductsPageGrid.ItemsSource= contextPro.Products.ToList();
        }
    }
}
