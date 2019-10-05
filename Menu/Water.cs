/*Auther: Yijun Lin
 * Menu Milestone 3
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{
    public class Water : Drink
    {
        /// <summary>
        /// set a bool for Lemon
        /// </summary>
        public bool Lemon { get; set; } = false;

        private Size size;

        /// <summary>
        /// set size then set the value and calories
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set
            {

                size = value;
                if (size == Size.Small)
                {
                    Price = 0.10;
                    Calories = 0;
                }
                else if (size == Size.Medium)
                {
                    Price = 0.10;
                    Calories = 0;
                }
                else if (size == Size.Large)
                {
                    Price = 0.10;
                    Calories = 0;
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
                List<string> ingredients = new List<string>() { "Brautwurst" };
                ingredients.Add("Water");
                if (Lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }

        /// <summary>
        /// return currect string
        /// </summary>
        public Water()
        {
            Ice = true;
            Size = Size.Small;
        }

        public override string ToString()
        {
            return $"{size.ToString()} Water";
        }

    }
}
