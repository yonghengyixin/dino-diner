/*Auther: Yijun Lin
 * Menu Milestone 3
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class JurassicJava : Drink
    {
        /// <summary>
        /// set a bool for cream
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// set a bool for decaf
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// set a size,then set the price and colories
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
                    Price = 0.59;
                    Calories = 2;
                }
                else if (size == Size.Medium)
                {
                    Price = 0.99;
                    Calories = 4;
                }
                else if (size == Size.Large)
                {
                    Price = 1.49;
                    Calories = 8;
                }
            }
        }

        /// <summary>
        /// set cream to true
        /// </summary>
        /// <returns></returns>
        public bool LeaveRoomForCream()
        {
            bool cream = true;
            return cream;
        }

        /// <summary>
        /// set ice to true
        /// </summary>
        public void AddIce()
        {
            Ice = true;
        }

        /// <summary>
        /// set ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                ingredients.Add("Coffee");
                return ingredients;
            }
        }

        public JurassicJava()
        {
            Ice = false;
            RoomForCream = false;
            Size = Size.Small;
        }

        public override string ToString()
        {
            if (Decaf)
            {
                return $"{size.ToString()} Decaf Jurassic Java";
            }
            return $"{size.ToString()} Jurassic Java";
        }
    }
}
