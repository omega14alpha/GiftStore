using GiftStore.Models;
using System.Collections.Generic;

namespace GiftStore.Comparers
{
    public class ChocolateBarCocoaContentComparer : IComparer<object>
    {
        public int Compare(object x, object y)
        {
            if (x is ChocolateBar candyX && y is ChocolateBar candyY)
            {
                return candyX.PercentageCocoaContent > candyY.PercentageCocoaContent ? 1 : -1;
            }

            return 0;
        }
    }
}
