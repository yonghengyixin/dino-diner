using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Sides;
using DinoDiner.Menu.Drinks;

namespace DinoDiner.Menu
{
    public class CretaceousCombo
    {
        public EntreeBase Entree { get; set; }

        private Side side;
        public Side Side {
            get
            {
                return side;
            }
            set
            {
                side = value;
                side.Size = size;
            }
        }



        public Drink Drinks { get; set; }

        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drinks.Price - 0.25;
            }
        }

        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drinks.Calories;
            }
        }

        private Size size = Size.Small;
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                Drinks.Size = value;
                Side.Size = value;
            }
        }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drinks.Ingredients);
                return ingredients;
            }
        }


        public CretaceousCombo(EntreeBase entree)
        {
            Entree = entree;
            Side = new Fryceritops();
            Drinks = new Sodasaurus();
        }
    }
}
