using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    class DinoNuggets
    {
        public double Price { get; set; }

        public uint Calories { get; set; }

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

        public DinoNuggets()
        {
            uint nuggetCount = 0;
            foreach (string ingredient in Ingredients)
            {
                if (ingredient.Equals("Chicken Nugget")) nuggetCount++;
            }
            this.Price = 4.25 + 0.25 * (nuggetCount - 6);
            this.Calories = 59 * nuggetCount;
        }

        public void AddNuggets()
        {
            Ingredients.Add("Chicken Nugget");
        }
    }
}
