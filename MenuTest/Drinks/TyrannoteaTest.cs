using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class TyrannoteaTest
    {
        //1.The correct default price, calories, ice, size, lemon, and sweet properties.
        [Fact]
        public void ShouldHaveCorrectDefaultItems()
        {
            Tyrannotea tyr = new Tyrannotea();
            Assert.Equal<double>(0.99, tyr.Price);
            Assert.Equal<double>(8, tyr.Calories);
            Assert.True(tyr.Ice);
            Assert.Equal<Size>(0, tyr.Size);
            Assert.False(tyr.Lemon);
            Assert.False(tyr.Sweet);
        }

        //2.The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectCaloriesAndPriceAfterSettingSize()
        {
            Tyrannotea tyr = new Tyrannotea();

            //small
            tyr.Size = Size.Small;
            Assert.Equal<double>(0.99, tyr.Price);
            Assert.Equal<double>(8, tyr.Calories);

            //mid
            tyr.Size = Size.Medium;
            Assert.Equal<double>(1.49, tyr.Price);
            Assert.Equal<double>(16, tyr.Calories);

            //larg
            tyr.Size = Size.Large;
            Assert.Equal<double>(1.99, tyr.Price);
            Assert.Equal<double>(32, tyr.Calories);
        }

        //3.That invoking HoldIce() results in the Ice property being false
        [Fact]
        public void ShouldHaveCorrectIceAfterSettring()
        {
            Tyrannotea tyr = new Tyrannotea();
            tyr.HoldIce();
            Assert.False(tyr.Ice);
        }

        //4.That invoking AddLemon() sets results in the Lemon property being true.
        [Fact]
        public void ShouldHaveCorrectLemonAfterSetting()
        {
            Tyrannotea tyr = new Tyrannotea();
            tyr.AddLemon();
            Assert.True(tyr.Lemon);
        }

        //5.That setting the sweet property to true results in the right calories for each size
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSweet()
        {
            Tyrannotea tyr = new Tyrannotea();
            tyr.Sweet = true;

            //small
            tyr.Size = Size.Small;
            Assert.Equal<double>(16, tyr.Calories);

            //mid
            tyr.Size = Size.Medium;
            Assert.Equal<double>(32, tyr.Calories);

            //larg
            tyr.Size = Size.Large;
            Assert.Equal<double>(64, tyr.Calories);
        }

        //6.That setting the sweet property to false (after it has been set to true) results in the right calories for each size.
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingToNotSweet()
        {
            Tyrannotea tyr = new Tyrannotea();
            tyr.Sweet = true;

            //small
            tyr.Sweet = false;
            tyr.Size = Size.Small;
            Assert.Equal<double>(8, tyr.Calories);

            //mid
            tyr.Sweet = false;
            tyr.Size = Size.Medium;
            Assert.Equal<double>(16, tyr.Calories);

            //larg
            tyr.Sweet = false;
            tyr.Size = Size.Large;
            Assert.Equal<double>(32, tyr.Calories);
        }

        //7.The correct ingredients are given.
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Tyrannotea tyr = new Tyrannotea();
            Assert.Contains<string>("Water", tyr.Ingredients);
            Assert.Contains<string>("Tea", tyr.Ingredients);
            if(tyr.Lemon)Assert.Contains<string>("Lemon", tyr.Ingredients);
            if(tyr.Sweet)Assert.Contains<string>("Cane Sugar", tyr.Ingredients);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void DescriptionShouldBeCorrect(Size size)
        {
            Tyrannotea tyr = new Tyrannotea();
            tyr.Size = size;
            Assert.Equal($"{size.ToString()} Sweet Tyrannotea", tyr.Description);

            tyr.Sweet = true;
            Assert.Equal($"{size.ToString()} Tyrannotea", tyr.Description);
        }

        [Fact]
        public void SpecialShouldBeEmptyByDefault()
        {
            Tyrannotea tyr = new Tyrannotea();
            Assert.Empty(tyr.Special);
        }

        [Fact]
        public void HoldIceShouldAddToSpecial()
        {
            Tyrannotea tyr = new Tyrannotea();
            tyr.Ice = false;
            Assert.Collection<string>(tyr.Special,
                item =>
                {
                    Assert.Equal("Hold Ice", item);
                });
        }

        [Fact]
        public void ShouldAddLemonToSpecial()
        {
            Tyrannotea tyr = new Tyrannotea();
            tyr.AddLemon();
            Assert.Collection<string>(tyr.Special,
                item =>
                {
                    Assert.Equal("Add Lemon", item);
                });
        }

        [Fact]
        public void ShouldHoldIceAndAddLemonToSpecial()
        {
            Tyrannotea tyr = new Tyrannotea();
            tyr.Ice = false;
            tyr.AddLemon();
            Assert.Collection<string>(tyr.Special,
                item =>
                {
                    Assert.Equal("Hold Ice", item);
                },
                item =>
                {
                    Assert.Equal("Add Lemon", item);
                });

        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangeSizeShouldNotifyPriceAndCalories(Size size)
        {
            Tyrannotea tyr = new Tyrannotea();
            Assert.PropertyChanged(tyr, "Price", () =>
            {
                tyr.Size = size;
            });
            Assert.PropertyChanged(tyr, "Calories", () =>
            {
                tyr.Size = size;
            });
            Assert.PropertyChanged(tyr, "Ingredients", () =>
            {
                tyr.Size = size;
            });
        }

        [Fact]
        public void HoldIceShouldNotifySpecialChange()
        {
            Tyrannotea tyr = new Tyrannotea();
            Assert.PropertyChanged(tyr, "Special", () =>
            {
                tyr.Ice = false;
            });
        }

        [Fact]
        public void AddLemonShouldNotifyIngredientsAndSpecialChange()
        {
            Tyrannotea tyr = new Tyrannotea();
            Assert.PropertyChanged(tyr, "Ingredients", () =>
            {
                tyr.AddLemon();
            });
            Assert.PropertyChanged(tyr, "Special", () =>
            {
                tyr.AddLemon();
            });
        }
    }
}
