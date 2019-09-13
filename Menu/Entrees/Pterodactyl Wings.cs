/// <summary>
/// author: Yijun Lin
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class PterodactylWings
    {
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
                List<string> ingredients = new List<string>() { "Chicken"};
                ingredients.Add("Wing Sauce");
                return ingredients;
            }
        }

        /// <summary>
        /// set the price and calories
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }
    }
}
