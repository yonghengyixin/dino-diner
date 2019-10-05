/// <summary>
/// author: Yijun Lin
/// </summary>

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{

    public class VelociWrap : Entree
    {
        /// <summary>
        /// check customer want these things or not
        /// </summary>
        private bool dressing = true;
        private bool lettuce = true;
        private bool cheese = true;

        /// <summary>
        /// customer's chooses
        /// </summary>
        public override List<string> Ingredients
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
        public void HoldCheese()
        {
            cheese = false;
        }

        /// <summary>
        /// return currect string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
        }
    }
}
