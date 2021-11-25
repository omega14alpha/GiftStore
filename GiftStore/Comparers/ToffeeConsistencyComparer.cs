using GiftStore.Models;
using System.Collections.Generic;

namespace GiftStore.Comparers
{
    public class ToffeeConsistencyComparer : IComparer<object>
    {
        public int Compare(object x, object y)
        {
            if (x is Toffee toffeeX && y is Toffee toffeeY)
            {
                return toffeeX.Consistency > toffeeY.Consistency ? 1 : -1;
            }

            return 0;
        }
    }
}
