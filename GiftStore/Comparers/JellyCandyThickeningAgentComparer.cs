using GiftStore.Models;
using System.Collections.Generic;

namespace GiftStore.Comparers
{
    public class JellyCandyThickeningAgentComparer : IComparer<object>
    {
        public int Compare(object x, object y)
        {
            if (x is JellyCandy candyX && y is JellyCandy candyY)
            {
                return candyX.ThickeningAgent < candyY.ThickeningAgent ? 1 : -1;
            }

            return 0;
        }
    }
}
