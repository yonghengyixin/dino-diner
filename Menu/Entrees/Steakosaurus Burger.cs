using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    class SteakosaurusBurger
    {
        private bool bun = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;

        public double Price { get; set;}

        public uint Calories { get; set;}

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "steakburger pattie" };
                if (bun) ingredients.Add("whole wheat bun");
                if (pickle) ingredients.Add("pickle");
                if (ketchup) ingredients.Add("ketchup");
                if (mustard) ingredients.Add("mustard");
                return ingredients;
            }
        }

        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }

        public void HoldBun()
        {
            bun = false;
        }

        public void HoldPickle()
        {
            pickle = false;
        }

        public void HoldKetchup()
        {
            ketchup = false;
        }

        public void HoldMustard()
        {
            mustard = false;
        }
    }
}
