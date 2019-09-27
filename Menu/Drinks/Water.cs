/*Auther: Yijun Lin
 * Menu Milestone 3
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu;

namespace DinoDiner.Menu.Drinks
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
                Price = 0.10;
                Calories = 0;  
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

        public Water()
        {
            Ice = true;
            Size = Size.Small;
            ingredients.Add("Water");
            if(Lemon) ingredients.Add("Lemon");
        }
    }
}
