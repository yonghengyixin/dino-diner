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
using DinoDiner.Menu;
using DDF = DinoDiner.Menu.SodasaurusFlavor;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for Flavor.xaml
    /// </summary>
    public partial class Flavor : Page
    {
        private Sodasaurus soda;

        
        public Flavor(Sodasaurus drink)
        {
            InitializeComponent();
            this.soda = drink;
            
        }

        /// <summary>
        /// handle all flavor button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void ChooseFlavor(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                soda.Flavor = (DDF)Enum.Parse(typeof(DDF), element.Tag.ToString());
                NavigationService.Navigate(new DrinkSelection(soda));
            }
            
        }
    }
}
