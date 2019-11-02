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
using DDSize = DinoDiner.Menu.Size;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        private Drink drink;

        private CretaceousCombo combo;

        /// <summary>
        /// default of drinkSelection
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
            lemon.IsEnabled = false;
            flavor.IsEnabled = false;
            ice.IsEnabled = false;
        }

        public DrinkSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            lemon.IsEnabled = false;
            flavor.IsEnabled = false;
            ice.IsEnabled = false;
            this.combo = combo;
            drink = combo.Drink;
        }

        /// <summary>
        /// default of drinkSelection
        /// </summary>
        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            
            if(drink is Sodasaurus)
            {
                lemon.IsEnabled = false;
                this.drink = drink;
            }
            else
            {
                lemon.IsEnabled = false;
                flavor.IsEnabled = false;
                ice.IsEnabled = false;
                this.drink = drink;
            }
        }

        /// <summary>
        /// hold sodasaurus button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void Sodasaurus_Click(object sender,RoutedEventArgs args)
        {
            lemon.IsEnabled = false;
            flavor.IsEnabled = true;
            ice.IsEnabled = true;
            if (DataContext is Order order)
            {
                drink = new Sodasaurus();
                order.Add(drink);
            }
        }

        /// <summary>
        /// hold tea button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void Tyrannotea_Click(object sender, RoutedEventArgs args)
        {
            lemon.IsEnabled = true;
            flavor.IsEnabled = true;
            ice.IsEnabled = true;
            if (DataContext is Order order)
            {
                drink = new Tyrannotea();
                order.Add(drink);
            }
        }

        /// <summary>
        /// hold java button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void JurrasicJava_Click(object sender, RoutedEventArgs args)
        {
            lemon.IsEnabled = false;
            flavor.IsEnabled = true;
            ice.IsEnabled = true;
            if (DataContext is Order order)
            {
                drink = new JurassicJava();
                order.Add(drink);
            }
        }

        /// <summary>
        /// hold water button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void Water_Click(object sender, RoutedEventArgs args)
        {
            lemon.IsEnabled = true;
            flavor.IsEnabled = false;
            ice.IsEnabled = true;
            if (DataContext is Order order)
            {
                drink = new Water();
                order.Add(drink);
            }
        }

        /// <summary>
        /// hold all size change button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnChangeSide(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                drink.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
            }
        }

        /// <summary>
        /// hold add lemon button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void AddLemon(object sender, RoutedEventArgs args)
        {
            if (drink is Tyrannotea tea)
            {
                tea.AddLemon();
            }
            else if(drink is Water water)
            {
                water.AddLemon();
            }
        }

        /// <summary>
        /// hold ice button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void HoldIce(object sender, RoutedEventArgs args)
        {
            if(drink is Tyrannotea tea)
            {
                tea.HoldIce();
            }
            else if(drink is JurassicJava java)
            {
                java.AddIce();
            }
            else if(drink is Sodasaurus soda)
            {
                soda.HoldIce();
            }
            else if(drink is Water water)
            {
                water.HoldIce();
            }
        }

        /// <summary>
        /// hold soda flavor button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectFlavor(object sender, RoutedEventArgs args)
        {
            if(drink is JurassicJava java)
            {
                java.MakeDecaf();
            }
            else if(drink is Tyrannotea tea)
            {
                tea.MakeSweet();
            }
            else if(drink is Sodasaurus soda)
            {
                NavigationService.Navigate(new Flavor(soda));
            }
            
        }

        /// <summary>
        /// hold done button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void Done(object sender, RoutedEventArgs args)
        {
            if(combo != null)
            {
                NavigationService.Navigate(new Customize(combo));
            }
            else
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
    }
}
