using GiftStore.Models;

namespace GiftStore.Infrastructure.SweetnessFactory
{
    public class ChocolateBarCreator : Factory
    {
        public override ChocolateBar CreateSweetness()
        {
            ChocolateBar[] chocolateBars = new ChocolateBar[]
                {
                    new ChocolateBar() { Name = "AlpenGold", Manufacturer = "AG", Weight = 100, SugarContent = 67.12f, PercentageCocoaContent = 12, WithNuts = false },
                    new ChocolateBar() { Name = "Alenka", Manufacturer = "Komunarka", Weight = 50, SugarContent = 34.02f, PercentageCocoaContent = 32, WithNuts = true },
                    new ChocolateBar() { Name = "Mu-Mu", Manufacturer = "Roshen", Weight = 150, SugarContent = 32.47f, PercentageCocoaContent = 42, WithNuts = false },
                    new ChocolateBar() { Name = "ChocoNuts", Manufacturer = "Komunarka", Weight = 200, SugarContent = 53.6f, PercentageCocoaContent = 72, WithNuts = true },
                    new ChocolateBar() { Name = "Milk", Manufacturer = "AG", Weight = 100, SugarContent = 57.12f, PercentageCocoaContent = 54, WithNuts = false }
                };

            int index = _random.Next(0, chocolateBars.Length);
            return chocolateBars[index];
        }
    }
}
