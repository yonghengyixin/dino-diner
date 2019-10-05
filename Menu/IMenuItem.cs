using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public interface IMenuItem
    {
        /// <summary>
        /// get price
        /// </summary>
        double Price { get; }

        /// <summary>
        /// get calories
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// get ingredients
        /// </summary>
        List<string> Ingredients { get; }
    }
}
