using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest
{
    public class OrderTest
    {
        [Fact]
        public void ShouldHaveCorrectPrice()
        {
            MorkDrinks md = new MorkDrinks(1);
            MorkEntrees me = new MorkEntrees(2);
            MorkSides ms = new MorkSides(3);

            Order o = new Order();
            o.Items.Add(md);
            o.Items.Add(me);
            o.Items.Add(ms);
            Assert.Equal<double>(6, o.SubtotalCost);
        }

        [Fact]
        public void NotAllowNegPrice()
        {
            MorkDrinks md = new MorkDrinks(-100);
            MorkEntrees me = new MorkEntrees(2);
            MorkSides ms = new MorkSides(3);

            Order o = new Order();
            o.Items.Add(md);
            o.Items.Add(me);
            o.Items.Add(ms);
            Assert.Equal<double>(0, o.SubtotalCost);
        }
    }
}
