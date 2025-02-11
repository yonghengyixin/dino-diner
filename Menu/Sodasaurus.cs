﻿/*Auther: Yijun Lin
 * Menu Milestone 3
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{
    public class Sodasaurus : Drink, IMenuItem
    {
        /// <summary>
        /// set a flavor
        /// </summary>
        private SodasaurusFlavor flavor;
        public SodasaurusFlavor Flavor
        {
            get { return flavor; }
            set { flavor = value; NotifyOfPropertyChanged("Description"); }
        }

        /// <summary>
        /// set a size,then set the price and calories
        /// </summary>
        private Size size;
        public override Size Size {
            get {
                
                return size; }
            set {
                size = value;
                if(size == Size.Small)
                {
                    Price = 1.50;
                    Calories = 112;
                }
                else if(size == Size.Medium)
                {
                    Price = 2.00;
                    Calories = 156;
                }
                else if(size == Size.Large)
                {
                    Price = 2.5;
                    Calories = 208;
                }
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Description");
            }
        }

        /// <summary>
        /// set ingredientd
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                ingredients.Add("Natural Flavors");
                ingredients.Add("Cane Sugar");
                return ingredients;
            }
        }

        /// <summary>
        /// set org items
        /// </summary>
        public Sodasaurus()
        {
            Ice = true;
            Size = Size.Small;
        }

        /// <summary>
        /// return currect string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{size.ToString()} {flavor.ToString()} Sodasaurus";
        }

        /// <summary>
        /// Gets a descriiption of the order item
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// get special order
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }
    }
}
