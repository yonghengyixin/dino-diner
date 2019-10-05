/// <summary>
/// author: Yijun Lin
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class PterodactylWings : Entree
    {

        /// <summary>
        /// customer's chooses
        /// </summary>
        public override List<string> Ingredients
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

        public override string ToString()
        {
            return "Pterodactyl Wings";
        }
    }
}
