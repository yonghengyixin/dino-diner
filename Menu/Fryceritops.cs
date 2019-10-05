using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Fryceritops : Side
    {
        /// <summary>
        /// creat the size
        /// </summary>
        private Size size;

        /// <summary>
        /// set the size
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 222;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
                        break;

                }
            }
            get { return size; }
        }

        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Potato");
                ingredients.Add("Salt");
                ingredients.Add("Vegetable Oil");
                return ingredients;
            }
        }

        /// <summary>
        /// return the datas
        /// </summary>
        public Fryceritops()
        {
            Size = Size.Small;
        }

        /// <summary>
        /// return currect string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{size.ToString()} Friceritops";
        }
    }
}
