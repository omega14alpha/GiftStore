using GiftStore.Models;
using System.Collections.Generic;

namespace GiftStore.Comparers
{
    public class LollipopColorComparer : IComparer<object>
    {
        public int Compare(object x, object y)
        {
            if (x is Lollipop lollipopX && y is Lollipop lollipopY)
            {
                return lollipopX.Color.Name[0] > lollipopY.Color.Name[0] ? 1 : -1;
            }

            return 0;
        }
    }
}
