using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public interface IOrderItrm
    {
        double Price
        {
            get;
        }

        string Description
        {
            get;
        }

        string[] Special
        {
            get;
        }
    }
}
