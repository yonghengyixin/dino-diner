using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using DinoDiner.Menu;

namespace MenuTest
{
    public class MorkEntrees : IOrderItem
    {
        public double price;

        public event PropertyChangedEventHandler PropertyChanged;

        public double Price { get; set; }

        public string Description => throw new NotImplementedException();

        public string[] Special => throw new NotImplementedException();

        public MorkEntrees(double num)
        {
            Price = num;
        }
    }
}
