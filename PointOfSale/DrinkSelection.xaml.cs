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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        public DrinkSelection()
        {
            InitializeComponent();
            lemon.IsEnabled = false;
            flavor.IsEnabled = false;
            ice.IsEnabled = false;
        }

        void SelectFlavor(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new Flavor());
        }

        private void Sodasaurus_Click(object sender,RoutedEventArgs args)
        {
            lemon.IsEnabled = false;
            flavor.IsEnabled = true;
            ice.IsEnabled = false;
        }

        private void Tyrannotea_Click(object sender, RoutedEventArgs args)
        {
            lemon.IsEnabled = true;
            flavor.IsEnabled = true;
            ice.IsEnabled = false;
        }

        private void JurrasicJava_Click(object sender, RoutedEventArgs args)
        {
            lemon.IsEnabled = false;
            flavor.IsEnabled = true;
            ice.IsEnabled = true;
        }

        private void Water_Click(object sender, RoutedEventArgs args)
        {
            lemon.IsEnabled = true;
            flavor.IsEnabled = false;
            ice.IsEnabled = false;
        }
    }
}
