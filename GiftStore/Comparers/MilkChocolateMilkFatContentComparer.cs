using GiftStore.Models;
using System.Collections.Generic;

namespace GiftStore.Comparers
{
    public class MilkChocolateMilkFatContentComparer : IComparer<object>
    {
        public int Compare(object x, object y)
        {
            if (x is MilkChocolate chocolateX && y is MilkChocolate chocolateY)
            {
                return chocolateX.MilkFatContent > chocolateY.MilkFatContent ? 1 : -1;
            }

            return 0;
        }
    }
}
