using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drinks
    {
        public bool Sweet { get; set; } = false;

        public bool Lemon { get; set; } = false;

        private Size size = Size.Small;
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                if (size == Size.Small)
                {
                    Price = 0.99;
                    if (Sweet == false)
                    {
                        Calories = 8;
                    }
                    else
                    {
                        Calories = 16;
                    }
                    
                }
                else if (size == Size.Medium)
                {
                    Price = 1.49;
                    if (Sweet == false)
                    {
                        Calories = 16;
                    }
                    else
                    {
                        Calories = 32;
                    }
                }
                else if (size == Size.Large)
                {
                    Price = 1.99;
                    if (Sweet == false)
                    {
                        Calories = 32;
                    }
                    else
                    {
                        Calories = 64;
                    }
                }
            }
        }

        public bool AddLemon()
        {
            bool Lemon = true;
            return Lemon;
        }

        public override List<string> Ingredients
        {
            get
            {
                return ingredients;
            }
        }

        public Tyrannotea()
        {
            Ice = true;
            size = Size.Small;
            ingredients.Add("Water");
            ingredients.Add("Tea");
            if(Sweet) ingredients.Add("Cane Sugar");
            if (Lemon) ingredients.Add("Lemon");
        }
    }
}
