using GiftStore.Enums;
using GiftStore.Models;

namespace GiftStore.Infrastructure.SweetnessFactory
{
    public class JellyCandyCreator : Factory
    {
        public override JellyCandy CreateSweetness()
        {
            JellyCandy[] jellyCandies = new JellyCandy[]
                {
                    new JellyCandy() { Name = "LittleBee", Manufacturer = "Roshen", Weight = 19.1f, SugarContent = 8.71f, ThickeningAgent = ThickeningAgent.Gelatin },
                    new JellyCandy() { Name = "CherryJelly", Manufacturer = "ABC", Weight = 23.7f, SugarContent = 14.34f, ThickeningAgent = ThickeningAgent.Agar },
                    new JellyCandy() { Name = "Berry", Manufacturer = "Bin", Weight = 14.3f, SugarContent = 11.2f, ThickeningAgent = ThickeningAgent.Pectin },
                    new JellyCandy() { Name = "HoneyBe", Manufacturer = "Bin", Weight = 17.5f, SugarContent = 4.12f, ThickeningAgent = ThickeningAgent.Gelatin },
                    new JellyCandy() { Name = "SweetFruit", Manufacturer = "ABC", Weight = 25.4f, SugarContent = 7.41f, ThickeningAgent = ThickeningAgent.Agar }
                };

            int index = _random.Next(0, jellyCandies.Length);
            return jellyCandies[index];
        }
    }
}
