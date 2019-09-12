using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    class Brontowurst
    {
        private bool bun = true;
        private bool peppers = true;
        private bool onion = true;

        public double Price { get; set; }

        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "brautwurst" };
                if (bun) ingredients.Add("whole-wheat bun");
                if (peppers) ingredients.Add("peppers");
                if (onion) ingredients.Add("onion");
                return ingredients;
            }
        }

        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        public void HoldBun()
        {
            this.bun = false;
        }

        public void HoldPeppers()
        {
            this.peppers = false;
        }

        public void HoldOnion()
        {
            this.onion = false;
        }
    }
}
