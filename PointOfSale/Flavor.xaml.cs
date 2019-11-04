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

        private CretaceousCombo combo;

        public Flavor(Sodasaurus drink)
        {
            InitializeComponent();
            this.soda = drink;
            
        }

        public Flavor(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            soda = (Sodasaurus)combo.Drink;
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
                if(combo == null)
                {
                    soda.Flavor = (DDF)Enum.Parse(typeof(DDF), element.Tag.ToString());
                    NavigationService.Navigate(new DrinkSelection(soda));
                }
                else
                {
                    soda.Flavor = (DDF)Enum.Parse(typeof(DDF), element.Tag.ToString());
                    NavigationService.Navigate(new DrinkSelection(combo));
                }
            }
            
        }
    }
}
