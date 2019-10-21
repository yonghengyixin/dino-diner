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
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Order order = DataContext as Order;
            if(order != null)
            {
                order.Items.Add(new PrehistoricPBJ());
                order.Items.Add(new Sodasaurus());
                order.Items.Add(new Fryceritops());
                SteakosaurusBurger sb = new SteakosaurusBurger();
                sb.HoldPickle();
                sb.HoldBun();
                order.Items.Add(sb);
            }
        }
    }
}
