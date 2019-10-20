using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public interface IOrderItem
    {
        /// <summary>
        /// get Price
        /// </summary>
        double Price
        {
            get;
        }

        /// <summary>
        /// get Description
        /// </summary>
        string Description
        {
            get;
        }

        /// <summary>
        /// get special
        /// </summary>
        string[] Special
        {
            get;
        }
    }
}
