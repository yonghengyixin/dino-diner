/*Auther: Yijun Lin
 * Menu Milestone 3
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu.Drinks
{
    public abstract class Drink
    {
        protected List<string> ingredients = new List<string>();

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
