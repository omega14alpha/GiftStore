using GiftStore.Models;

namespace GiftStore.Infrastructure.SweetnessFactory
{
    public class PectinCandyCreator : Factory
    {
        public override PectinCandy CreateSweetness()
        {
            PectinCandy[] jellyCandies = new PectinCandy[]
                {
                    new PectinCandy() { Name = "Berry", Weight = 14.3f, SugarContent = 8.14f },
                    new PectinCandy() { Name = "HoneyBe", Weight = 17.5f, SugarContent = 4.12f }
                };

            int index = _random.Next(0, jellyCandies.Length);
            return jellyCandies[index];
        }
    }
}
