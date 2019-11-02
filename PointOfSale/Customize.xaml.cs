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
    /// Interaction logic for Customize.xaml
    /// </summary>
    public partial class Customize : Page
    {
        private CretaceousCombo combo;

        public Customize()
        {
            InitializeComponent();
        }

        public Customize(CretaceousCombo combo)
        {
            InitializeComponent();
            EntreeButton.IsEnabled = true;
            this.combo = combo;
            if(combo.Entree is Entree entree)
            {
                if (entree is PterodactylWings pw)
                {
                    EntreeButton.IsEnabled = false;
                }
            }
        }

        void SelectDrink(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection(combo));
        }

        void SelectSide(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection());
        }

        void SelectEntree(object sender, RoutedEventArgs args)
        {
            
            if (combo.Entree is Entree entree)
            {
                if(entree is DinoNuggets dn)
                {
                    NavigationService.Navigate(new CustomizeDinoNuggets(dn));
                }
                else if(entree is Brontowurst bt)
                {
                    NavigationService.Navigate(new CustomizeBrontowurst(bt));
                }
                else if(entree is SteakosaurusBurger sb)
                {
                    NavigationService.Navigate(new CustomizeSteakosaurusBurger(sb));
                }
                else if(entree is TRexKingBurger tb)
                {
                    NavigationService.Navigate(new CustomizeTRexKingBurger(tb));
                }
                else if(entree is VelociWrap vw)
                {
                    NavigationService.Navigate(new CustomizeVelociWrap(vw));
                }
                else if(entree is PrehistoricPBJ pbj)
                {
                    NavigationService.Navigate(new CustomizePrehistoricPBJ(pbj));
                }
            }
        }
    }
}
