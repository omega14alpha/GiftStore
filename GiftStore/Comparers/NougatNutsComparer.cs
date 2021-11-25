using GiftStore.Models;
using System.Collections.Generic;

namespace GiftStore.Comparers
{
    public class NougatNutsComparer : IComparer<object>
    {
        public int Compare(object x, object y)
        {
            if (x is Nougat nougatX && y is Nougat nougatY)
            {
                return nougatX.Nuts > nougatY.Nuts ? 1 : -1;
            }

            return 0;
        }
    }
}
