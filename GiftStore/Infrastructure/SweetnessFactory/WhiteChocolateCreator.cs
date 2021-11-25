using GiftStore.Models;

namespace GiftStore.Infrastructure.SweetnessFactory
{
    public class WhiteChocolateCreator : Factory
    {
        public override WhiteChocolate CreateSweetness()
        {
            WhiteChocolate[] whiteChocolates = new WhiteChocolate[]
                {
                    new WhiteChocolate() { Name = "ChocoNuts", Weight = 200, SugarContent = 53.6f, PercentageCocoaContent = 72, IsPorous = true },
                    new WhiteChocolate() { Name = "Milk", Weight = 100, SugarContent = 57.12f, PercentageCocoaContent = 54 }
                };

            int index = _random.Next(0, whiteChocolates.Length);
            return whiteChocolates[index];
        }
    }
}
