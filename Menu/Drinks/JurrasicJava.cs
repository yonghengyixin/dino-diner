using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class JurrasicJava : Drinks
    {
        public bool RoomForCream { get; set; } = false;

        public bool Decaf { get; set; } = false;

        private Size size = Size.Small;
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

        public bool LeaveRoomForCream()
        {
            bool cream = true;
            return cream;
        }

        public bool AddIce()
        {
            bool ice = true;
            return ice;
        }

        public override List<string> Ingredients
        {
            get
            {
                return ingredients;
            }
        }

        public JurrasicJava()
        {
            Ice = false;
            RoomForCream = false;
            size = Size.Small;
            ingredients.Add("Water");
            ingredients.Add("Coffee");
        }
    }
}
