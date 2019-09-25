using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu;

namespace DinoDiner.Menu.Drinks
{
    public class Sodasaurus : Drinks
    {
        private SodaSaurusFlavor flavor;
        public SodaSaurusFlavor Flavor
        {
            get { return flavor; }
            set { flavor = value; }
        }

        
        private Size size = Size.Small;
        public override Size Size {
            get { return size; }
            set {
                size = value;
                if(size == Size.Small)
                {
                    Price = 1.50;
                    Calories = 112;
                }
                else if(size == Size.Medium)
                {
                    Price = 2.00;
                    Calories = 156;
                }
                else if(size == Size.Large)
                {
                    Price = 2.5;
                    Calories = 208;
                }
            }
        }

        public override List<string> Ingredients
        {
            get
            {
                return ingredients;
            }
        }

        public Sodasaurus()
        {
            Ice = true;
            size = Size.Small;
            ingredients.Add("Water");
            ingredients.Add("Natural Flavors");
            ingredients.Add("Cane Sugar");
        }

    }
}
