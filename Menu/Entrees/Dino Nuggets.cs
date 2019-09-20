/// <summary>
/// author: Yijun Lin
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets : EntreeBase
    {

        /// <summary>
        /// customer's chooses
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for(int i = 0; i < NuggetCount; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// set num = 6 at begining
        /// </summary>
        private uint NuggetCount = 6;

        /// <summary>
        /// set the price and calories
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59 * NuggetCount;
        }

        /// <summary>
        /// add a chicken nugget to the list everytime
        /// </summary>
        public void AddNugget()
        {
            NuggetCount++;
            Price = Price + 0.25;
            Calories += 59;
        }
    }
}
