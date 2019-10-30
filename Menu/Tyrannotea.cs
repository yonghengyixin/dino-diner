/*Auther: Yijun Lin
 * Menu Milestone 3
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{
    public class Tyrannotea : Drink
    {
        private bool sweet = false;

        /// <summary>
        /// set a bool for sweet
        /// </summary>
        public bool Sweet {
            get
            {
                return sweet;
            }
            set
            {
                NotifyOfPropertyChanged("Description");
            }
        }

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
            get {
                
                return size; }
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
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Ingredients");
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

        public void MakeSweet()
        {
            Sweet = true;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Description");
        }

        /// <summary>
        /// set ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() ;
                ingredients.Add("Water");
                ingredients.Add("Tea");
                if (Sweet) ingredients.Add("Cane Sugar");
                if (Lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }

        /// <summary>
        /// set org items
        /// </summary>
        public Tyrannotea()
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
            if (Sweet)
            {
                return $"{size.ToString()} Sweet Tyrannotea";
            }
            return $"{size.ToString()} Tyrannotea";
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
