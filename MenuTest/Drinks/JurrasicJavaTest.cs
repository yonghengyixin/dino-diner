using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class JurrasicJavaTest
    {
        //1.The correct default price, calories, ice, size, and SpaceForCream properties.
        [Fact]
        public void ShouldHaveCorrectDefaultItems()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal<double>(0.59, java.Price);
            Assert.Equal<double>(2, java.Calories);
            Assert.False(java.Ice);
            Assert.Equal<Size>(0, java.Size);
            Assert.False(java.RoomForCream);
        }

        //2.The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectCaloriesAndPriceAfterSettingSize()
        {
            JurrasicJava java = new JurrasicJava();

            //small
            java.Size = Size.Small;
            Assert.Equal<double>(0.59, java.Price);
            Assert.Equal<double>(2, java.Calories);

            //mid
            java.Size = Size.Medium;
            Assert.Equal<double>(0.99, java.Price);
            Assert.Equal<double>(4, java.Calories);

            //larg
            java.Size = Size.Large;
            Assert.Equal<double>(1.49, java.Price);
            Assert.Equal<double>(8, java.Calories);
        }

        //3.That invoking AddIce() results in the Ice property being true
        [Fact]
        public void ShouldHaveCorrectIceAfterSettring()
        {
            JurrasicJava java = new JurrasicJava();
            java.AddIce();
            Assert.True(java.Ice);
        }

        //4.That invoking LeaveSpaceForCream() results in the SpaceForCream property being true.
        [Fact]
        public void ShouldHaveCorrectCreamAfterSetting()
        {
            JurrasicJava java = new JurrasicJava();
            java.RoomForCream = true;
            Assert.True(java.RoomForCream);
        }

        //5.The correct ingredients are given.
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Contains<string>("Water", java.Ingredients);
            Assert.Contains<string>("Coffee", java.Ingredients);
        }
    }
}
