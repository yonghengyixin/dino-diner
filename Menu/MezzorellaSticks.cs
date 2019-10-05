using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class MezzorellaSticks : Side
    {

        private Size size;

        /// <summary>
        /// change the size
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
                        Calories = 540;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 610;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 720;
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
                ingredients.Add("Cheese Product");
                ingredients.Add("Breading");
                ingredients.Add("Vegetable Oil");
                return ingredients;
            }
        }

        /// <summary>
        /// return the datas
        /// </summary>
        public MezzorellaSticks()
        {
            Size = Size.Small;
        }

        public override string ToString()
        {
            return $"{size.ToString()} Mezzorella Sticks";
        }
    }
}
