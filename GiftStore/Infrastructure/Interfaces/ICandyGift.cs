using System;
using System.Collections.Generic;

namespace GiftStore.Infrastructure.Interfaces
{
    public interface ICandyGift<T> : IGift
    {
        IEnumerable<T> Sweetnesses { get; }

        void AddSweetness(T sweetness);

        void AddSweetness(IEnumerable<T> sweetness);

        void DeleteSweetness(T sweetness);

        void SortSweetness<K>(Func<T, K> func);

        void SortSweetness<R>(IComparer<object> comparer);

        T FindSweetnessBySugarContent(float min, float max);
    }
}
