/// <summary>
/// author: Yijun Lin
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNugget
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
                List<string> ingredients = new List<string>();
                for(int i = 0; i < 6; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// set the price and calories
        /// </summary>
        public DinoNugget()
        {
            uint nuggetCount = 0;
            foreach (string ingredient in Ingredients)
            {
                if (ingredient.Equals("Chicken Nugget")) nuggetCount++;
            }
            this.Price = 4.25 + 0.25 * (nuggetCount - 6);
            this.Calories = 59 * nuggetCount;
        }

        /// <summary>
        /// add a chicken nugget to the list everytime
        /// </summary>
        public void AddNugget()
        {
            Ingredients.Add("Chicken Nugget");
        }
    }
}
