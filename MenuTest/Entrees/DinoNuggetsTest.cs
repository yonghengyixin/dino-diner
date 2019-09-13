using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu.Entrees;


namespace MenuTest.Entrees
{
    public class DinoNuggetsUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            DinoNugget dn = new DinoNugget();
            Assert.Equal(4.25, dn.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            DinoNugget dn = new DinoNugget();
            Assert.Equal<uint>(59*6, dn.Calories);
        }


        [Fact]
        public void ShouldListDefaultIngredients()
        {
            DinoNugget dn = new DinoNugget();
            List<string> ingredients = dn.Ingredients;
            // Should be six nuggets
            int nuggetCount = 0;
            foreach(string ingredient in ingredients)
            {
                if (ingredient.Equals("Chicken Nugget")) nuggetCount++;
            }
            Assert.Equal(6, nuggetCount);
            Assert.Equal<int>(6, ingredients.Count);
        }

        public void AddingNuggetsShouldAddIngredients()
        {
            DinoNugget dn = new DinoNugget();
            dn.AddNugget();
            // Should be seven nuggets
            int nuggetCount = 0;
            foreach (string ingredient in dn.Ingredients)
            {
                if (ingredient.Equals("Chicken Nugget")) nuggetCount++;
            }
            Assert.Equal(7, nuggetCount);
            Assert.Equal<int>(7, dn.Ingredients.Count);

            dn.AddNugget();
            // Should be 8 nuggets
            nuggetCount = 0;
            foreach (string ingredient in dn.Ingredients)
            {
                if (ingredient.Equals("Chicken Nugget")) nuggetCount++;
            }
            Assert.Equal(8, nuggetCount);
            Assert.Equal<int>(8, dn.Ingredients.Count);

        }

        public void AddingNuggetsShouldIncreasePrice()
        {
            DinoNugget dn = new DinoNugget();
            dn.AddNugget();
            Assert.Equal(dn.Price, 4.50,2);
            dn.AddNugget();
            Assert.Equal(dn.Price, 4.75,2);
            dn.AddNugget();
            Assert.Equal(dn.Price, 5.0,2);
        }


        public void AddingNuggetsShouldIncreaseCalories()
        {
            DinoNugget dn = new DinoNugget();
            dn.AddNugget();
            Assert.Equal<uint>(dn.Calories, 59*7);
            dn.AddNugget();
            Assert.Equal<uint>(dn.Calories, 59*8);
            dn.AddNugget();
            Assert.Equal<uint>(dn.Calories, 59*9);
        }
    }
}
