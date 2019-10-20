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
            get {
                
                return size; }
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
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Description");
            }
        }

        /// <summary>
        /// change lemon to true
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
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

        /// <summary>
        /// return currect string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{size.ToString()} Water";
        }

        /// <summary>
        /// Gets a descriiption of the order item
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// get special order
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ice) special.Add("Hold Ice");
                if (Lemon) special.Add("Add Lemon");
                return special.ToArray();
            }
        }
    }
}
