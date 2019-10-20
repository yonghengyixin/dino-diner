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

        /// <summary>
        /// set a Description
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// set a Special
        /// </summary>
        public abstract string[] Special { get; }

        /// <summary>
        /// get all notify change in to event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// get notify change
        /// </summary>
        /// <param name="propertyName"></param>
        public void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// set ice to true
        /// </summary>
        private bool ice = true;

        /// <summary>
        /// set a bool for ice
        /// </summary>
        public bool Ice {
            get { return ice; }
            set {
                
                ice = value;
            }
        }

        /// <summary>
        /// set ice to false
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
            NotifyOfPropertyChanged("Special");
        }

        
    }
}
