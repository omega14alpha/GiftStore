using GiftStore.Models;
using System;

namespace GiftStore.Infrastructure.SweetnessFactory
{
    public abstract class Factory
    {
        protected Random _random;

        public Factory()
        {
            _random = new Random();
        }

        public abstract Sweetness CreateSweetness();
    }
}
