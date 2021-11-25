using GiftStore.Models;

namespace GiftStore.Infrastructure.SweetnessFactory
{
    public class AgarCandyCreator : Factory
    {
        public override AgarCandy CreateSweetness()
        {
            AgarCandy[] agarCandies = new AgarCandy[]
                {
                    new AgarCandy() { Name = "SweetFruit", Weight = 25.4f, SugarContent = 7.41f },
                    new AgarCandy() { Name = "Dance", Weight = 16.1f, SugarContent = 5.77f }
                };

            int index = _random.Next(0, agarCandies.Length);
            return agarCandies[index];
        }
    }
}
