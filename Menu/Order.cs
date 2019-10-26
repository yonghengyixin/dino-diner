using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Order : INotifyPropertyChanged
    {
        double salesTaxRate = 0;
        private List<IOrderItem> items;

        public event PropertyChangedEventHandler PropertyChanged;

        public IOrderItem[] Items
        {
            get { return items.ToArray(); }
        }

        /// <summary>
        /// get sub total cost
        /// </summary>
        private double subtotalCost;
        public double SubtotalCost
        {
            get
            {
                double total = 0;
                foreach(IOrderItem item in Items)
                {
                    total += item.Price;
                }
                return Math.Max(total, 0);
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
            get { return salesTaxRate * SubtotalCost; }
        }

        /// <summary>
        /// coculate total cost
        /// </summary>
        public double TotalCost
        {
            get { return SalesTaxCost + SubtotalCost; }
        }

        public Order()
        {
            items = new List<IOrderItem>();
        }

        public void Add(IOrderItem item)
        {
            item.PropertyChanged += OnCollectionChanged;
            items.Add(item);
            OnCollectionChanged(this, new EventArgs());

        }

        private void OnCollectionChanged(object sender,EventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }

        public bool Remove(IOrderItem item)
        {
            
            bool re = items.Remove(item);
            OnCollectionChanged(this, new EventArgs());
            return re;
        }
    }
}
