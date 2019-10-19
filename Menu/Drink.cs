/*Auther: Yijun Lin
 * Menu Milestone 3
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public abstract class Drink : IMenuItem, INotifyPropertyChanged
    {

        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// set the size
        /// </summary>
        public abstract Size Size { get; set; }

        public abstract string Description { get; }

        public abstract string[] Special { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// set a bool for ice
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// set ice to false
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
        }

        
    }
}
