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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        private Entree entree;

        public EntreeSelection()
        {
            InitializeComponent();
        }

        public EntreeSelection(Entree entree)
        {
            InitializeComponent();
            this.entree = entree;
        }

        /// <summary>
        /// handle pbj button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void OnAddPrehistoricPBJ(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                order.Add(pbj);
                NavigationService.Navigate(new CustomizePrehistoricPBJ(pbj));
            }
        }

        /// <summary>
        /// handle brontowurst button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void OnAddBrontowurst(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Brontowurst bt = new Brontowurst();
                order.Add(bt);
                NavigationService.Navigate(new CustomizeBrontowurst(bt));
            }
        }

        /// <summary>
        /// handle nugget button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void OnAddDinoNuggets(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                DinoNuggets dn = new DinoNuggets();
                order.Add(dn);
                NavigationService.Navigate(new CustomizeDinoNuggets(dn));
            }
        }

        /// <summary>
        /// handle pterodacty wings button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void OnAddPterodactylWings(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                PterodactylWings pw = new PterodactylWings();
                order.Add(pw);
            }
        }

        /// <summary>
        /// handle steakosaurus burger button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void OnAddSteakosaurusBurger(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                SteakosaurusBurger sb = new SteakosaurusBurger();
                order.Add(sb);
                NavigationService.Navigate(new CustomizeSteakosaurusBurger(sb));
            }
        }

        /// <summary>
        /// handle t king burger button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void OnAddTRexKingBurger(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                TRexKingBurger tk = new TRexKingBurger();
                order.Add(tk);
                NavigationService.Navigate(new CustomizeTRexKingBurger(tk));
            }
        }

        /// <summary>
        /// handle veloci wrap button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void OnAddVelociWrap(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                VelociWrap vw = new VelociWrap();
                order.Add(vw);
                NavigationService.Navigate(new CustomizeVelociWrap(vw));
            }
        }
    }
}
