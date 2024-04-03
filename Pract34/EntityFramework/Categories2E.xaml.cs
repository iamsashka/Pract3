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
    /// Логика взаимодействия для Categories2E.xaml
    /// </summary>
    public partial class Categories2E : Page
    {
        private MagazinCosmetikiEntities contextCat = new MagazinCosmetikiEntities();
        public Categories2E()
        {
            InitializeComponent();
            Categories2Edg.ItemsSource = contextCat.Categories.ToList();

        }
    }
}
