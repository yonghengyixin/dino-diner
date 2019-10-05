/// <summary>
/// author: Yijun Lin
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class SteakosaurusBurger : Entree
    {
        /// <summary>
        /// check customer want these things or not
        /// </summary>
        private bool bun = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;

        /// <summary>
        /// customer's chooses
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }

        /// <summary>
        /// set the price and calories
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }

        /// <summary>
        /// want this thing or not
        /// </summary>
        public void HoldBun()
        {
            bun = false;
        }

        /// <summary>
        /// want this thing or not
        /// </summary>
        public void HoldPickle()
        {
            pickle = false;
        }

        /// <summary>
        /// want this thing or not
        /// </summary>
        public void HoldKetchup()
        {
            ketchup = false;
        }

        /// <summary>
        /// want this thing or not
        /// </summary>
        public void HoldMustard()
        {
            mustard = false;
        }

        public override string ToString()
        {
            return "Steakosaurus Burger";
        }
    }
}
