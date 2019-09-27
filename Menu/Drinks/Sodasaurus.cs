/*Auther: Yijun Lin
 * Menu Milestone 3
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu;

namespace DinoDiner.Menu.Drinks
{
    public class Sodasaurus : Drink
    {
        /// <summary>
        /// set a flavor
        /// </summary>
        private SodaSaurusFlavor flavor;
        public SodaSaurusFlavor Flavor
        {
            get { return flavor; }
            set { flavor = value; }
        }

        /// <summary>
        /// set a size,then set the price and calories
        /// </summary>
        private Size size;
        public override Size Size {
            get { return size; }
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
            }
        }

        /// <summary>
        /// set ingredientd
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return ingredients;
            }
        }

        public Sodasaurus()
        {
            Ice = true;
            Size = Size.Small;
            ingredients.Add("Water");
            ingredients.Add("Natural Flavors");
            ingredients.Add("Cane Sugar");
        }

        
    }
}
