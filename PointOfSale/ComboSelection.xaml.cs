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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        public ComboSelection()
        {
            InitializeComponent();
        }

        /*void CustomizeCombo(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new Customize());
        }*/

        public void OnAddDinoNuggetsCombo(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                CretaceousCombo combo = new CretaceousCombo(new DinoNuggets());
                order.Add(combo);
                NavigationService.Navigate(new Customize(combo));
            }
        }

        public void OnAddBrontowurstCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo combo = new CretaceousCombo(new Brontowurst());
                order.Add(combo);
                NavigationService.Navigate(new Customize(combo));
            }
        }

        public void OnAddPterodactylWingsCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo combo = new CretaceousCombo(new PterodactylWings());
                order.Add(combo);
                NavigationService.Navigate(new Customize(combo));
            }
        }

        public void OnAddSteakosaurusBurgerCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo combo = new CretaceousCombo(new SteakosaurusBurger());
                order.Add(combo);
                NavigationService.Navigate(new Customize(combo));
            }
        }

        public void OnAddTRexKingBurgerCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo combo = new CretaceousCombo(new TRexKingBurger());
                order.Add(combo);
                NavigationService.Navigate(new Customize(combo));
            }
        }

        public void OnAddVelociWrapCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo combo = new CretaceousCombo(new VelociWrap());
                order.Add(combo);
                NavigationService.Navigate(new Customize(combo));
            }
        }

        public void OnAddPrehistoricPBJCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo combo = new CretaceousCombo(new PrehistoricPBJ());
                order.Add(combo);
                NavigationService.Navigate(new Customize(combo));
            }
        }
    }
}
