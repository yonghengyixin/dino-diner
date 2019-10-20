using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class WaterTest
    {
        //1.The correct default price, calories, ice, size, and lemon properties.
        [Fact]
        public void ShouldHaveCorrectDefaultItems()
        {
            Water wat = new Water();
            Assert.Equal<double>(0.1, wat.Price);
            Assert.Equal<double>(0, wat.Calories);
            Assert.True(wat.Ice);
            Assert.Equal<Size>(0, wat.Size);
            Assert.False(wat.Lemon);
        }

        //2.The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectCaloriesAndPriceAfterSettingSize()
        {
            Water wat = new Water();

            //small
            wat.Size = Size.Small;
            Assert.Equal<double>(0.10, wat.Price);
            Assert.Equal<double>(0, wat.Calories);

            //mid
            wat.Size = Size.Medium;
            Assert.Equal<double>(0.10, wat.Price);
            Assert.Equal<double>(0, wat.Calories);

            //larg
            wat.Size = Size.Large;
            Assert.Equal<double>(0.10, wat.Price);
            Assert.Equal<double>(0, wat.Calories);
        }

        //3.That invoking HoldIce() results in the Ice property being false
        [Fact]
        public void ShouldHaveCorrectIceAfterSettring()
        {
            Water wat = new Water();
            wat.HoldIce();
            Assert.False(wat.Ice);
        }

        //4.That invoking AddLemon() sets results in the Lemon property being true.
        [Fact]
        public void ShouldHaveCorrectLemonAfterSetting()
        {
            Water wat = new Water();
            wat.AddLemon();
            Assert.True(wat.Lemon);
        }

        //5.The correct ingredients are given.
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Water wat = new Water();
            Assert.Contains<string>("Water", wat.Ingredients);
            if(wat.Lemon)Assert.Contains<string>("Lemon", wat.Ingredients);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void DescriptionShouldBeCorrect(Size size)
        {
            Water wat = new Water();
            wat.Size = size;
            Assert.Equal($"{size.ToString()} Water", wat.Description);
        }

        [Fact]
        public void SpecialShouldBeEmptyByDefault()
        {
            Water wat = new Water();
            Assert.Empty(wat.Special);
        }

        [Fact]
        public void HoldIceShouldAddToSpecial()
        {
            Water wat = new Water();
            wat.Ice = false;
            Assert.Collection<string>(wat.Special,
                item =>
                {
                    Assert.Equal("Hold Ice", item);
                });
        }

        [Fact]
        public void ShouldAddLemonToSpecial()
        {
            Water wat = new Water();
            wat.AddLemon();
            Assert.Collection<string>(wat.Special,
                item =>
                {
                    Assert.Equal("Add Lemon", item);
                });
        }

        [Fact]
        public void ShouldHoldIceAndAddLemonToSpecial()
        {
            Water wat = new Water();
            wat.Ice = false;
            wat.AddLemon();
            Assert.Collection<string>(wat.Special,
                item =>
                {
                    Assert.Equal("Hold Ice", item);
                },
                item =>
                {
                    Assert.Equal("Add Lemon", item);
                });
        }

        [Fact]
        public void AddLemonShouldNotifyToIngredientsAndSpecial()
        {
            Water wat = new Water();
            Assert.PropertyChanged(wat, "Ingredients", () =>
            {
                wat.AddLemon();
            });
            Assert.PropertyChanged(wat, "Special", () =>
            {
                wat.AddLemon();
            });
        }
    }
}
