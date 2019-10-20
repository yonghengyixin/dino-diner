using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace MenuTest
{
    public class MorkSides : IOrderItem
    {
        public double price;

        public double Price { get; set; }

        public string Description => throw new NotImplementedException();

        public string[] Special => throw new NotImplementedException();

        public MorkSides(double num)
        {
            Price = num;
        }
    }
}
