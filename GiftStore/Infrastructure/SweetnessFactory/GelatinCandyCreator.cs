using GiftStore.Models;

namespace GiftStore.Infrastructure.SweetnessFactory
{
    public class GelatinCandyCreator : Factory
    {
        public override GelatinCandy CreateSweetness()
        {
            GelatinCandy[] gelatinCandies = new GelatinCandy[]
                {
                    new GelatinCandy() { Name = "LittleBee", Weight = 19.1f, SugarContent = 8.71f },
                    new GelatinCandy() { Name = "CherryJelly", Weight = 23.7f, SugarContent = 14.34f }
                };

            int index = _random.Next(0, gelatinCandies.Length);
            return gelatinCandies[index];
        }
    }
}
