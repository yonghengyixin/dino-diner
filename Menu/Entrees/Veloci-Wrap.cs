/// <summary>
/// author: Yijun Lin
/// </summary>

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{

    public class VelociWrap
    {
        /// <summary>
        /// check customer want these things or not
        /// </summary>
        private bool dressing = true;
        private bool lettuce = true;
        private bool cheese = true;

        /// <summary>
        /// create a price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// create the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// customer's chooses
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Flour Tortilla");
                ingredients.Add("Chicken Breast");
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        /// <summary>
        /// set the price and calories
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        /// <summary>
        /// want this thing or not
        /// </summary>
        public void HoldDressing()
        {
            dressing = false;
        }

        /// <summary>
        /// want this thing or not
        /// </summary>
        public void HoldLettuce()
        {
            lettuce = false;
        }

        /// <summary>
        /// want this thing or not
        /// </summary>
        public void holdCheese()
        {
            cheese = false;
        }
    }
}
