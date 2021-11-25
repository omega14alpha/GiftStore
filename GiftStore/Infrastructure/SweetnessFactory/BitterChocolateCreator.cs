using GiftStore.Models;

namespace GiftStore.Infrastructure.SweetnessFactory
{
    public class BitterChocolateCreator : Factory
    {
        public override BitterChocolate CreateSweetness()
        {
            BitterChocolate[] bitterChocolates = new BitterChocolate[]
                {
                    new BitterChocolate() { Name = "Oktober", Weight = 100, SugarContent = 67.12f, PercentageCocoaContent = 75 },
                    new BitterChocolate() { Name = "Alenka", Weight = 50, SugarContent = 34.02f, PercentageCocoaContent = 55, WithStuffing = true }
                };

            int index = _random.Next(0, bitterChocolates.Length);
            return bitterChocolates[index];
        }
    }
}
