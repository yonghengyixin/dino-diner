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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeBrontowurst.xaml
    /// </summary>
    public partial class CustomizeBrontowurst : Page
    {
        private Brontowurst bt;

        public CustomizeBrontowurst(Brontowurst bt)
        {
            InitializeComponent();
            this.bt = bt;
        }

        private void OnHoldBun(object sender,RoutedEventArgs args)
        {
            bt.HoldBun();
        }

        private void OnHoldPeppers(object sender, RoutedEventArgs args)
        {
            bt.HoldPeppers();
        }

        private void OnHoldOnions(object sender, RoutedEventArgs args)
        {
            bt.HoldOnion();
        }

        private void OnDone(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
        }
    }
}
