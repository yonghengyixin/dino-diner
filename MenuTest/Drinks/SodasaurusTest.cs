using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class SodasaurusTest
    {
        //1.The ability to set each possible flavor
        [Fact]
        public void ShouldBeAbleToSetFlavor()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Cherry;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cherry,soda.Flavor);

            soda.Flavor = SodasaurusFlavor.Cola;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cola, soda.Flavor);

            soda.Flavor = SodasaurusFlavor.Orange;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Orange, soda.Flavor);

            soda.Flavor = SodasaurusFlavor.Vanilla;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Vanilla, soda.Flavor);

            soda.Flavor = SodasaurusFlavor.Chocolate;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Chocolate, soda.Flavor);

            soda.Flavor = SodasaurusFlavor.RootBeer;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.RootBeer, soda.Flavor);

            soda.Flavor = SodasaurusFlavor.Lime;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Lime, soda.Flavor);

        }

        //2.The correct default price, calories, ice, and size
        [Fact]
        public void ShouldHaveCorrectDefaultItems()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<double>(1.50, soda.Price);
            Assert.Equal<double>(112, soda.Calories);
            Assert.True(soda.Ice);
            Assert.Equal<Size>(0, soda.Size);

        }


        //3.The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectCaloriesAndPriceAfterSettingSize()
        {
            Sodasaurus soda = new Sodasaurus();

            //small
            soda.Size = Size.Small;
            Assert.Equal<double>(1.50, soda.Price);
            Assert.Equal<double>(112, soda.Calories);

            //mid
            soda.Size = Size.Medium;
            Assert.Equal<double>(2.00, soda.Price);
            Assert.Equal<double>(156, soda.Calories);

            //larg
            soda.Size = Size.Large;
            Assert.Equal<double>(2.50, soda.Price);
            Assert.Equal<double>(208, soda.Calories);
        }


        //4.That invoking  results in the Ice property being false.
        [Fact]
        public void ShouldHaveCorrectIceAfterSettring()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.False(soda.Ice);
        }


        //5.The correct ingredients are given
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Contains<string>("Water", soda.Ingredients);
            Assert.Contains<string>("Natural Flavors", soda.Ingredients);
            Assert.Contains<string>("Cane Sugar", soda.Ingredients);
        }
    }
}
