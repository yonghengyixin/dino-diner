using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu.Drinks
{
    public abstract class Drinks
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

        public abstract Size Size { get; set; }

        public bool Ice { get; set; } = true;

        public bool HoldIce()
        {
            bool ice = false;
            return ice;
        }
    }
}
