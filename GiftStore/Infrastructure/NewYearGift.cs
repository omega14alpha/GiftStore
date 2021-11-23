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

        public void AddSweetness(T sweetness)
        {
            if (sweetness is null)
            {
                throw new ArgumentNullException("parameter 'sweetness' cannot be null!");
            }

            _sweetnesses.Add(sweetness);
        }

        public void AddSweetness(IEnumerable<T> sweetnesses)
        {
            if (sweetnesses is null)
            {
                throw new ArgumentNullException("parameter 'sweetnesses' cannot be null!");
            }

            _sweetnesses.AddRange(sweetnesses);
        }

        public void DeleteSweetness(T removeSweetness)
        {
            if (removeSweetness is null)
            {
                throw new ArgumentNullException("parameter 'removeSweetness' cannot be null!");
            }

            _sweetnesses.Remove(removeSweetness);
        }

        public T FindSweetnessBySugarContent(float min, float max)
        {
            if (min < 0 || max < 0)
            {
                throw new ArgumentOutOfRangeException("None of the parameters can be less than zero!"); 
            }

            return _sweetnesses.FirstOrDefault(x => x.SugarContent >= min && x.SugarContent <= max);
        }

        public float GetGiftWeight()
        {
            return _sweetnesses.Sum(x => x.Weight);
        }

        public void SortSweetness<K>(Func<T, K> sortFunc)
        {
            if (sortFunc is null)
            {
                throw new ArgumentNullException("parameter 'sortFunc' cannot be null!");
            }

            _sweetnesses = _sweetnesses.OrderBy(sortFunc).ToList();
        }

        public void SortSweetness<R>(IComparer<object> sortComparer)
        {
            if (sortComparer is null)
            {
                throw new ArgumentNullException("parameter 'sortComparer' cannot be null!");
            }

            _sweetnesses = _sweetnesses.OrderBy(x => x is R).ThenBy(x => x, sortComparer).ToList();
        }
    }
}
