using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace DinoDiner.Menu
{
    public class Order
    {
        /// <summary>
        /// set a ObservableCollection to get all items
        /// </summary>
        public ObservableCollection<IMenuItem> Items { get; } = new ObservableCollection<IMenuItem>();

        /// <summary>
        /// get sub total cost
        /// </summary>
        private double subtotalCost;
        public double SubtotalCost
        {
            get
            {
                foreach(IMenuItem i in Items)
                {
                    subtotalCost += i.Price;
                }
                if(subtotalCost < 0)
                {
                    subtotalCost = 0;
                }
                return subtotalCost;
            }
        }

        /// <summary>
        /// set tax rate
        /// </summary>
        public double SalesTaxRate { get; protected set; }

        /// <summary>
        /// get tax cost
        /// </summary>
        public double SalesTaxCost
        {
            get { return SalesTaxRate * SubtotalCost; }
        }

        /// <summary>
        /// coculate total cost
        /// </summary>
        public double TotalCost
        {
            get { return SalesTaxCost + SubtotalCost; }
        }
    }
}
