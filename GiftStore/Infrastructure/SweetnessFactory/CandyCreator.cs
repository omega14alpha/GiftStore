using GiftStore.Models;

namespace GiftStore.Infrastructure.SweetnessFactory
{
    public class CandyCreator : Factory
    {
        public override Candy CreateSweetness()
        {
            Candy[] candies = new Candy[]
                {
                    new Candy() { Name = "GoldenKey", Manufacturer = "ABC", Weight = 23.1f, SugarContent = 12.6f, Taste = "Lemon" },
                    new Candy() { Name = "Barberry", Manufacturer = "CNoR", Weight = 16.9f, SugarContent = 9.01f, Taste = "Barberry" },
                    new Candy() { Name = "CherryShow", Manufacturer = "KFC", Weight = 10.5f, SugarContent = 5.7f, Taste = "Cherry" },
                    new Candy() { Name = "LittleMix", Manufacturer = "ABC", Weight = 19.3f, SugarContent = 14.32f, Taste = "Assorty" },
                    new Candy() { Name = "FruitAssorty", Manufacturer = "CNoR", Weight = 24.5f, SugarContent = 17.2f, Taste = "Fruit" }
                };

            int index = _random.Next(0, candies.Length);
            return candies[index];
        }
    }
}
