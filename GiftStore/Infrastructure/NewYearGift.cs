using GiftStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GiftStore.Infrastructure
{
    public class NewGift<T> : ICandyGift<T> where T : Sweetness
    {
        private List<T> _sweetnesses;
        private string _message;

        public IEnumerable<T> Sweetnesses
        {
            get => _sweetnesses;
        }

        public string Message
        {
            get => _message;
            set => _message = value;
        }

        public NewGift()
        {
            _sweetnesses = new List<T>();
        }

        public void AddSweetness(T sweetness) =>
            _sweetnesses.Add(sweetness);

        public void AddSweetness(IEnumerable<T> sweetness) =>
            _sweetnesses.AddRange(sweetness);

        public void DeleteSweetness(T sweetness) =>
            _sweetnesses.Remove(sweetness);

        public T FindSweetnessBySugarContent(float min, float max) =>
            _sweetnesses.FirstOrDefault(x => x.SugarContent >= min && x.SugarContent <= max);

        public float GetGiftWeight() =>
            _sweetnesses.Sum(x => x.Weight);

        public void SortSweetness<K>(Func<T, K> func) =>
            _sweetnesses = _sweetnesses.OrderBy(func).ToList();

        public void SortSweetness<R>(IComparer<object> comparer) =>
            _sweetnesses = _sweetnesses.OrderBy(x => x is R).ThenBy(x => x, comparer).ToList();
    }
}
