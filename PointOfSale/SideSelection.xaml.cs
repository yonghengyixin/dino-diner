﻿using System;
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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        private Side side;

        private CretaceousCombo combo;

        public SideSelection()
        {
            InitializeComponent();
            MakeDone.IsEnabled = false;
        }

        public SideSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            MakeSmall.IsEnabled = false;
            MakeMedium.IsEnabled = false;
            MakeLarge.IsEnabled = false;
            this.combo = combo;
            side = combo.Side;
        }

        public SideSelection(Side side)
        {
            InitializeComponent();
            MakeDone.IsEnabled = false;
            this.side = side;
        }

        /// <summary>
        /// handle fryceritops button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectFryceritops(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if(combo == null)
                {
                    side = new Fryceritops();
                    order.Add(side);
                }
                else
                {
                    MakeDone.IsEnabled = true;
                    combo.Side = new Fryceritops();
                    side = combo.Side;
                }
            }
        }

        /// <summary>
        /// handle meteor mac & cheese button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectMeteorMacAndCheese(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if(combo == null)
                {
                    
                    side = new MeteorMacAndCheese();
                    order.Add(side);
                }
                else
                {
                    MakeDone.IsEnabled = true;
                    combo.Side = new MeteorMacAndCheese();
                    side = combo.Side;
                }
            }
        }

        /// <summary>
        /// handle mezzorella sticks button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectMezzorellaSticks(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if(combo == null)
                {
                    MakeDone.IsEnabled = false;
                    side = new MezzorellaSticks();
                    order.Add(side);
                }
                else
                {
                    MakeDone.IsEnabled = true;
                    combo.Side = new MezzorellaSticks();
                    side = combo.Side;
                }
            }
        }

        /// <summary>
        /// handle triceritots button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectTriceritots(object sender,RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if(combo == null)
                {
                    MakeDone.IsEnabled = false;
                    side = new Triceritots();
                    order.Add(side);
                }
                else
                {
                    MakeDone.IsEnabled = true;
                    combo.Side = new Triceritots();
                    side = combo.Side;
                }
            }
        }

        /// <summary>
        /// handle all size change button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnChangeSide(object sender, RoutedEventArgs args)
        {
            if(sender is FrameworkElement element)
            {
                side.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
                NavigationService.GoBack();
            }
        }

        /// <summary>
        /// hold done button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void Done(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new Customize(combo));
            
        }
    }
}
