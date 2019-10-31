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
        public EntreeSelection()
        {
            InitializeComponent();
        }

        //private Entree entree;

        /*/// <summary>
        /// hold bontowursr button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectBrontowurst(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new Brontowurst();
                order.Add(entree);
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        /// <summary>
        /// handle nuggets button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectDinoNuggets(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                entree = new DinoNuggets();
                order.Add(entree);
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        /// <summary>
        /// handle PBJ button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectPrehistoricPBJ(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new PrehistoricPBJ();
                order.Add(entree);
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        /// <summary>
        /// handle pterodactyl wings button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectPterodactylWings(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new PterodactylWings();
                order.Add(entree);
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        /// <summary>
        /// handle steakosaurus burger button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectSteakosaurusBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new SteakosaurusBurger();
                order.Add(entree);
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        /// <summary>
        /// handle T king burger button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectTKingBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new TRexKingBurger();
                order.Add(entree);
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        /// <summary>
        /// handle veloci warp button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectVelociWrap(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new VelociWrap();
                order.Add(entree);
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }*/

        void OnAddPrehistoricPBJ(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                order.Add(pbj);
                NavigationService.Navigate(new CustomizePrehistoricPBJ(pbj));
            }
        }

        void OnAddBrontowurst(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Brontowurst bt = new Brontowurst();
                order.Add(bt);
                NavigationService.Navigate(new CustomizeBrontowurst(bt));
            }
        }

        void OnAddDinoNuggets(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                DinoNuggets dn = new DinoNuggets();
                order.Add(dn);
                NavigationService.Navigate(new CustomizeDinoNuggets(dn));
            }
        }

        void OnAddPterodactylWings(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                PterodactylWings pw = new PterodactylWings();
                order.Add(pw);
            }
        }

        void OnAddSteakosaurusBurger(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                SteakosaurusBurger sb = new SteakosaurusBurger();
                order.Add(sb);
                NavigationService.Navigate(new CustomizeSteakosaurusBurger(sb));
            }
        }

        void OnAddTRexKingBurger(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                TRexKingBurger tk = new TRexKingBurger();
                order.Add(tk);
                NavigationService.Navigate(new CustomizeTRexKingBurger(tk));
            }
        }

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
