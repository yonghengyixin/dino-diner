/// <summary>
/// author: Yijun Lin
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class TRexKingBurger : Entree
    {
        /// <summary>
        /// check customer want these things or not
        /// </summary>
        private bool bun = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool onion = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool mayo = true;

        /// <summary>
        /// customer's chooses
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                ingredients.Add("Steakburger Pattie");
                ingredients.Add("Steakburger Pattie");
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }

        /// <summary>
        /// set the price and calories
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
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
        public void HoldLettuce()
        {
            lettuce = false;
        }

        /// <summary>
        /// want this thing or not
        /// </summary>
        public void HoldTomato()
        {
            tomato = false;
        }

        /// <summary>
        /// want this thing or not
        /// </summary>
        public void HoldOnion()
        {
            onion = false;
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

        /// <summary>
        /// want this thing or not
        /// </summary>
        public void HoldMayo()
        {
            mayo = false;
        }

        /// <summary>
        /// return currect string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "T-Rex King Burger";
        }
    }
}
