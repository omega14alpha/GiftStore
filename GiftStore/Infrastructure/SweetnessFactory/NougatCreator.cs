using GiftStore.Enums;
using GiftStore.Models;

namespace GiftStore.Infrastructure.SweetnessFactory
{
    public class NougatCreator : Factory
    {
        public override Nougat CreateSweetness()
        {
            Nougat[] nougats = new Nougat[]
                {
                    new Nougat() { Name = "CherryShow", Weight = 10.5f, SugarContent = 5.7f, Taste = "Coffee with cherry", Nuts = Nuts.Almonds },
                    new Nougat() { Name = "LittleMix", Weight = 19.3f, SugarContent = 14.32f, Taste = "Capuchino", Nuts = Nuts.Walnuts }
                };

            int index = _random.Next(0, nougats.Length);
            return nougats[index];
        }
    }
}
