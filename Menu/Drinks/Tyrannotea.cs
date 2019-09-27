/*Auther: Yijun Lin
 * Menu Milestone 3
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drink
    {
        /// <summary>
        /// set a bool for sweet
        /// </summary>
        public bool Sweet { get; set; } = false;

        /// <summary>
        /// set a bool for lemon
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// set a size, then set the price ang calories
        /// </summary>
        private Size size;
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

        /// <summary>
        /// change lemon to true
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
        }

        /// <summary>
        /// set ingredients
        /// </summary>
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
            Size = Size.Small;
            ingredients.Add("Water");
            ingredients.Add("Tea");
            if(Sweet) ingredients.Add("Cane Sugar");
            if (Lemon) ingredients.Add("Lemon");
        }
    }
}
