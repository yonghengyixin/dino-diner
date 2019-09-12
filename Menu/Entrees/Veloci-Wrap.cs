using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    class VelociWrap
    {
        private bool dressing = true;
        private bool lettuce = true;
        private bool cheese = true;

        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                ingredients.Add("flour tortilla");
                ingredients.Add("chicken breast");
                if (dressing) ingredients.Add("Ceasar dressing");
                if (lettuce) ingredients.Add("romaine lettuce");
                if (cheese) ingredients.Add("parmesan cheese");
                return ingredients;
            }
        }

        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        public void HoldDressing()
        {
            dressing = false;
        }

        public void HoldLettuce()
        {
            lettuce = false;
        }

        public void HoldCheese()
        {
            cheese = false;
        }
    }
}
