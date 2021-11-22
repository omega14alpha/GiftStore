using GiftStore.Models;
using System.Collections.Generic;

namespace GiftStore.Comparers
{
    public class CandyTasteComarer : IComparer<object>
    {
        public int Compare(object x, object y)
        {
            if (x is Candy candyX && y is Candy candyY)
            {
                return candyX.Taste[0] > candyY.Taste[0] ? 1 : -1;
            }

            return 0;
        }
    }
}
