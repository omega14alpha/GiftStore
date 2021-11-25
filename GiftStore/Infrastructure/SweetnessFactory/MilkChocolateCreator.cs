using GiftStore.Models;

namespace GiftStore.Infrastructure.SweetnessFactory
{
    public class MilkChocolateCreator : Factory
    {
        public override MilkChocolate CreateSweetness()
        {
            MilkChocolate[] milkChocolates = new MilkChocolate[]
                {
                    new MilkChocolate() { Name = "AlpenGold", Weight = 100, SugarContent = 0f, PercentageCocoaContent = 12, MilkFatContent = 14.52f },
                    new MilkChocolate() { Name = "Mu-Mu", Weight = 150, SugarContent = 0f, PercentageCocoaContent = 42, MilkFatContent = 34.15f }
                };

            int index = _random.Next(0, milkChocolates.Length);
            return milkChocolates[index];
        }
    }
}
