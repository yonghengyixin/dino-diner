/// <summary>
/// author: Yijun Lin
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class DinoNuggets : Entree
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

        /// <summary>
        /// return currect string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }

        /// <summary>
        /// Gets a descriiption of the order item
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if((int)NuggetCount>6)
                {
                    special.Add($"{NuggetCount - 6} Extra Nuggets");
                }
                return special.ToArray();
            }
        }
    }
}
