using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Water : Drinks
    {
        public bool Lemon { get; set; } = false;

        private Size size = Size.Small;
        public override Size Size
        {
            get { return size; }
            set
            {
                Price = 0.10;
                Calories = 0;  
            }
        }

        public bool AddLemon()
        {
            bool lemon = true;
            return lemon;
        }

        public Water()
        {
            Ice = true;
            size = Size.Small;
            ingredients.Add("Water");
            if(Lemon) ingredients.Add("Lemon");
        }
    }
}
